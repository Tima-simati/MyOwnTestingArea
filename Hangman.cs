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

            Console.WriteLine("A word will now be picked. Try to guess the letters of the word.");
            Console.WriteLine("If you guess 6 times the letter wrong, you lose! Good luck.");
            Random rng = new Random();
            int randomIndex = rng.Next(START_OF_LIST, endOfList);
            string chosenWord = boxOfWords[randomIndex];
            //write a block that helps you find out if a character is part of a string
            char userInput = Convert.ToString(Console.ReadLine());

            //write some code to find the position of a specific letter in a word ( for loops seem like a good idea)


            //write a block that outputs the current state of the game (like in the screenshot). Console.Clear() can help to make things look better


            //look at console.readkey(); to make things nicer

            // pack all of this in a loop, and keep track of tries
            Console.WriteLine("This is the debugger working.");
        }
    }
}
