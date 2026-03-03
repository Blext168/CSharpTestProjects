namespace StructuralPatterns.Facade.Subsystems;

// Subsystem 2: Zahlung / Payment Gateway
public class PaymentService
{
    public bool Charge(string pAccountId, decimal pAmount)
    {
        Console.WriteLine($"[Payment]: Belastung von Konto {pAccountId}:  {pAmount:C}");
        // Simuliere Erfolg bei Beträgen < 1000 €
        return pAmount < 1000M;
    }
}