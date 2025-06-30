using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string Name = PromptUserName();
        int Number = PromptUserNumber();
        int Square = SquareNumber(Number);
        DisplayResult(Name, Square);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to te program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string? Name = Console.ReadLine();
            return Name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string? input = Console.ReadLine();
            int Number = int.Parse(input);
            return Number;
        }

        static int SquareNumber(int Number)
        {
            int Square = Number * Number;
            return Square;
        }

        static void DisplayResult(string Name, int Square)
        {
            Console.WriteLine($"{Name}, the square of your number is {Square}.");
        }
    }
}