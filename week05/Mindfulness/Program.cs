//For my exceeding expectations, I created a variable named tracker in order to keep track of how many activities the user performed. 
//I also printed a message stating the number of activities the user performed. 
using System;

class Program
{
    static void Main(string[] args)
    {
        int tracker = 0;
        bool choice = false;
        while (choice == false)
        {
            Console.Clear();
            string description = "";
            Console.WriteLine("Menu options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                tracker += 1;
                Console.Clear();
                description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                BreathingActivity activity1 = new BreathingActivity("Breathing Activity", description);

                activity1.Run();
            }
            else if (option == "2")
            {
                tracker += 1;
                Console.Clear();
                description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                ReflectingActivity activity3 = new ReflectingActivity("Reflectting Activity", description);

                activity3.Run();
            }
            else if (option == "3")
            {
                tracker += 1;
                Console.Clear();
                description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                ListingActivity activity2 = new ListingActivity("Listing Activity", description);

                activity2.Run();
            }
            else if (option == "4")
            {
                choice = true;
            }
            
        }
        Console.WriteLine("");
        if (tracker == 1)
        {
            Console.WriteLine($"You performed {tracker} activity during you session.");
        }
        else if (tracker > 1)
        {
            Console.WriteLine($"You performed {tracker} activities during your session.");
        }
        else
        {
            Console.WriteLine($"You performed {tracker} activities during your session.");
        }
            
        Console.WriteLine("Bye for now.");
    }
}