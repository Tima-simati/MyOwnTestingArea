using System;

namespace Hangman
{
    internal class Hangman
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game Hangman!");
            //initializin list with possible words to guess
            List<String> boxOfWords = new List<string>() { "hazardous", "niche", "pompous", "pomegranate", "gin", "oversight", "commitee", "ascension" };
            const int START_OF_LIST = 0;         //start index of list
            int endOfList = boxOfWords.Count - 1;//last index of list
            const int WRONG_GUESSES_MAX = 6;     //allowed wrong guesses
            int wrongGuesses = 0;                //counter for wrong guesses
            int indexOfGuessedChar = 0;              //index of character in the word to be guessed

            Console.WriteLine("A word will now be picked. Try to guess the letters of the word.");
            Console.WriteLine("If you guess 6 times the letter wrong, you lose! Good luck.");
            Random rng = new Random();
            int randomIndex = rng.Next(START_OF_LIST, endOfList);
            string chosenWord = boxOfWords[randomIndex];
            string outputString = new string('_', chosenWord.Length); //parts of the chosenWord, which will be revealed

            while (wrongGuesses < WRONG_GUESSES_MAX)
            {
                Console.WriteLine("Your guess is: ");
                string userInput = Convert.ToString(Console.ReadLine());

                char userInputChar = userInput[0];

                if (chosenWord.Contains(userInputChar))
                {
                    //tracking of right guessing and winning condition
                    Console.Clear();
                    Console.WriteLine("You guessed a letter correct.");
                    //Console.ReadKey();
                    for (int i = 0; i < chosenWord.Length; i++)
                    {
                        if (chosenWord[i] == userInputChar)
                        {
                            indexOfGuessedChar = i;
                            outputString = outputString.Insert(indexOfGuessedChar, userInputChar.ToString());
                        }
                    }
                    Console.WriteLine(outputString);
                }
                else
                {
                    //tracking of wrong guesses and losing condition
                    wrongGuesses++;
                    int guessesLeft = WRONG_GUESSES_MAX - wrongGuesses;
                    Console.WriteLine($"Wrong guess! You have only {guessesLeft} guesses left.");
                }
                if (outputString.Equals(chosenWord))
                {
                    Console.WriteLine("You did it. You guessed the word correctly! You win.");
                    return;
                }
                if (wrongGuesses == WRONG_GUESSES_MAX)
                {
                    Console.WriteLine("You are out of guesses. You lose!");
                    Console.WriteLine("Restart the game and try again!");
                    return;
                }
            }
        }
    }
}
