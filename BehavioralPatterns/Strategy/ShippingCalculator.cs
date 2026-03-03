namespace BehavioralPatterns.Strategy;

// Context / Client
public class ShippingCalculator(IShippingStrategy pStrategy)
{
    private IShippingStrategy _strategy = pStrategy ?? throw new ArgumentNullException(nameof(pStrategy));
    
    public void SetStrategy(IShippingStrategy pStrategy)
    {
        _strategy = pStrategy ?? throw new ArgumentNullException(nameof(pStrategy));
    }
    
    public decimal CalculateCost(decimal pWeightKg, decimal pDistanceKm)
    {
        return _strategy.Calculate(pWeightKg, pDistanceKm);
    }
}