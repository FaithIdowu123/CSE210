using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string? answer = Console.ReadLine();
        int percent = int.Parse(answer);
        string Grade = "";

        if (percent >= 90)
        {
            Grade = "A";
            if (percent <= 93)
            {
                Grade = Grade + "-";
            }

        }
        else if (percent >= 80)
        {
            Grade = "B";
            if (percent >= 87)
            {
                Grade = Grade + "+";
            }
            else if (percent <= 83)
            {
                Grade = Grade + "-";
            }
        }
        else if (percent >= 70)
        {
            Grade = "C";
            if (percent >= 77)
            {
                Grade = Grade + "+";
            }
            else if (percent <= 73)
            {
                Grade = Grade + "-";
            }
        }
        else if (percent >= 60)
        {
            Grade = "D";
            if (percent >= 67)
            {
                Grade = Grade + "+";
            }
            else if (percent <= 63)
            {
                Grade = Grade + "-";
            }
        }
        else
        {
            Grade = "F";
        }

        Console.WriteLine($"Your grade is {Grade}.");
        if (percent >= 60)
        {
            Console.WriteLine("Congratulations!!! You passed.");
        }
        else
        {
            Console.WriteLine("Better Luck next time.");
        }
    }
}    