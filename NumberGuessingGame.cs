using System;

namespace Module2
{
    internal class NumberGuessingGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Challenger to the Number Guessing Game!");
            Console.WriteLine("I will now think of a number between 1 and 100.\nTry to guess the number.");
            
            //range for number guessing range
            const int GUESSING_LOWERBOUND = 1;
            const int GUESSING_UPPERBOUND = 100;
            //random number generated
            Random rng = new Random();
            int randomNumber = rng.Next(GUESSING_LOWERBOUND, GUESSING_UPPERBOUND); // Number to be guessed
            const int TRIES = 10; //how many times you can try to guess
            const int CLOSE_GUESS = 5;
            //check for correct guess
            for (int i = 0; i < TRIES; i++)
            {
                int numberGuessed = Convert.ToInt16(Console.ReadLine());
                if (numberGuessed == randomNumber)
                {
                    Console.WriteLine("Congratulations! You won!");
                    return;
                }
                if (numberGuessed < randomNumber)
                {
                    Console.WriteLine("Too Low! Try again");
                }
                if (numberGuessed > randomNumber)
                {
                    Console.WriteLine("Too High! Try again");
                }
                Console.WriteLine($"You have {TRIES - 1 - i} guess(es) left.");
                //Hint to Player, if he is only is 5 off
                if (Math.Abs(randomNumber - numberGuessed) <= CLOSE_GUESS)
                {
                    Console.WriteLine("You're close!");
                }
            }
        }
    }
}
