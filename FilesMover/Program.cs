using System.Diagnostics;
using System.ServiceProcess;

class Program
{
    static void Main(string[] args)
    {
        const string serviceName = "_3CXCostManagerService_Desktop";
        // const string sourcePath = @"\\bnsms.lit.de\public\CL(G)Gemeinsam\CDR LOG\CDRLogsBis01022026";
        const string sourcePath = @"C:\Users\Schiefer\Desktop\CDRLogs";
        const string targetPath = @"C:\Users\Schiefer\Documents\3CX\Logs\";
        const int filesPerSecond = 5;
        const int progressBarWidth = 25;
        const bool copyFiles = false;

        // Check directories
        if (!Directory.Exists(sourcePath))
        {
            Console.WriteLine("Quellordner existiert nicht.");
            return;
        }

        if (!Directory.Exists(targetPath))
            Directory.CreateDirectory(targetPath);

        Console.WriteLine("Lade Dateien...");
        
        var allFiles = Directory.GetFiles(sourcePath);
        int totalFiles = allFiles.Length;
        int movedFiles = 0;

        if (copyFiles)
            Console.WriteLine("Starte Kopieren von Dateien...\n");
        else
            Console.WriteLine("Starte Dateiverschiebung...\n");

        Stopwatch stopwatch = Stopwatch.StartNew();

        while (movedFiles < totalFiles)
        {
            DateTime startingTime = DateTime.Now;
            
            try
            {
                ServiceController sc = new ServiceController(serviceName);
                if (sc.Status != ServiceControllerStatus.Running)
                {
                    Console.WriteLine("Der 3CX-CostManagerService läuft nicht.");
                    //WaitUntil(startingTime.AddSeconds(1));
                    Thread.Sleep(1000);
                    continue;
                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("3CX-CostManagerService wurde nicht gefunden.");
                // WaitUntil(startingTime.AddSeconds(1));
                Thread.Sleep(1000);
                continue;
            }
            
            var files = Directory.GetFiles(sourcePath)
                                 .Take(filesPerSecond)
                                 .ToList();

            foreach (var file in files)
            {
                try
                {
                    string fileName = Path.GetFileName(file);
                    string destinationFile = Path.Combine(targetPath, fileName);

                    if (copyFiles)
                        File.Copy(file, destinationFile, true);
                    else
                        File.Move(file, destinationFile, true);
                    
                    movedFiles++;
                }
                catch (Exception ex)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Es ist ein Fehler aufgetreten: " + ex);
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }

            // Fortschritt berechnen
            double progress = (double)movedFiles / totalFiles;
            int filled = (int)(progress * progressBarWidth);
            string bar = new string('#', filled) + new string('-', progressBarWidth - filled);

            // Geschwindigkeit berechnen
            double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;
            double speed = movedFiles / Math.Max(elapsedSeconds, 1);
            double remainingFiles = totalFiles - movedFiles;
            double remainingSeconds = remainingFiles / Math.Max(speed, 0.1);

            TimeSpan eta = TimeSpan.FromSeconds(remainingSeconds);

            // Anzeige aktualisieren (eine Zeile überschreiben)
            Console.CursorLeft = 0;
            Console.Write(
                $"{bar} | {Math.Round(progress * 100, 2)}% | {movedFiles:N0} von {totalFiles:N0} | Restdauer: {eta:hh\\:mm\\:ss}   "
            );

            // WaitUntil(startingTime.AddSeconds(1));
            Thread.Sleep(1000);
        }

        stopwatch.Stop();

        Console.WriteLine("\n\nFertig!");
        Console.WriteLine($"Gesamtdauer: {stopwatch.Elapsed:hh\\:mm\\:ss}");
        Console.ReadKey();
    }

    static void WaitUntil(DateTime time)
    {
        int milliSeconds = DateTime.Now.Millisecond - time.Millisecond;
        if (milliSeconds < 0)
            milliSeconds += 1000;
        
        Thread.Sleep(milliSeconds);
    }
}