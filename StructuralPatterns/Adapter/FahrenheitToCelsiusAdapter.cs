namespace StructuralPatterns.Adapter;

public class FahrenheitToCelsiusAdapter(LegacyFahrenheitSensor pAdaptee) : ITemperatureSensor
{
    private readonly LegacyFahrenheitSensor _adaptee = pAdaptee ?? throw new ArgumentNullException(nameof(pAdaptee));

    public double GetTemperatureCelsius()
    {
        double f = _adaptee.ReadFahrenheit();
        // Convert: Fahrenheit -> Celsius
        return (f - 32.0) * 5.0 / 9.0;
    }

    // Optional: expose additional information via Adapter
    public string GetLegacyId() => _adaptee.GetDeviceId();
}