namespace StructuralPatterns.Facade.Subsystems;

// Subsystem 1: Produktkatalog / Lagerverwaltung
public class InventoryService
{
    public bool IsInStock(string pProductId, int pQuantity)
    {
        // simple simulation: all products with even length are in stock
        Console.WriteLine($"[Inventory]: Prüfe Lager für Produkt {pProductId} (Menge {pQuantity})");
        return pProductId.Length % 2 == 0;
    }

    public void Reserve(string pProductId, int pQuantity)
    {
        Console.WriteLine($"[Inventory]: Reserviere {pQuantity}x {pProductId}");
    }
}