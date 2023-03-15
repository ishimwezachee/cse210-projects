using System;

namespace GoalSpace
{
    public class CheckListGoal:Goal
    {
        // attributes 
         private string _GoalName{get; set;}
         private string _GoalDescription{get; set;}
         private int _GoalPoints{get; set;}
         private int _times{get; set;}
         private int _bonus{get; set;}
        // constructors 
        // methods 
         public override void DispalyGoalsMethod(){
           Console.Write("What is the name of your Goal? ");
           _GoalName =  Console.ReadLine();
           Console.Write("What is a short description of it? ");
           _GoalDescription =  Console.ReadLine();
           Console.Write("What is the amount of points associated with this goal ");
           _GoalPoints =  int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
           _times =  int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
           _bonus =  int.Parse(Console.ReadLine());
            saveCheckGoal(_GoalName, _GoalDescription,_times,_bonus);
        }

       public void saveCheckGoal(string name, string description,int times, int bonus){
        string data = $"[ ] {name} ({description}) -- Currently Completed: 0/{_times}";
        string defaultName = "default.txt";
        using (StreamWriter writer = new StreamWriter(defaultName, true))
            {
                // iterate over each element of the list and write it to the file
                    writer.WriteLine(data);
            }
       }
    }

}