namespace StructuralPatterns.Adapter;

// Adaptee (existierende/legacy Klasse mit inkompatibler API)
// Example: Ein alter Sensor liefert Fahrenheit-Werte über eine andere Methode.
public class LegacyFahrenheitSensor
{
    private readonly Random _rnd = new();
    
    // Legacy-Methode, die Fahrenheit zurückgibt
    public double ReadFahrenheit()
    {
        // Simuliere Sensorwert zwischen 32°F und 212°F
        return 32 + _rnd.NextDouble() * (212 - 32);
    }

    // Zusätzliche Legacy-Funktionalität (just an example)
    public string GetDeviceId() => "LEGACY-FAH-001";
}