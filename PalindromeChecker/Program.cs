namespace PalindromeChecker;

public abstract class Program
{
    private static void Main() // Optional parameter: string[] args
    {
        while (true) // Let the loop permanently run
        {
            // Enter the word or sentence
            Console.WriteLine("Bitte gib einen Satz oder ein Wort ein. Zum schließen [q] oder [exit] eingeben.");
            string? input = Console.ReadLine();

            // Check if word has only Whitespaces or nothing (null)
            if (input is null && string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Sie haben kein Wort eingegeben");
                continue; // Continue to begin instantly to next run in the while-loop
            }

            // If user typed q or exit, quit while loop to close the program
            if (input.ToLower().Equals("q") || input.ToLower().Equals("exit"))
                break;

            string word = input.Replace(" ", "").ToLower();
            bool isPalindrome = true;
            int reversedIndex = word.Length - 1;

            // Compare the first with the last one --> both goes to the middle
            for (int i = 0; i <= word.Length / 2 - 1; i++)
            {
                // When 2 characters are not the same, it's not a palindrome
                if (word[i] != word[reversedIndex])
                {
                    isPalindrome = false;
                    break; // break to quit instantly the for-loop to improve the performance
                }

                reversedIndex--;
            }

            // Output the result
            Console.WriteLine(isPalindrome // same as if statement - short if statement with true and false expression
                ? $"Ja es ist ein Palindrom :)\r\nDas Wort/der Satz wird rückwärts geschrieben: \"{word}\"\r\n" // expression if it's true
                : "Nein, es ist kein Palindrom :("); // expression if it's false
        }
    }
}