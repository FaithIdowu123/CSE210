using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private List<Goal> _completedGoals = new List<Goal>();


    public GoalManager()
    {

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void Start()
    {
        bool stop = false;
        while (!stop)
        {

            Console.WriteLine("");
            DisplayPlayerInfo();
            Console.WriteLine("");

            Console.WriteLine("Menu options:");
            Console.WriteLine("  1. Create New Goal.");
            Console.WriteLine("  2. List Goals.");
            Console.WriteLine("  3. List Completed Goals.");
            Console.WriteLine("  4. Save Goals.");
            Console.WriteLine("  5. Load Goals.");
            Console.WriteLine("  6. Record Event.");
            Console.WriteLine("  7. Quit");
            Console.Write("Select a choice from the menu: ");
            GetCompleted();

            string choice = Console.ReadLine();
            int option = int.Parse(choice);

            if (option == 1)
            {
                string goal = "";
                Console.WriteLine("The type of goals are:");
                Console.WriteLine("  1. Simple Goal.");
                Console.WriteLine("  2. Eternal Goal.");
                Console.WriteLine("  3. CheckList Goal.");
                Console.Write("Which would you like to create? ");
                choice = Console.ReadLine();
                int answer = int.Parse(choice);


                if (answer == 1)
                {
                    goal = "SimpleGoal";
                }
                else if (answer == 2)
                {
                    goal = "EternalGoal";
                }
                else if (answer == 3)
                {
                    goal = "CheckListGoal";
                }

                CreateGoal(goal);
            }
            else if (option == 2)
            {
                Console.WriteLine("");
                if (_goals.Count() != 0)
                {
                    Console.WriteLine("This is a list of ongoing goals: ");
                    int i = 0;
                    foreach (Goal goal in _goals)
                    {
                        i++;
                        Console.WriteLine($"{i}. {goal.GetDetails()}");
                    }
                }
                else
                {
                    Console.WriteLine("Oops! Sorry, you don't have any active goals.");
                }
            }
            else if (option == 3)
            {
                Console.WriteLine("");
                if (_completedGoals.Count() != 0)
                {
                    Console.WriteLine("This is a list of completed goals: ");
                    int i = 0;
                    foreach (Goal goal in _completedGoals)
                    {
                        i++;
                        Console.WriteLine($"{i}. {ListDetails(goal)}");
                    }
                }
                else
                {
                    Console.WriteLine("Oops! Sorry, you don't have any active goals.");
                }
            }
            else if (option == 4)
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                SaveGoal(filename);

                SaveCompletedGoal("completedGoals");
            }
            else if (option == 5)
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                LoadGoals(filename);
                LoadCompletedGoals("completedGoals");
            }
            else if (option == 6)
            {
                Console.WriteLine("");
                if (_goals.Count() != 0)
                {
                    Console.WriteLine("The goals are: ");
                    int i = 0;
                    foreach (Goal goal in _goals)
                    {
                        i++;
                        Console.WriteLine($"{i}. {ListName(goal)}");
                    }
                    Console.Write("What goal did you accomplish? ");
                    choice = Console.ReadLine();
                    int answer = int.Parse(choice) - 1;

                    RecordEvent(_goals[answer]);
                    int points = _goals[answer].GetPoints() + _goals[answer].GetBonus();
                    _score += points;

                    Console.WriteLine($"Congratulation! You just earned {points} points!");
                    Console.WriteLine($"You now have {_score} points.");
                }
                else
                {
                    Console.WriteLine("Oops! Sorry, you don't have any active goals.");
                }
            }
            else if (option == 7)
            {
                stop = true;
            }
        }
    }

    public string ListName(Goal goal)
    {
        return goal.GetName();
    }

    public string ListDetails(Goal goal)
    {
        return goal.GetDetails();
    }

    public void CreateGoal(string goal)
    {
        if (goal == "SimpleGoal")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string amount = Console.ReadLine();
            int points = int.Parse(amount);

            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);

            _goals.Add(simpleGoal);
        }
        else if (goal == "EternalGoal")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string amount = Console.ReadLine();
            int points = int.Parse(amount);

            EternalGoal eternalGoal = new EternalGoal(name, description, points);

            _goals.Add(eternalGoal);
        }
        else if (goal == "CheckListGoal")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string amount = Console.ReadLine();
            int points = int.Parse(amount);

            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            amount = Console.ReadLine();
            int target = int.Parse(amount);

            Console.Write("What is the bonus for accomplishing it that many times? ");
            amount = Console.ReadLine();
            int bonus = int.Parse(amount);

            CheckListGoal checkListGoal = new CheckListGoal(name, description, points, bonus, target);

            _goals.Add(checkListGoal);
        }
    }

    public void RecordEvent(Goal goal)
    {
        goal.RecordEvent();
    }

    public void LoadGoals(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        List<string> goals = lines.ToList();

        foreach (var line in goals)
        {
            string[] part = line.Split(":");

            string goal = part[0];
            string info = part[1];

            if (goal == "SimpleGoal")
            {
                string[] details = info.Split("|");
                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);
                bool iscomplete = bool.Parse(details[3]);

                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                simpleGoal.RecordEvent();

                _goals.Add(simpleGoal);
            }
            else if (goal == "EternalGoal")
            {
                string[] details = info.Split("|");
                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);

                EternalGoal eternalGoal = new EternalGoal(name, description, points);

                _goals.Add(eternalGoal);
            }
            else if (goal == "CheckListGoal")
            {
                string[] details = info.Split("|");
                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);
                int bonus = int.Parse(details[3]);
                int target = int.Parse(details[4]);
                int amountCompleted = int.Parse(details[5]);

                CheckListGoal checkListGoal = new CheckListGoal(name, description, points, bonus, target);

                for (int i = amountCompleted; i > 0; i--)
                {
                    checkListGoal.RecordEvent();
                }

                _goals.Add(checkListGoal);
            }
        }
    }

    public void LoadCompletedGoals(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        List<string> goals = lines.ToList();

        goals.RemoveAt(0);
        
        foreach (var line in goals)
        {
            string[] part = line.Split(":");

            if (part.Length < 2)
            {
                continue;
            }

            string goal = part[0];
            string info = part[1];

            if (goal == "SimpleGoal")
            {
                string[] details = info.Split("|");
                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);
                bool iscomplete = bool.Parse(details[3]);

                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                simpleGoal.RecordEvent();

                _completedGoals.Add(simpleGoal);
            }
            else if (goal == "EternalGoal")
            {
                string[] details = info.Split("|");
                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);

                EternalGoal eternalGoal = new EternalGoal(name, description, points);

                _completedGoals.Add(eternalGoal);
            }
            else if (goal == "CheckListGoal")
            {
                string[] details = info.Split("|");
                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);
                int bonus = int.Parse(details[3]);
                int target = int.Parse(details[4]);
                int amountCompleted = int.Parse(details[5]);

                CheckListGoal checkListGoal = new CheckListGoal(name, description, points, bonus, target);

                for (int i = amountCompleted; i > 0; i--)
                {
                    checkListGoal.RecordEvent();
                }

                _completedGoals.Add(checkListGoal);
            }
        }
    }

    public void SaveGoal(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetSaveableString());
            }
        }
    }
    
    public void SaveCompletedGoal(string filename)
    {  
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _completedGoals)
            {
                outputFile.WriteLine(goal.GetSaveableString());
            }
        }
    }

    public void GetCompleted()
    {
        int i = -1;
        if (_goals.Count() == 0)
        {

        }
        else
        {
            foreach (Goal goal in _goals.ToList())
            {
                i++;
                if (goal.GetComplete())
                {
                    _completedGoals.Add(goal);
                    _goals.RemoveAt(i);
                }
            }
        }
    }
}