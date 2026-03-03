namespace BehavioralPatterns.Strategy.Strategies;

// Concrete Strategy
public class DroneShippingStrategy : IShippingStrategy
{
    public string Name => "Drone";
    public decimal Calculate(decimal pWeightKg, decimal pDistanceKm)
    {
        // Nur für kleine, nahe Pakete sinnvoll
        if (pWeightKg > 5)
            throw new InvalidOperationException("Gewichtslimit überschritten (<= 5kg)");

        if (pDistanceKm > 20)
            throw new InvalidOperationException("Reichweite überschritten (<= 20kg)");

        decimal basePrice = 15.0M;
        return basePrice + (1.0M * pWeightKg) + (0.2M * pDistanceKm);
    }
}