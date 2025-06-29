using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter your number: ");
            string? input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        float Sum = 0;
        float Average = 0;
        int Largest = 0;
        int smallest = 999999;
        foreach (int Number in numbers)
        {
            Sum += Number;
            if (Number > Largest)
            {
                Largest = Number;
            }
            if (Number < smallest && Number > 0)
            {
                smallest = Number;
            }
        }
        Average = Sum / numbers.Count;
        Console.WriteLine($"Sum: {Sum}");
        Console.WriteLine($"Avergae: {Average}");
        Console.WriteLine($"Largest number: {Largest}");
        Console.WriteLine($"Smallest number: {smallest}");
        numbers.Sort();
        foreach (int item in numbers)
        {
           Console.WriteLine(item);
        }
    }
}