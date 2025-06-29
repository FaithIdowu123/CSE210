using System;

class Program
{
    static void Main(string[] args)
    {
        bool play = true;
        while (play == true)
        {
            Console.Write("What is the magic number? ");
            string? input = Console.ReadLine();
            int number = int.Parse(input);
            int guess = 0;
            int guesses = 0;

            while (guess != number)
            {
                guesses += 1;
                Console.Write("What is your guess? ");
                input = Console.ReadLine();
                guess = int.Parse(input);
                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it");
                    Console.WriteLine($"You guessed {guesses} times");
                    Console.Write("Do you want to play again?(Yes/No) ");
                    input = Console.ReadLine();
                    if (input == "Yes")
                    {
                        play = true;
                    }
                    else
                    {
                        play = false;
                    }
                }
            }
        }
    }
}