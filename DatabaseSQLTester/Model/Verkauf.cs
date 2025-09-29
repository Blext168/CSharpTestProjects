namespace DatabaseSQLTester.Model;

public class Verkauf
{
    public int VerkaufId { get; init; }
    public int ArtikelId { get; init; }
    public int Menge { get; init; }
    public decimal Gesamtpreis { get; init; }
    public DateTime Verkaufsdatum { get; init; }
}