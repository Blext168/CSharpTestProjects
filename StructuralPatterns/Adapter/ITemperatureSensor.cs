namespace StructuralPatterns.Adapter;

// Target (Erwartete Schnittstelle im System)
public interface ITemperatureSensor
{
    /// <summary>
    /// Liefert Temperatur in Grad Celsius.
    /// </summary>
    double GetTemperatureCelsius();
}