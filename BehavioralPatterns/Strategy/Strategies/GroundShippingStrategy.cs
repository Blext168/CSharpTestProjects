namespace BehavioralPatterns.Strategy.Strategies;

// Concrete Strategy
public class GroundShippingStrategy : IShippingStrategy
{
    public string Name => "Ground";
    
    public decimal Calculate(decimal pWeightKg, decimal pDistanceKm)
    {
        // Beispiel: Basispreis + kg-Preis + km-Preis
        decimal basePrice = 2.0M;
        return basePrice + (0.75M * pWeightKg) + (0.05M * pDistanceKm);
    }
}