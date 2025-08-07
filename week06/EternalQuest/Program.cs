// For my exceeding expectations, I added a new variable List<Goal> called _completedGoals and stored the completed goals in it, I also saved the completed goals in a txt file and created new methods for saving and loading it.
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