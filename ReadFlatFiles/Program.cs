namespace Einlesen_von_Flat_Files;

public abstract class Program
{
    private const string FILE_PATH =
        @"Hier Dateipfad angeben";

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

            // Output for each city once
            foreach (string city in citiesOnlyOnce)
            {
                double max = cityTemperatures.Where(w => w.City == city).Max(m => m.Temperature);
                double min = cityTemperatures.Where(w => w.City == city).Min(m => m.Temperature);

                Console.WriteLine($"{city,-20}Min = {min}\tMax = {max}\tDurchschnitt = {(max + min) / 2}"); // {city,-20} is same as {city.PadRight(20)}
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