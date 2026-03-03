namespace BehavioralPatterns.Strategy;

// Strategy Interface
public interface IShippingStrategy
{
    /// <summary>
    /// Identifier (Name) for Strategy, useful for selection during runtime
    /// </summary>
    string Name { get; }
    
    /// <summary>
    /// Calculate the shipping costs based on weight and distance
    /// </summary>
    /// <param name="pWeightKg"></param>
    /// <param name="pDistanceKm"></param>
    /// <returns></returns>
    decimal Calculate(decimal pWeightKg, decimal pDistanceKm);
}