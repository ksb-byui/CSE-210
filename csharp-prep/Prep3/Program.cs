using System;

class Program
{    static void Main()
    {
        Random random = new Random();
        int magicNumber = random.Next(1,101);
        int guess = 0;

        Console.WriteLine("Welcome to Kole's Magic Number Guesser!");
        Console.WriteLine("I'm thinking of a number between 1 and 100 and your goal is to guess it!");
        Console.WriteLine("Each time you guess, I'll tell you whether the number is Higher or Lower than your guess.");
        Console.WriteLine("Good luck and have fun!");

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You got it! Good Job!");
            }
        }
    }
}