using System;

namespace Wordle
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int wordGuesses = 5;
            string theWord = "Wordle";

            Words words = new Words(wordGuesses, theWord);

            while (!words.GameFinished())
            {
                string guess = String.Empty;
                do
                {
                    Console.Clear();

                    for (int i = 0; i < words.GetSize(); i++)
                    {
                        Console.Write("_ ");
                    }
                    Console.WriteLine($" ({words.GetSize()})");
                    words.DisplayAttempt();
                    Console.Write("Enter Guess: ");
                    guess = Console.ReadLine().ToUpper() ?? String.Empty;
                } while (guess.Length != theWord.Length);
                words.MakeAttempt(guess);
            }
            Console.Clear();
            words.DisplayAttempt();
            Console.WriteLine($"\nYou Have Guessed The Word " +
                $"{(words.GuessedWord() ? "Correctly" : "Incorrectly")}");
        }
    }
}
