using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    internal class Program
    {
        static void Main()
        {
            List<string> wordList = new List<string> { "apple", "banana", "cherry", "date", "mango" };

            // Select a random word from the word list
            Random random = new Random();
            string selectedWord = wordList[random.Next(wordList.Count)];

            int maxAttempts = 7;
            int attempts = 0;
            string guessedLetters = "";

            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("Guess the letters to find the word.");
            Console.WriteLine("You have {0} wrong attempts.", maxAttempts);

            // Display initial dashes representing the word
            char[] hiddenWord = new char[selectedWord.Length];
            for (int i = 0; i < selectedWord.Length; i++)
            {
                hiddenWord[i] = '_';
            }

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Word: " + new string(hiddenWord));

                Console.Write("Enter a letter: ");
                char guessedLetter = Console.ReadLine()[0];

                // Check if the guessed letter is already guessed
                if (guessedLetters.Contains(guessedLetter))
                {
                    Console.WriteLine("You have already guessed the letter '{0}'. Try again.", guessedLetter);
                    continue;
                }

                // Add the guessed letter to the guessed letters list
                guessedLetters += guessedLetter;

                // Check if the guessed letter is in the selected word
                bool foundLetter = false;
                for (int i = 0; i < selectedWord.Length; i++)
                {
                    if (selectedWord[i] == guessedLetter)
                    {
                        hiddenWord[i] = guessedLetter;
                        foundLetter = true;
                    }
                }

                if (foundLetter)
                {
                    Console.WriteLine("Correct guess!");
                }
                else
                {
                    Console.WriteLine("Incorrect guess!");
                    attempts++;

                    // Check if the player has used all attempts
                    if (attempts == maxAttempts)
                    {
                        Console.WriteLine("You lost! The word was '{0}'.", selectedWord);
                        break;
                    }
                }

                // Check if the player has guessed all letters correctly
                if (!hiddenWord.Contains('_'))
                {
                    Console.WriteLine("Congratulations! You guessed the word '{0}' correctly.", selectedWord);
                    break;
                }
            }

            Console.WriteLine("Thanks for playing Hangman!");
            Console.ReadLine();
        }
    }
}
