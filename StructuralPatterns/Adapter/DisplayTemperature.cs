using DevExpress.Xpo.DB.Helpers;

namespace StructuralPatterns.Adapter;

// Client, der die Target-Schnittstelle verwendet
public class DisplayTemperature(ITemperatureSensor pSensor)
{
    public void Show()
    {
        double c = pSensor.GetTemperatureCelsius();
        Console.WriteLine($"[Displayer]: Aktuelle Temperatur: {c:F2} °C");
    }
}