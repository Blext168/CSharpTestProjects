using DatabaseSQLTester.Model;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Text;

namespace DatabaseSQLTester;

internal abstract class Program
{
    private const string NULL_VALUE = "NULL";
    
    private static void Main()
    {
        // TestDataGenerator.InitializeTestData();

        using HandelsDbContext context = new();

        while (true)
        {
            Console.Clear();
            ShowTableRecords(context);

            Console.WriteLine("\nGeben Sie Ihr SQL-Statement ein (oder 'exit' zum Beenden):");
            string sqlStatement = Console.ReadLine() ?? string.Empty;

            if (sqlStatement.Equals("exit", StringComparison.CurrentCultureIgnoreCase))
                break;

            if (string.IsNullOrWhiteSpace(sqlStatement)) 
                continue;

            try
            {
                using (DbCommand command = context.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = sqlStatement;
                    context.Database.OpenConnection();
                            
                    using (DbDataReader reader = command.ExecuteReader())
                        ShowResults(reader);
                }
                        
                Console.WriteLine("\nDrücken Sie eine Taste, um die aktualisierten Tabellen zu sehen...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nFehler: {ex.Message}");
                Console.WriteLine("\nDrücken Sie eine Taste zum Fortfahren...");
                Console.ReadKey();
            }
        }
    }

    private static void ShowTableRecords(HandelsDbContext context)
    {
        Console.WriteLine("=== Artikel ===");
        List<Artikel> artikel = context.Artikel.ToList();
        if (artikel.Count != 0)
        {
            Console.WriteLine(FormatHeader("ArtikelId", "Bezeichnung", "Preis", "Kategorie", "Barcode"));
            foreach (Artikel a in artikel)
                Console.WriteLine(FormatRow(
                    $"{a.ArtikelId}", 
                    a.Bezeichnung ?? NULL_VALUE, 
                    $"{a.Preis:C}", 
                    a.Kategorie ?? NULL_VALUE, 
                    a.Barcode ?? NULL_VALUE));
        }

        Console.WriteLine("\n=== Lager ===");
        List<Lager> lager = context.Lager.ToList();
        if (lager.Count != 0)
        {
            Console.WriteLine(FormatHeader("LagerId", "ArtikelId", "Bestand", "Lagerort", "LetzteInventur"));
            foreach (Lager l in lager)
                Console.WriteLine(FormatRow(
                                    $"{l.LagerId}", 
                                    $"{l.ArtikelId}", 
                                    $"{l.Bestand}", 
                                    l.Lagerort ?? NULL_VALUE, 
                                    l.LetzteInventur.ToString("dd.MM.yyyy")));
        }

        Console.WriteLine("\n=== Verkäufe ===");
        List<Verkauf> verkaufe = context.Verkaufe.ToList();
        if (verkaufe.Count == 0) return;

        Console.WriteLine(FormatHeader("VerkaufId", "ArtikelId", "Menge", "Gesamtpreis", "Verkaufsdatum"));
        foreach (Verkauf v in verkaufe)
            Console.WriteLine(FormatRow($"{v.VerkaufId}", $"{v.ArtikelId}", $"{v.Menge}", 
                $"{v.Gesamtpreis:C}", v.Verkaufsdatum.ToString("dd.MM.yyyy HH:mm")));
    }

    private static void ShowResults(DbDataReader reader)
    {
        string[] columns = new string[reader.FieldCount];
        for (int i = 0; i < reader.FieldCount; i++)
            columns[i] = reader.GetName(i);

        Console.WriteLine("\n=== Ergebnis ===");
        Console.WriteLine(FormatHeader(columns));

        while (reader.Read())
        {
            string[] values = new string[reader.FieldCount];
            for (int i = 0; i < reader.FieldCount; i++)
                values[i] = (reader.IsDBNull(i) ? NULL_VALUE : reader.GetValue(i).ToString()) ?? throw new InvalidOperationException();
                
            Console.WriteLine(FormatRow(values));
        }
    }

    private static string FormatHeader(params string[] columns)
    {
        const int columnWidth = 20;
        StringBuilder header = new();
        foreach (string column in columns)
            header.Append(column.PadRight(columnWidth));
            
        return header.ToString();
    }

    private static string FormatRow(params string[] values)
    {
        const int columnWidth = 20;
        StringBuilder row = new();
        foreach (string value in values)
        {
            string displayValue = value.Length > columnWidth - 3 
                                      ? value[..(columnWidth - 3)] + "..." 
                                      : value;
            row.Append(displayValue.PadRight(columnWidth));
        }
        
        return row.ToString();
    }
}