using System;

namespace GoalSpace
{
    public class CheckListGoal:Goal
    {
        // attributes 
         private string _GoalName{get; set;}
         private string _GoalDescription{get; set;}
         private string _GoalPoints{get; set;}
        // constructors 
        // methods 
        public void CheckListGoalMethod(){
           Console.Write("What is the name of your Goal? ");
           _GoalName =  Console.ReadLine();
           Console.Write("What is a short description of it? ");
           _GoalDescription =  Console.ReadLine();
           Console.Write("What is the amount of points associated with this goal ");
           int GoalPoints =  int.Parse(Console.ReadLine());
             saveCheckGoal(_GoalName, _GoalDescription);
        }

       public void saveCheckGoal(string name, string description){
        string data = $"[ ] {name} ({description}) -- Currently Completed: 0/3";
        string defaultName = "default.txt";
        using (StreamWriter writer = new StreamWriter(defaultName, true))
            {
                // iterate over each element of the list and write it to the file
                    writer.WriteLine(data);
            }
       }
    }

}