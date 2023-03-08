using System;

namespace GoalSpace
{
    class Program
{
    static void Main(string[] args)
    {
        int n = -1;
        while(n != 6)
        {
        Console.WriteLine("You have 0 points");
        Console.WriteLine("");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("    1. Create New Goal");
        Console.WriteLine("    2. List Goals");
        Console.WriteLine("    3. Save Goals");
        Console.WriteLine("    4. Load Goals");
        Console.WriteLine("    5. Record Goals");
        Console.WriteLine("    6. Quit");
        Console.Write("Select a choice from the menu: ");

        // get selection prompt 
        Goal goal = new Goal();
        n = goal.GetRandomPrompt();
        if(n ==1){
            int t = -1;
            while(t!=6){
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. External Goal");
            Console.WriteLine("  3. CheckList Goal");
            Console.WriteLine("Which type of goal would you like to create?");
            t = int.Parse(Console.ReadLine());
            SimpleGoal Sgoal = new SimpleGoal();
            ExternalGoal Exgoal = new ExternalGoal();
            CheckListGoal Chgoal = new CheckListGoal();

            if(t == 1){
                // Console.WriteLine("Simple Goal");
                Sgoal.SimpleGoalMethd();
            }else if( t == 2){
                Exgoal.ExternalGoalMethod();
            }else if (t == 3){
                Chgoal.CheckListGoalMethod();
            }

            }

           
        }else if (n==2){
            Console.WriteLine("List Goals");
        }else if (n ==3){
            Console.WriteLine("Save Goals");
        }else if(n == 4){
            Console.WriteLine("Load Goals");
        }else if(n == 5){
            Console.WriteLine("Record Goals");
        }else {
            Console.WriteLine("Out !! ");
        }
        }
    }
}
}