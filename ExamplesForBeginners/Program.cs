using System;
namespace ExamplesForBeginners
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Willkommen zur C# Grundlagen-Demo!");

            VariablesAndDataTypes();
            UserInputsAndOutputs();
            TermsAndConditions();
            Loops();
            CustomMethodExample();
            StringOperations();
            WorkingWithLists();
            FileReadBasic();
            SubstringExample();
            DictionaryAndList();
            MinMaxAverage();
        }

        // Was passiert bis hierher?
        // 1. Wir importieren den Namensraum "System", der grundlegende Funktionen bereitstellt.
        // 2. Wir definieren eine Klasse namens "Program". In C# ist alles in Klassen organisiert.
        // 3. Innerhalb der Klasse haben wir zunächst die Methode "Main", die der Einstiegspunkt für die Anwendung ist.
        // 4. In der "Main"-Methode verwenden wir "Console.WriteLine", um Text auf der Konsole auszugeben.
        // 5. Wenn das Programm ausgeführt wird, zeigt es "Willkommen zur C# Grundlagen-Demo!" in der Konsole an.
        // Außerdem werden die Methoden, die in dieser Klasse implementiert sind, aufgerufen.

        // nützliche Anmerkungen:
        // - Die "Main"-Methode ist als "private" deklariert, was bedeutet,
        //   dass sie nur innerhalb der Klasse "Program" aufgerufen werden kann.
        // - Das Program endet, wenn die "Main"-Methode abgeschlossen ist, und die Konsole bleibt geöffnet,
        //   bis der Benutzer eine Taste drückt (dies hängt von der Umgebung ab, in der das Programm ausgeführt wird).
        // - Die "static" Modifizierer bedeuten, dass die Methode ohne Instanziierung der Klasse aufgerufen werden kann.
        //   Es muss also kein Objekt der Klasse erzeugt werden.
        // - C# ist eine typsichere Sprache, was bedeutet, dass Variablen und Objekte einen bestimmten Typ haben müssen.
        // - Die geschweiften Klammern {} definieren den Umfang (Scope) von Klassen und Methoden.
        // - Jede Anweisung endet mit einem Semikolon (;), was das Ende der Anweisung markiert.

        // Diese Methode zeigt, wie man verschiedene Variablen und Datentypen in C# verwendet
        static void VariablesAndDataTypes()
        {
            // Ganze Zahl (integer)
            int alter = 17;

            // Fließkommazahl (double)
            double temperatur = 36.6;

            // Text (string)
            string name = "Lina";

            // Wahrheitswert (bool) -> kann entweder 'false' oder 'true' sein
            bool istVolljaehrig = false;

            // Ein einzelnes Zeichen (char)
            char ersterBuchstabe = 'L';

            // Array von Ganzzahlen (integer)
            int[] zahlen = { 1, 2, 3, 4, 5 }; 
        }

        // Diese Methode fragt den Benutzer nach seinem Namen und gibt ihn mit einer Begrüßung aus
        public static void UserInputsAndOutputs()
        {
            Console.Write("Bitte gib deinen Namen ein: ");
            string? name = Console.ReadLine();
            Console.WriteLine("Hallo, " + name + "! Schön, dich kennenzulernen.");
        }

        // Was passiert hier?
        // 1. Wir definieren eine Methode namens "UserInputsAndOutputs".
        // 2. Im Inneren der Methode geben wir eine Eingabeaufforderung auf der Konsole aus.
        // 3. Wir verwenden "Console.Write" anstelle von "Console.WriteLine", um die Eingabeaufforderung in derselben Zeile anzuzeigen.
        // 4. Mit "Console.ReadLine" lesen wir die Benutzereingabe von der Konsole ein.
        // 5. Wir speichern die Eingabe in der Variablen "name". Wir nutzen hier einen nullable-Datentypen.
        // D.h. falls vom Benutzer nichts eingegeben wird, ist der Wert "null".
        // Sollte der Datentyp Daten dieses Formats ("null"-Werte) nicht akzeptieren,
        // würde das zu einem Programmabsturz führen, da die Eingabe nicht korrekt verarbeitet werden könnte.
        // 6. Anschließend verwenden wir "Console.WriteLine", um eine personalisierte Begrüßung mit dem eingegebenen Namen auszugeben.
        // 7. Diese Methode kann aufgerufen werden, um Benutzereingaben zu verarbeiten und eine Antwort auszugeben.

        public static void TermsAndConditions()
        {
            Console.Write("Gib eine Zahl ein:");
            string eingabe = Console.ReadLine();
            int zahl = Convert.ToInt32(eingabe);

            if (zahl > 0)
            {
                Console.WriteLine("Die Zahl " + zahl + " ist positiv.");
            }
            else if (zahl < 0)
            {
                Console.WriteLine("Die Zahl " + zahl + " ist negativ.");
            }
            else
            {
                Console.WriteLine("Die Zahl " + zahl + " ist Null.");
            }
        }

        // Was passiert hier?
        // 1. Wir definieren eine Methode namens "TermsAndConditions".
        // 2. Im Inneren der Methode geben wir eine Eingabeaufforderung auf der Konsole aus.
        // 3. Wir verwenden "Console.Write" anstelle von "Console.WriteLine", um die Eingabeaufforderung in derselben Zeile anzuzeigen.
        // 4. Mit "Console.ReadLine" lesen wir die Benutzereingabe von der Konsole ein.
        // 5. Wir speichern die Eingabe in der Variablen "eingabe". 
        // 6. Um aus der 

        public static void Loops()
        {
            // For-Schleife -> Wiederholt etwas eine bestimmte Anzahl von Malen
            Console.WriteLine("For-Schleife:");
            for (var i = 0; i < 5; i++) Console.WriteLine($"Durchlauf {i + 1}");

            // var i = 0; -> Initialisierung der Schleifenvariable i mit 0
            // i < 5; -> Bedingung, die überprüft, ob i kleiner als 5 ist
            // i++ -> Inkrementierung der Schleifenvariable i um 1 nach jedem Durchlauf

            // While-Schleife -> Wiederholt etwas, solange eine Bedingung erfüllt ist
            Console.WriteLine("\nWhile-Schleife:");
            var counter = 0;
            while (counter < 3)
            {
                Console.WriteLine($"Zähler: {counter}");
                counter++;
            }

            // var counter = 0; -> Initialisierung der Zählervariable counter mit 0
            // counter < 3; -> Bedingung, die überprüft, ob counter kleiner als 3 ist (gibt 'true' oder 'false' zurück;
            // nur, wenn 'true' zurückgegeben wird, wird die Schleife ein (weiteres) Mal durchlaufen)
            // counter++; -> Inkrementieren der Zählervariable counter um 1 nach jedem Durchlauf

            // Do-While-Schleife -> Führt den Code mindestens einmal aus und prüft dann die Bedingung
            Console.WriteLine("\nDo-While-Schleife:");
            var doCounter = 0;
            do
            {
                Console.WriteLine($"Do-Zähler: {doCounter}");
                doCounter++;
            } while (doCounter < 2);
            // var doCounter = 0; -> Initialisierung der Zählervariable doCounter mit 0
            // doCounter < 2; -> Bedingung, die überprüft, ob doCounter kleiner als 2 ist
            // doCounter++; -> Inkrementierung der Zählervariable doCounter um 1 nach jedem Durchlauf
            // Die Do-While-Schleife garantiert, dass der Code mindestens einmal ausgeführt wird, bevor die Bedingung überprüft wird.

            // Foreach-Schleife -> Wird verwendet, um über eine Sammlung von Elementen zu iterieren
            Console.WriteLine("\nForeach-Schleife:");
            string[] namen = { "Anna", "Ben", "Clara" };
            foreach (var name in namen) Console.WriteLine($"Name: {name}");

            // string[] namen = { "Anna", "Ben", "Clara" }; -> Initialisierung eines Arrays von Strings mit den Namen
            // foreach (var name in namen) -> Iteration über jedes Element im Array "namen"
        }

        // Diese Methode zeigt, wie man eigene Methoden definiert und aufruft
        public static void CustomMethodExample()
        {
            Console.Write("Gib die erste Zahl ein: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Gib die zweite Zahl ein: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int summe = Addiere(a, b);
            Console.WriteLine($"Die Summe von {a} und {b} ist: {summe}");

            Console.WriteLine();
        }
        // Eine einfache Methode zur Addition von zwei Zahlen
        public static int Addiere(int x, int y)
        {
            return x + y;
        }

        // Was passiert hier?
        // 1. Wir definieren eine Methode namens "CustomMethodExample".
        // 2. Im Inneren der Methode geben wir eine Eingabeaufforderung auf der Konsole aus, um den Benutzer nach zwei Zahlen zu fragen.
        // 3. Wir verwenden "Console.ReadLine", um die Benutzereingaben zu lesen und in den Variablen "a" und "b" zu speichern.
        // 4. Wir rufen die Methode "Addiere" auf, um die beiden Zahlen zu addieren und das Ergebnis in der Variablen "summe" zu speichern.
        // 5. Anschließend geben wir das Ergebnis auf der Konsole aus.

        // Diese Methode zeigt grundlegende Operationen mit Strings (Texten)
        public static void StringOperations()
        {
            Console.Write("Gib einen beliebigen Text ein: ");
            string eingabe = Console.ReadLine();

            // Text in Großbuchstaben umwandeln
            string gross = eingabe.ToUpper();
            Console.WriteLine("In Großbuchstaben: " + gross);
            // Text in Kleinbuchstaben umwandeln
            string klein = eingabe.ToLower();
            Console.WriteLine("In Kleinbuchstaben: " + klein);
            // Textlänge ermitteln
            int laenge = eingabe.Length;
            Console.WriteLine("Länge des Textes: " + laenge);
            // Zeichen ersetzen
            string ersetzt = eingabe.Replace("a", "@");
            Console.WriteLine("Text mit 'a' ersetzt durch '@': " + ersetzt);
            // Text aufteilen
            string[] woerter = eingabe.Split(' ');
            Console.WriteLine("Erstes Wort (falls vorhanden) " + woerter[0]);
        }
        // Was passiert hier?
        // 1. Wir definieren eine Methode namens "StringOperations".
        // 2. Im Inneren der Methode geben wir eine Eingabeaufforderung auf der Konsole aus, um den Benutzer nach einem Text zu fragen.
        // 3. Wir verwenden "Console.ReadLine", um die Benutzereingabe zu lesen und in der Variablen "eingabe" zu speichern.
        // 4. Wir wandeln den Text in Großbuchstaben um und speichern das Ergebnis in der Variablen "gross".
        // 5. Anschließend geben wir den Text in Großbuchstaben auf der Konsole aus.
        // 6. Wir wandeln den Text in Kleinbuchstaben um und speichern das Ergebnis in der Variablen "klein".
        // 7. Wir geben den Text in Kleinbuchstaben auf der Konsole aus.
        // 8. Wir ermitteln die Länge des Textes und speichern sie in der Variablen "laenge".
        // 9. Wir geben die Länge des Textes auf der Konsole aus.
        // 10. Wir ersetzen alle Vorkommen des Buchstabens 'a' durch '@' und speichern das Ergebnis in der Variablen "ersetzt".
        // 11. Wir geben den modifizierten Text auf der Konsole aus.
        // 12. Wir teilen den Text in Wörter auf, indem wir ihn an Leerzeichen trennen,
        //     und speichern die Wörter in einem Array namens "woerter".
        // 13. Wir geben das erste Wort des Textes (falls vorhanden) auf der Konsole aus.

        // Diese Methode demonstriert grundlegende Operationen mit Listen in C#
        public static void WorkingWithLists()
        {
            List<int> zahlen = new List<int>();

            zahlen.Add(8);
            zahlen.Add(0);
            zahlen.Add(11);
            zahlen.Add(77);

            Console.WriteLine("Zahlen in der Liste:");
            foreach (int zahl in zahlen)
            {
                Console.WriteLine(zahl);
            }

            #region Zugriff auf ein bestimmtes Element
            int ersteZahl = zahlen[0]; // Hier greifen wir auf das erste Element der Liste zu
            Console.WriteLine("Die erste Zahl der Liste ist: " + ersteZahl);
            #endregion

            #region Einfügen an einer bestimmten Stelle
            zahlen.Insert(2, 42); // Fügt die Zahl 42 an der dritten Position (Index 2) ein
            Console.WriteLine("\nNach dem Einfügen der 42 an der dritten Position:");
            foreach (int zahl in zahlen)
            {
                Console.WriteLine(zahl);
            }
            #endregion

            #region Entfernen eines bestimmten Elements
            zahlen.Remove(77); // Entfernt die Zahl 77 aus der Liste
            Console.WriteLine("\nNach dem Entfernen der 77:");
            foreach (int zahl in zahlen)
            {
                Console.WriteLine(zahl);
            }
            #endregion

            #region Entfernen des ersten Elements
            zahlen.RemoveAt(0); // Entfernt das erste Element der Liste
            Console.WriteLine("\nNach dem Entfernen des ersten Elements:");
            foreach (int zahl in zahlen)
            {
                Console.WriteLine(zahl);
            }
            #endregion

            #region Überprüfen, ob ein Wert in der Liste enthalten ist
            if (zahlen.Contains(11))
            {
                Console.WriteLine("\nDie Zahl 11 ist in der Liste enthalten.");
            }
            else
            {
                Console.WriteLine("\nDie Zahl 11 ist nicht in der Liste enthalten.");
            }
            #endregion

            #region Sortieren der Liste (mit Hilfsfunktion)
            zahlen.Sort();
            Console.WriteLine("\nNach dem Sortieren:");
            foreach (int zahl in zahlen)
            {
                Console.WriteLine(zahl);
            }
            #endregion

            #region Umkehren der Liste (mit Hilfsfunktion)
            zahlen.Reverse();
            Console.WriteLine("\nNach dem Umkehren:");
            foreach (int zahl in zahlen)
            {
                Console.WriteLine(zahl);
            }
            #endregion

            #region Finden des Index eines Elements
            int index = zahlen.IndexOf(11);
            if (index != -1)
            {
                Console.WriteLine("\nDie Zahl 11 befindet sich an Index: " + index);
            }
            else
            {
                Console.WriteLine("\nDie Zahl 11 ist nicht in der Liste enthalten.");
            }
            #endregion

            #region Hinzufügen mehrerer Elemente
            zahlen.Reverse();
            zahlen.AddRange(new List<int> { 3, 5, 9 });
            Console.WriteLine("\nNach dem Hinzufügen von 3, 5 und 9:");
            foreach (int zahl in zahlen)
            {
                Console.WriteLine(zahl);
            }
            #endregion

            #region Entfernen aller Elemente
            zahlen.Clear();
            Console.WriteLine("\nNach dem Entfernen aller Elemente:");
            foreach (int zahl in zahlen)
            {
                Console.WriteLine(zahl);
            }
            Console.WriteLine("\nDie Liste ist jetzt leer.");
            #endregion

            #region Anzahl der Elemente ermitteln
            int anzahl = zahlen.Count;
            Console.WriteLine("Anzahl der Zahlen: " + anzahl);
            #endregion

            // Was passiert hier?
            // 1. Wir definieren eine Methode namens "WorkingWithLists".
            // 2. Wir erstellen eine Liste von Ganzzahlen (int) namens "zahlen".
            // 3. Wir fügen der Liste mehrere Zahlen hinzu, indem wir die "Add"-Methode verwenden.
            // 4. Wir geben die Zahlen in der Liste aus, indem wir eine "foreach"-Schleife verwenden.
            // 5. Wir entfernen die Zahl 0 aus der Liste mit der "Remove"-Methode und geben die Liste erneut aus.
            // 6. Wir überprüfen, ob die Zahl 11 in der Liste enthalten ist, indem wir die "Contains"-Methode verwenden und eine
            //    entsprechende Nachricht ausgeben.
            // 7. Wir sortieren die Liste in aufsteigender Reihenfolge mit der "Sort"-Methode und geben die sortierte Liste aus.
            // 8. Wir kehren die Reihenfolge der Elemente in der Liste mit der "Reverse"-Methode um und geben die umgekehrte Liste aus.
            // 9. Wir finden den Index der Zahl 11 in der Liste mit der "IndexOf"-Methode und geben den Index aus,
            //    falls die Zahl gefunden wurde.
            // 10. Wir fügen mehrere neue Zahlen (3, 5 und 9) zur Liste hinzu, indem wir die "AddRange"-Methode verwenden und geben
            //     die aktualisierte Liste aus.
            // 11. Wir entfernen alle Elemente aus der Liste mit der "Clear"-Methode und geben die leere Liste aus.
            // 12. Wir ermitteln die Anzahl der Elemente in der Liste mit der "Count"-Eigenschaft und geben diese aus.
        }

        // Diese Methode liest eine Textdatei zeilenweise ein und gibt den Inhalt auf der Konsole aus
        public static void FileReadBasic()
        {
            string dateipfad = "beispiel.txt";

            try
            {
                using (StreamReader reader = new StreamReader(dateipfad))
                {
                    string zeile;
                    while ((zeile = reader.ReadLine()) != null)
                    {
                        Console.WriteLine("Gelesene Zeile: " + zeile);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehler beim Einlesen: " + ex.Message);
            }

            // Erklärung:
            // 1. StreamReader liest eine Datei zeilenweise.
            // 2. ReadLine() liest die nächste Zeile als Text.
            // 3. using sorgt dafür, dass die Datei nach dem Lesen wieder geschlossen wird.
            // 4. try-catch fängt Fehler ab, z. B. falls die Datei fehlt.
        }

        // Diese Methode demonstriert die Verwendung von Substring, um Teile eines Textes zu extrahieren
        public static void SubstringExample()
        {
            string text = "Marie               Zürich";

            string name = text.Substring(0, 20).Trim(); // Nur die ersten 20 Zeichen
            string geburtsort = text.Substring(20).Trim(); // Ab Position 20 bis zum Ende

            Console.WriteLine("Person: " + name);
            Console.WriteLine("Geburtsort: " + geburtsort);

            // Erklärung:
            // Substring(0, 20): Startet bei Zeichen 0 und liest 20 Zeichen. Der erste Buchstabe steht immer an Position 0.
            // Jede Zeichenkette (string) ist praktisch ein Array aus einzelnen Buchstaben (char).
            // Das bedeutet, dass jeder Buchstabe einen Index hat. Bei "Marie" hat 'M' den Index 0, 'a' den Index 1, 'r' den Index 2 usw.
            // Trim(): Entfernt Leerzeichen am Anfang und Ende der Zeichenkette (string).
        }

        // Diese Methode demonstriert die Verwendung von Dictionary und List in C#
        public static void DictionaryAndList()
        {
            Dictionary<string, List<double>> noten = new Dictionary<string, List<double>>();

            noten["Lena"] = new List<double> { 4, 1, 2 };
            noten["Max"] = new List<double> { 1, 1, 3 };

            foreach (var schueler in noten)
            {
                Console.WriteLine($"Stadt: {schueler.Key}, Temperaturen: {string.Join(", ", schueler.Value)}");
            }

            // Erklärung:
            // Dictionary speichert für jeden Schlüssel (Schüler) eine Liste von Werten (Noten).
            // Man kann sich das Dictionary in diesem Beispiel wie einen Schrank mit Schubladen vorstellen:
            // Jede Schublade hat einen Namen (Schlüssel) und enthält z.B. Socken. In der ersten Schublade liegen grüne Socken,
            // weil die Schublade "Grün" heißt, in der zweiten Schublade liegen blaue Socken, weil die Schublade "Blau" heißt usw.
            // Alle Teile in den Schubladen sind von Typ "Socken", aber nach Farben sortiert.
            // string.Join(", ", schueler.Value) zeigt die Liste als Text. Zurück zu unseren Schubladen:
            // Wir nehmen unsere Socken einer Schublade und fügen alle Socken aneinander an
            // (zur Veranschaulichung sollen die Socken Namen haben)
            // und zwischen jedem Namen setzen wir ein ",". Am Ende haben wir einen Text mit allen Socken.
        }

        // Diese Methode berechnet das Minimum, Maximum und den Durchschnitt von Gewichten in einer Liste
        public static void MinMaxAverage()
        {
            List<double> gewichte = new List<double> { 31.4, 44.6, 37.1 };

            double kleinstesGewicht = gewichte.Min();
            double groesstesGewicht = gewichte.Max();
            double durchschnittsGewicht = gewichte.Average();

            Console.WriteLine($"Min: {kleinstesGewicht}, Max: {groesstesGewicht}, Durchschnitt: {durchschnittsGewicht:F1}");

            // Erklärung:
            // Min(), Max(), Average() sind Methoden von LINQ (automatisch verfügbar bei List<double>), sollen aber für die Lösung der
            // Aufgaben nicht verwendet werden
            // {durchschnittsGewicht:F1} -> auf der Konsole wird der Wert (geht nur, wenn es sich um eine Gleitkommazahl handelt) mit
            // einer Nachkommastelle dargestellt
        }
    }
}
