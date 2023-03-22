using System;
using System.IO;

namespace GoalSpace
{
    public class ExternalGoal:Goal
    {
        // attributes 
         private string _GoalName{get; set;}
         private string _GoalDescription{get; set;} 
         private int _GoalPoints{get; set;}
        // constructors 
        // methods 
         public override void DispalyGoalsMethod(){
           Console.Write("What is the name of your Goal? ");
           _GoalName =  Console.ReadLine();
           Console.Write("What is a short description of it? ");
           _GoalDescription =  Console.ReadLine();
           Console.Write("What is the amount of points associated with this goal ");
            _GoalPoints =  int.Parse(Console.ReadLine());
            saveExtgoal(_GoalName,_GoalDescription);
        }

       public void saveExtgoal(string name, string description){
        string data = $"[ ] {name} ({description})";
        string defaultName = "default.txt";
        using (StreamWriter writer = new StreamWriter(defaultName, true))
            {
                // iterate over each element of the list and write it to the file
                    writer.WriteLine(data);
            }
            }
    }

}