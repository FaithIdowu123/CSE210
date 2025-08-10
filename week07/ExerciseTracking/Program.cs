using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();
        Running activity1 = new Running("Running", 4.89,30, DateTime.Now);
        exercises.Add(activity1);

        Cycling activity2 = new Cycling("Cycling", 10.50, 35, DateTime.Now);
        exercises.Add(activity2);

        Swimming activity3 = new Swimming("Swimming", 17, 33, DateTime.Now);
        exercises.Add(activity3);

        foreach (Exercise exercise in exercises)
        {
            string summary = exercise.GetSummary();
            Console.WriteLine(summary);
        }
    }
}