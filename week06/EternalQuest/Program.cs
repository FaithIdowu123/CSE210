// For my exceeding expectations, I made it so that whenever the user gets 20 points, their level increases by one. 
// I also made it that the user will not be able to get points for goals that have already been completed. except for eternal goals.
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}