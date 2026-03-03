namespace BehavioralPatterns.Strategy.Strategies;

// Concrete Strategy
public class AirShippingStrategy : IShippingStrategy
{
    public string Name => "Air";
    
    public decimal Calculate(decimal pWeightKg, decimal pDistanceKm)
    {
        // Schnellere Lieferung, teurer
        decimal basePrice = 10.0M;
        return basePrice + (2.5M * pWeightKg) + (0.1M * pDistanceKm);
    }
}