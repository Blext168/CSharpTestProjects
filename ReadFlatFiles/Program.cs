using System.Linq;

namespace Einlesen_von_Flat_Files;

public abstract class Program
{
    private const string FILE_PATH = @"C:\Users\Schiefer\Desktop\C# Projekte\CSharpTestProjects\ReadFlatFiles\temperature_data.txt";
        //@"Hier Dateipfad angeben";

    private static void Main() // Optional parameter: "string[] args"
    {
        List<CityTemperature> cityTemperatures = [];
        List<string> citiesOnlyOnce = [];

        try
        {
            // Read out file
            using StreamReader reader = new(FILE_PATH);
            while (reader.ReadLine() is { } line)
            {
                // Try to convert
                bool isConvertible = int.TryParse(line[20..], out int temperature);

                // Continue if string can't be converted
                if (!isConvertible)
                    continue;

                // Get city from string
                string currentCity = line.Split(" ").First();

                // Create and fill object with data 
                cityTemperatures.Add(new CityTemperature
                {
                    City = currentCity,
                    Temperature = temperature
                });

                // Filter city and get each city once
                if (citiesOnlyOnce.All(pA => pA != currentCity))
                    citiesOnlyOnce.Add(currentCity);
            }

            // Create one header row
            Console.WriteLine($"{"Stadt",-20}min. temp.[°C]\tmax. temp.[°C]\tDurchschnitt [°C]");

            // Output for each city once
            foreach (string city in citiesOnlyOnce.Order())
            {
                // Get max value
                //double max = cityTemperatures.Where(w => w.City == city).Max(m => m.Temperature);
                double max = double.MinValue;
                foreach (var temperature in from temperature in cityTemperatures.Where(w => w.City == city).Select(s => s.Temperature)
                                            where temperature > max
                                            select temperature)
                {
                    max = temperature;
                }

                // Get min value
                //double min = cityTemperatures.Where(w => w.City == city).Min(m => m.Temperature);
                double min = double.MaxValue;
                foreach (var temperature in from temperature in cityTemperatures.Where(w => w.City == city).Select(s => s.Temperature)
                                            where temperature < min
                                            select temperature)
                {
                    min = temperature;
                }

                // Get average value
                //double average = cityTemperatures.Where(w => w.City == city).Average(a => a.Temperature);
                double average = 0;
                int counter = 0;
                foreach (var temperature in from temperature in cityTemperatures.Where(w => w.City == city).Select(s => s.Temperature)
                                            select temperature)
                {
                    counter++;
                    average += temperature;
                }

                average /= counter;

                Console.WriteLine($"{city,-20}Min = {min}\t\tMax = {max}\tDurchschnitt = {Math.Round(average, 2)}"); // {city,-20} is same as {city.PadRight(20)}
            }
        }
        // catch if you got someone exception i.e. the file can't be opened
        catch (Exception exception)
        {
            //To change teh colors of the console
            //{
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            //}
            Console.WriteLine("Stellen sie sicher, das die Datei geöffnet werden kann!");

            //Shows the exception
            Console.WriteLine($"{exception.Message}\n\n{exception.InnerException?.Message}");
        }
    }
}