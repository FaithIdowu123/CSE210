// For my exceeding expectations, I added a new variable List<Goal> called _completedGoals, a new method called GetCompleted to the goal manager class and I also created a getcomplete method to the checklist and simple goal classes in order to check if the goal has been completed. I stored the completed goals in the new completedgoals list, saved the completed goals in a txt file and created new methods for saving and loading it.
// I also made it so that completed goals will only appear the list completed goals option and no longer appear in the list goals option.
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}