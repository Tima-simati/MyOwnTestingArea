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
            char[] chosenWord = boxOfWords[randomIndex].ToCharArray();
            char[] outputString = new char[chosenWord.Length];  //char array which shows the state of guessed characters
            int lastIndexOfWord = (outputString.Length - 1);    //last index of chosenWord
            for (int i = 0; i <= lastIndexOfWord; i++)
            {
                outputString[i] = '_';
            }
            while (wrongGuesses < WRONG_GUESSES_MAX)
            {
                Console.WriteLine("Your guess is: ");
                char userInput = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (chosenWord.Contains(userInput))
                {
                    //tracking of right letter guessing
                    Console.WriteLine("You guessed a letter correct.");
                    for (int i = 0; i <= lastIndexOfWord; i++)
                    {
                        if (chosenWord[i] == userInput)
                        {
                            outputString[i] = userInput;
                        }
                        Console.Write(outputString[i]);
                    }
                    Console.WriteLine();
                }
                else
                {
                    //tracking of wrong guesses and losing condition
                    wrongGuesses++;
                    int guessesLeft = WRONG_GUESSES_MAX - wrongGuesses;
                    Console.Clear();
                    Console.WriteLine($"Wrong guess! Letter <{userInput}> is not included. You have only {guessesLeft} guesses left.");
                    Console.WriteLine(outputString);
                }
                //Winning Condition
                for (int i = 0; i <= lastIndexOfWord; i++)
                {
                    if (outputString[i] != chosenWord[i])
                    {
                        break;
                    }
                    if (i == lastIndexOfWord && outputString[i] == chosenWord[i])
                    {
                        Console.WriteLine("You did it. You guessed the word correctly! You win.");
                        return;
                    }
                }
                //Losing Condition
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
