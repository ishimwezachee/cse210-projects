using System;

namespace GoalSpace
{
    public class ExternalGoal:Goal
    {
        // attributes 
         private string _GoalName{get; set;}
         private string _GoalDescription{get; set;}
         private string _GoalPoints{get; set;}
        // constructors 
        // methods 
        public void ExternalGoalMethod(){
           Console.Write("What is the name of your Goal? ");
           _GoalName =  Console.ReadLine();
           Console.Write("What is a short description of it? ");
           _GoalDescription =  Console.ReadLine();
           Console.Write("What is the amount of points associated with this goal ");
           int GoalPoints =  int.Parse(Console.ReadLine());
             MyList.Add($"[ ] {_GoalName} ({_GoalDescription})");
        }

        // public void ListMyExtGoals(){
        //    foreach(string s in MyList)
        //    {
        //     Console.WriteLine(s);
        //    }
        // }

        public void ListMyExtGoals(List<string> Myarr){
           foreach(string s in MyList)
           {
            // Console.WriteLine(s);
            Myarr.Add(s);
           }
        }

    }

}