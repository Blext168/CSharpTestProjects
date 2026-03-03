namespace StructuralPatterns.Facade.Subsystems;

// Subsystem 3: Versand / Shipping
public class ShippingService
{
    public string ScheduleDelivery(string pProductId, int pQuantity, string pAddress)
    {
        Console.WriteLine($"[Shipping]: Versand geplant an \"{pAddress}\" für {pQuantity}x {pProductId}");
        // Rückgabe einer Sendungsnummer
        return "TRACK-" + Guid.NewGuid().ToString("N")[..8].ToUpper();
    }
}