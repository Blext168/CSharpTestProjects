namespace DatabaseSQLTester.Model;

public class Artikel
{
    public int ArtikelId { get; init; }
    public string? Bezeichnung { get; init; }
    public decimal Preis { get; init; }
    public string? Kategorie { get; init; }
    public string? Barcode { get; init; }
}