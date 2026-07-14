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
            //write a block that helps you find out if a character is part of a string
            Console.WriteLine("Your guess is: ");
            Console.ReadKey();
            string userInput = Convert.ToString(Console.ReadLine());
            char userInputChar = userInput[0];
            string outputString = new string('_', chosenWord.Length); //parts of the chosenWord, which will be revealed

            if (chosenWord.Contains(userInputChar))
            {
                Console.WriteLine("You guessed a letter correct.");
            }
            else
            {
                wrongGuesses++;
                int guessesLeft = WRONG_GUESSES_MAX - wrongGuesses;
                Console.WriteLine($"Wrong guess! You have only {guessesLeft} guesses left.");
            }


            //write some code to find the position of a specific letter in a word ( for loops seem like a good idea)
            //write a block that outputs the current state of the game (like in the screenshot).
            //Console.Clear() can help to make things look better
            Console.Clear();
            for (int i = 0; i < chosenWord.Length; i++)
            {
                if (chosenWord[i] == userInputChar)
                {
                    indexOfGuessedChar = i;
                    outputString = outputString.Insert(indexOfGuessedChar, userInputChar.ToString());
                }


            }
            Console.WriteLine(outputString);


            // pack all of this in a loop, and keep track of tries
            Console.WriteLine("This is the debugger working.");
        }
    }
}
