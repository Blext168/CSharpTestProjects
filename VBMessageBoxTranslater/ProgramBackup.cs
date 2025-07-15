using System.Text.RegularExpressions;

namespace VBMessageBoxTranslator;

class ProgramBackup
{
    static Dictionary<string, string> stringToVarMap = new();

    private static void MainBackup()
    {
        string variableFile = @"\\data09\DEV-VB-Projekte\Sourcen\storeLution\SourceCode\Team_Ordner\Code\VB\Hauptprogramm\Public.bas";
        string codeFile = @"\\data09\DEV-VB-Projekte\Sourcen\storeLution\SourceCode\Team_Ordner\Code\VB\Hauptprogramm\FrmAuslagaufPosBearbeiten.frm";
        string outputFile = @"C:\Users\Schiefer\Downloads\EditedVBFile.frm";

        if (!File.Exists(variableFile) || !File.Exists(codeFile))
        {
            Console.WriteLine("Dateien fehlen.");
            return;
        }

        // Variablen lesen
        foreach (var line in File.ReadAllLines(variableFile))
            ParseStringAssignment(line);

        // Code analysieren
        var codeLines = File.ReadAllLines(codeFile);
        var outputLines = ProcessCodeLines(codeLines);

        File.WriteAllLines(outputFile, outputLines);
        Console.WriteLine($"Verarbeitung abgeschlossen: {outputFile.Split('\\').Last()}");
    }

    static void ParseStringAssignment(string line)
    {
        var regex = new Regex(@"(?i)(\w+)\s*=\s*""([^""]+)""");
        var match = regex.Match(line);
        if (match.Success)
        {
            string varName = match.Groups[1].Value;
            string stringValue = match.Groups[2].Value;
            if (!stringToVarMap.ContainsKey(stringValue))
                stringToVarMap[stringValue] = varName;
        }
    }

    static List<string> ProcessCodeLines(string[] lines)
    {
        var output = new List<string>();
        int i = 0;

        while (i < lines.Length)
        {
            string originalLine = lines[i];
            string line = originalLine.TrimStart();

            // Kommentierte Zeile → unverändert
            if (line.StartsWith("'") || line.Contains("MsgBox") && line.IndexOf("MsgBox") > line.IndexOf("'"))
            {
                output.Add(originalLine);
                i++;
                continue;
            }

            // Mehrzeilige MsgBox erkennen
            if (line.StartsWith("MsgBox", StringComparison.OrdinalIgnoreCase))
            {
                var msgBoxLines = new List<string> { originalLine.TrimEnd() };
                while (msgBoxLines[^1].TrimEnd().EndsWith("_") && i + 1 < lines.Length)
                {
                    i++;
                    msgBoxLines.Add(lines[i].TrimEnd());
                }

                string combined = string.Join(" ", msgBoxLines).Replace("_", "").Trim();
                string processed = ProcessMsgBoxLine(combined);
                output.Add(processed);
                i++;
            }
            else
            {
                output.Add(originalLine);
                i++;
            }
        }

        return output;
    }

    static string ProcessMsgBoxLine(string line)
    {
        foreach (var kvp in stringToVarMap)
        {
            string literal = kvp.Key;
            string variable = kvp.Value;

            if (!line.Contains($"\"{literal.Split('{')[0]}")) continue;

            if (!literal.Contains("{"))
            {
                // Direkt ersetzen
                line = line.Replace($"\"{literal}\"", variable);
            }
            else
            {
                // Formatieren
                var paramRegex = new Regex(@"\{(\d+)\}");
                var matches = paramRegex.Matches(literal);
                int maxParam = -1;
                foreach (Match m in matches)
                {
                    int index = int.Parse(m.Groups[1].Value);
                    if (index > maxParam) maxParam = index;
                }

                // Finde konkatenierten Teil: "..." & a & b
                string staticStart = literal.Split('{')[0];
                var concatRegex = new Regex($"\"{Regex.Escape(staticStart)}\"((\\s*&\\s*\\w+)+)");
                var concatMatch = concatRegex.Match(line);

                if (concatMatch.Success)
                {
                    string concat = concatMatch.Groups[1].Value;
                    var args = new List<string>();
                    foreach (Match argMatch in Regex.Matches(concat, @"\b\w+\b"))
                        args.Add(argMatch.Value);

                    if (args.Count > maxParam)
                    {
                        string formatCall = $"Format({variable}, {string.Join(", ", args)})";
                        line = concatRegex.Replace(line, formatCall);
                    }
                }
            }
        }

        return line;
    }
}