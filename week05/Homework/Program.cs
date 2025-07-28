using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("John Smith", "Fractions", "Section 1.1", "Problems 1-10");
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();
        WritingAssignment writingAssignment = new WritingAssignment("Mary Johnson", "European History", "The Causes of World War II"); 
        Console.WriteLine(writingAssignment.GetWritingInformation());
        Console.WriteLine(); 
    }
}