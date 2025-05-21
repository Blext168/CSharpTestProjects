namespace Einlesen_von_Flat_Files;

public class CityTemperature
{
    // Both properties are necessary for code
    // A setter is not necessary 'cause we need only to initialise the values
    public required string City { get; init; }
    public required int Temperature { get; init; }
}