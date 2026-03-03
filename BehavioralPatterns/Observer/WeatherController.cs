namespace BehavioralPatterns.Observer;

// Consumer / Controller (optional)
public class WeatherController(IWeatherStation pStation)
{
    // Führt mehrere Messungen aus
    public void StartMeasurements(int count, int delayMs)
    {
        for (int i = 0; i < count; i++)
        {
            pStation.Measure();
            Thread.Sleep(delayMs);
        }
    }
}