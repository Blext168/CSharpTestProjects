using StructuralPatterns.Facade.Subsystems;

namespace StructuralPatterns.Facade;

public class OrderFacade(InventoryService pInventory, PaymentService pPayment, ShippingService pShipping)
{
    private readonly InventoryService _inventory = pInventory;
    private readonly PaymentService _payment = pPayment;
    private readonly ShippingService _shipping = pShipping;

    public (bool success, string message) PlaceOrder(string pProductId, 
                                                     int pQuantity, 
                                                     string pAccountId, 
                                                     decimal pAmount,
                                                     string pShippingAddress)
    {
        Console.WriteLine("[OrderFacade]: Starte Auftragserstellung...");
        
        // 1) Prüfen ob Artikel verfügbar ist
        if (!_inventory.IsInStock(pProductId, pQuantity))
            return (false, "Product ist nicht verfügbar");
        
        // 2) Reservieren
        _inventory.Reserve(pProductId, pQuantity);
        
        // 3) Zahlung ausführen
        if (!_payment.Charge(pAccountId, pAmount))
            return (false, "Zahlung fehlgeschlagen");
        
        // 4) Versand planen
        string tracking = _shipping.ScheduleDelivery(pProductId, pQuantity, pShippingAddress);
        
        return (true, tracking);
    }
}