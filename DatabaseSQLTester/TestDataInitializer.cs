using DatabaseSQLTester.Model;

namespace DatabaseSQLTester;

public static class TestDataGenerator
{
    public static void InitializeTestData()
    {
        using HandelsDbContext context = new();

        context.Database.EnsureCreated();

        // Artikel hinzufügen
        List<Artikel> artikel =
        [
            new() {Bezeichnung = "Bio Apfel", Preis = 0.99m, Kategorie = "Obst", Barcode = "4000123456781"},
            new() {Bezeichnung = "Vollmilch", Preis = 1.49m, Kategorie = "Milchprodukte", Barcode = "4000123456782"},
            new() {Bezeichnung = "Roggenbrot", Preis = 2.99m, Kategorie = "Backwaren", Barcode = "4000123456783"}
        ];

        context.Artikel.AddRange(artikel);

        // Lagerbestände hinzufügen
        List<Lager> lager =
        [
            new() {ArtikelId = 1, Bestand = 150, Lagerort = "Kühlraum 1", LetzteInventur = DateTime.Now},
            new() {ArtikelId = 2, Bestand = 200, Lagerort = "Kühlraum 2", LetzteInventur = DateTime.Now},
            new() {ArtikelId = 3, Bestand = 50, Lagerort = "Regal A1", LetzteInventur = DateTime.Now}
        ];

        context.Lager.AddRange(lager);

        // Beispiel-Verkäufe hinzufügen
        List<Verkauf> verkaufe =
        [
            new() {ArtikelId = 1, Menge = 5, Gesamtpreis = 4.95m, Verkaufsdatum = DateTime.Now.AddDays(-1)},
            new() {ArtikelId = 2, Menge = 2, Gesamtpreis = 2.98m, Verkaufsdatum = DateTime.Now.AddDays(-1)},
            new() {ArtikelId = 3, Menge = 1, Gesamtpreis = 2.99m, Verkaufsdatum = DateTime.Now}
        ];

        context.Verkaufe.AddRange(verkaufe);

        context.SaveChanges();
    }
}