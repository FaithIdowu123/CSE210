using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();
        Running activity1 = new Running("Running", 30, DateTime.Now);
        activity1.SetDistance(4.89);
        activity1.CalculatePace();
        activity1.CalculateSpeed();
        exercises.Add(activity1);

        Cycling activity2 = new Cycling("Cycling", 35, DateTime.Now);
        activity2.SetSpeed(10.50);
        activity2.CalculatePace();
        activity2.CalculateDistance();
        exercises.Add(activity2);

        Swimming activity3 = new Swimming("Swimming", 17, 33, DateTime.Now);
        activity3.CalculateDistance();
        activity3.CalculatePace();
        activity3.CalculateSpeed();
        exercises.Add(activity3);

        foreach (Exercise exercise in exercises)
        {
            exercise.GetSummary();
        }
    }
}