// Exceeding Requirements:
// This program improves the scripture memorization experience by ensuring that
// only visible words are hidden each round, preventing already hidden words from
// being selected again. This makes the activity more effective and challenging.
// Additionally, the design supports working with multiple scriptures, allowing
// one to be selected and memorized instead of repeating a single passage.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(
            reference,
            "5 Trust in the Lord with all thine heart; and lean not unto thine own understanding.\n" +
            "6 In all thy ways acknowledge him, and he shall direct thy paths."
        );

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program ended.");
                break;
            }
        }
    }
}
