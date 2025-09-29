namespace StructuralPatterns.Facade;

// Consumer / Client
public class OrderController(OrderFacade orderFacade)
{
    public void CreateOrder()
    {
        // Beispielhafte Bestelldaten
        string productId = "CocaCola";
        int quantity = 12;
        string accountId = "Danilo Schiefer";
        decimal amount = 22.49M;
        string address = "Kieler Str. 68, 26382 Wilhelmshaven";
        
        var (success, message) = orderFacade.PlaceOrder(productId, quantity, accountId, amount, address);
        
        if (success)
            Console.WriteLine($"Bestellung erfolgreich! Sendungsnummer: {message}");
        else
            Console.WriteLine($"Bestellung fehlgeschlagen: {message}");
    }
}