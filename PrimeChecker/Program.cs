using System.Diagnostics;
using System.Drawing;
using System.Numerics;

namespace PrimeNumberChecker;

internal abstract class Program
{
    private static Stopwatch? stopwatch;

    private static void Main()
    {
        stopwatch = new();

        while (true)
        {
            Console.WriteLine("Bitte wählen (für performante Variante füge ein \"p\" hinter die Zahl ein):\r\n" +
                "[1] - Einzelne Zahl prüfen\r\n" +
                "[2] - Liste an Primzahlen bis zur Zahl ausgeben\r\n" +
                "[3] - Einzelne rießige Zahl prüfen mit Miller-Rabin-Methode (keine Performance-Variante verfügbar)\r\n" +
                "[q]/[exit] - Programm beenden");

            string input = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(input))
                continue;

            if (input.ToLower().Contains('1'))
                CheckSingleNumber(input.Contains('p'));
            else if (input.ToLower().Contains('2'))
                ListPrimeNumbers(input.Contains('p'));
            else if (input.ToLower().Contains('3'))
                CheckPrimeNumberMillerRabin();
            else if (input.ToLower().Equals("q") || input.ToLower().Equals("exit"))
                break;

            if (stopwatch is not null)
            {
                stopwatch.Stop();
                Console.WriteLine($"Laufzeit: {stopwatch.Elapsed.Hours} Stunden {stopwatch.Elapsed.Minutes} Minuten {stopwatch.Elapsed.Seconds} Sekunden {stopwatch.Elapsed.Milliseconds} Millisekunden\r\n");
            }
        }
    }

    private static void CheckSingleNumber(bool performance = false)
    {
        // Read written line
        Console.Write("Bitte eine Zahl eingeben: ");
        string? numberString = Console.ReadLine();

        // Try to convert the string into a number
        bool isConvertible = long.TryParse(numberString, out long number);

        if (numberString is not null && isConvertible && number > 1)
        {
            // Check entered number for prime number
            if (performance ? IsPrimeNumberPerfomance(number) : IsPrimeNumber(number))
                Console.WriteLine($"{number} ist eine Primzahl :)");
            else
                Console.WriteLine($"{number} ist leider keine Primzahl :(");
        }
        // Output error text
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Fehler: ");
            Console.WriteLine("Bitte eine Zahl eingeben die größer als 0 ist.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    private static void ListPrimeNumbers(bool performance = false)
    {
        // Read written line
        Console.Write("Bitte eine Zahl eingeben, bis wohin die Primzahlen aufgelistet werden: ");
        string? numberString = Console.ReadLine();

        // Try to convert the string into a number
        bool isConvertible = long.TryParse(numberString, out long number);

        if (!isConvertible || number <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Fehler: ");
            Console.WriteLine("Bitte eine Zahl eingeben die größer als 0 ist.");
            Console.ForegroundColor = ConsoleColor.White;
            return;
        }

        Console.WriteLine("Primzahlen:");
        for (long i = 1; i <= number; i += 2)
        {
            // Check number for prime number
            if (performance ? IsPrimeNumberPerfomance(i) : IsPrimeNumber(i))
                Console.WriteLine(i);
        }
    }

    private static void CheckPrimeNumberMillerRabin()
    {
        // Read written line
        Console.Write("Bitte eine Zahl eingeben, bis wohin die Primzahlen aufgelistet werden: ");
        string? numberString = Console.ReadLine();

        // Try to convert the string into a number
        bool isConvertible = BigInteger.TryParse(numberString, out BigInteger number);

        if (!isConvertible || number <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Fehler: ");
            Console.WriteLine("Bitte eine Zahl eingeben die größer als 0 ist.");
            Console.ForegroundColor = ConsoleColor.White;
            return;
        }

        if (IsProbablyPrimeNumer(number))
            Console.WriteLine("Wahrscheinlich Primzahl");
        else
            Console.WriteLine("Keine Primzahl");
    }

    // This method returns true if number is prime number
    private static bool IsPrimeNumber(long pZahl)
    {
        stopwatch?.Start();

        for (long i = 2; i <= pZahl / 2; i++)
        {
            long modulo = pZahl % i;

            // Cancel checker if the number isn't a prime number
            if (modulo == 0)
                return false;
        }

        return true;
    }

    private static bool IsPrimeNumberPerfomance(long number)
    {
        stopwatch?.Start();

        if (number <= 1)
            return false;

        if (number is 2)
            return true;

        if (number % 2 is 0)
            return false;

        long boundary = (long)Math.Sqrt(number);

        for (long i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    private static bool IsProbablyPrimeNumer(BigInteger n, int k = 20)
    {
        stopwatch?.Start();

        if (n <= 1)
            return false;

        if (n == 2 || n == 3)
            return true;

        if (n % 2 == 0)
            return false;

        // Schreibe n -1 als 2^r * d
        BigInteger d = n - 1;
        int r = 0;

        while (d % 2 == 0)
        {
            d /= 2;
            r++;
        }

        Random rnd = new();

        for (int i = 0; i < k; i++)
        {
            BigInteger a = RandomBigInteger(2, n - 2, rnd);
            BigInteger x = BigInteger.ModPow(a, d, n);

            if (x == 1 || x == n - 1)
                continue;

            bool passed = false;
            for (int j = 0; j < r - 1; j++)
            {
                x = BigInteger.ModPow(x, 2, n);
                if (x == n - 1)
                {
                    passed = true;
                    break;
                }
            }

            if (!passed)
                return false;
        }

        return true;
    }

    private static BigInteger RandomBigInteger(BigInteger min, BigInteger max, Random rnd)
    {
        byte[] bytes = max.ToByteArray();
        BigInteger result;

        do
        {
            rnd.NextBytes(bytes);
            bytes[^1] &= 0x7F; // Positiv machen
            result = new BigInteger(bytes);
        } while (result < min || result >= max);

        return result;
    }
}