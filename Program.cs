using System;

namespace guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess the number. You get 4 tries.");

            Random randomNumberGenerator = new Random();
            int secretNumber = randomNumberGenerator.Next(1, 101);
        int numOfGuesses = 4;
        for (int i  = 0; i < numOfGuesses;  i++){
            Console.Write($"Guess #{numOfGuesses - i}> ");
            string guess = Console.ReadLine();
            // int the guess to prepare for if conditional
            int intGuess = int.Parse(guess);
                    if (intGuess == secretNumber) {
                        Console.WriteLine("You got it!");
                        break;
                    } else if (intGuess >  secretNumber){
                        Console.WriteLine("Too High");
                    // below condition is kind of redundant
                    } else if (intGuess < secretNumber){
                        Console.WriteLine("Too Low");
                    }
                    // dead code
                    else {
                        Console.WriteLine("Incorrect.");
                    }
        }
                    Console.WriteLine($"Game Over! The correct number was {secretNumber}");
        }
    }
}
