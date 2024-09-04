// See https://aka.ms/new-console-template for more information
using Microsoft.Win32.SafeHandles;
using System.Transactions;

namespace GuessingGame
{
    class GuessingGame
    {
        static void Main(string[] args)
        {
            string secretWord, guess;
            bool outOfGuesses = false;

            secretWord = "chocolate";
            guess = " ";
            int guessCounter = 0;
            while (guess != secretWord)
            {
                if (guessCounter == 5)
                {
                    Console.WriteLine("Sorry, too many guesses! The word you couldn't guess was: " + secretWord);
                    outOfGuesses = true;
                    break;
                }
                else
                {
                    Console.Write("What do you think the word is? Enter a word: ");
                    guess = Console.ReadLine();
                    guessCounter++;
                }

            }
            if (!outOfGuesses)
            {
                Console.WriteLine("You Win!");
            }
            Console.ReadLine();

        }

    }
}
