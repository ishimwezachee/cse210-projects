using System;
using System.IO;
using System.Collections.Generic;
namespace GoalSpace
{
    class Program
{
    static void Main(string[] args)
    {
        // data storage 
        // List<string> data = new List<string>();
        // initialize my classes 
        Goal goal = new Goal();
        SimpleGoal Sgoal = new SimpleGoal();
        ExternalGoal Exgoal = new ExternalGoal();
        CheckListGoal Chgoal = new CheckListGoal();

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
        n = goal.GetRandomPrompt();
        if(n ==1){
             int t = -1;
            while(t!=6){
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. External Goal");
            Console.WriteLine("  3. CheckList Goal");
            Console.Write("Which type of goal would you like to create? ");
            t = int.Parse(Console.ReadLine());
            if(t == 1){
                // Console.WriteLine("Simple Goal");
                Sgoal.SimpleGoalMethd();
                t = 6;
            }else if( t == 2){
                Exgoal.ExternalGoalMethod();
                t = 6;
            }else if (t == 3){
                Chgoal.CheckListGoalMethod();
            }
        }
        
        }else if (n==2){
            Sgoal.LoadFromFile();
        }else if (n ==3){
             Console.WriteLine("What is the file name?");
             string userFileName = Console.ReadLine();
             using (StreamWriter outputFile = new StreamWriter($"{userFileName}.txt",true)){
                // function to add the data to file 
                 string filename = "default.txt";
                 string[] lines = System.IO.File.ReadAllLines(filename);
                 foreach (string line in lines){
                    string[] parts = line.Substring(3).Split(",");
                    string fileData = parts[0];
                    outputFile.WriteLine(fileData);
                    }
             }
        }else if(n == 4){
            // Load the goals 
            // ask the user the name of tha file what name of a file he/she want to load 
            // Load the files based on the user suggestion. 
            Console.Write("What is the filename for the goal file? ");
            string goalName = Console.ReadLine();
            Sgoal.LoadFromFileGoalName(goalName);
        }else if(n == 5){
            //Record goals 
        }else {
            Console.WriteLine("Out !! ");
        }
        }
    }
}
}