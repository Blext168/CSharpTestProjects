namespace DatabaseSQLTester.Model;

public class Lager
{
    public int LagerId { get; init; }
    public int ArtikelId { get; init; }
    public int Bestand { get; init; }
    public string? Lagerort { get; init; }
    public DateTime LetzteInventur { get; init; }
}