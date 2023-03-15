using System;
using System.IO;

namespace GoalSpace
{
    public class SimpleGoal:Goal
    {
        // attributes 
         private string _GoalName{get; set;}
         private string _GoalDescription{get; set;}
         private int _GoalPoints{get; set;}
        // constructors 
        // methods 
        public override void DispalyGoalsMethod(){
           //Console.WriteLine("Simple Goal Logics");
           // simple goals implimentations 
           Console.Write("What is the name of your Goal? ");
           _GoalName =  Console.ReadLine();
           Console.Write("What is a short description of it? ");
           _GoalDescription =  Console.ReadLine();
           Console.Write("What is the amount of points associated with this goal");
           string points = Console.ReadLine();
           _GoalPoints = int.Parse(points);
            // _GoalPoints =  int.Parse(Console.ReadLine());
            saveSgoal(_GoalName,_GoalDescription);
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
        // display the data from the file `
        string filename = "default.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string fileData = parts[0];
            Console.WriteLine(fileData);
        }
        
    }

      public void LoadFromFileGoalName(string goalName){
        if (string.IsNullOrEmpty(goalName)){
        string[] lines = System.IO.File.ReadAllLines(goalName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string fileData = parts[0];
            Console.WriteLine(fileData);
        }      
    }else{
        Console.WriteLine("There is no such file name!!!!");
    }
      
    }
    
    }

}