using System;
using System.IO;

namespace GoalSpace
{
    public class SimpleGoal:Goal
    {
        // attributes 
         private string _GoalName{get; set;}
         private string _GoalDescription{get; set;}
         private string _GoalPoints{get; set;}
        // constructors 
        // methods 
        public void SimpleGoalMethd(){
           //Console.WriteLine("Simple Goal Logics");
           // simple goals implimentations 
           Console.Write("What is the name of your Goal? ");
           _GoalName =  Console.ReadLine();
           Console.Write("What is a short description of it? ");
           _GoalDescription =  Console.ReadLine();
           Console.Write("What is the amount of points associated with this goal ");
           int GoalPoints =  int.Parse(Console.ReadLine());
        //   MyList.Add($"[ ] {_GoalName} ({_GoalDescription})"); 
         saveSgoal(_GoalName, _GoalDescription);
        }

       public void saveSgoal(string name, string description){
        string data = $"[ ] {name} ({description})";
        string defaultName = "default.txt";
        using (StreamWriter writer = new StreamWriter(defaultName, true))
            {
                // iterate over each element of the list and write it to the file
                    writer.WriteLine(data);
            }
       }
      public void LoadFromFile(){
        // display the data from the file 
        string filename = "default.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string fileData = parts[0];
            Console.WriteLine(fileData);
        }
        
    }
    
    }

}