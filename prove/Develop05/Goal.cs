using System;

namespace GoalSpace
{
    public class Goal
    {
        // attributes 
          private List<string> myList = new List<string>();
        // constructors 
        // properties 
         public List<string> MyList { get; set; } = new List<string>();
        // methods 
        public int GetRandomPrompt(){
        string choice = Console.ReadLine();
        int num = int.Parse(choice);
        return num;
        }
         // record event
        public List<string> RecordEvent()
        {
            List<string> myList = new List<string>();
            return myList;
        }
       // display name Method

    //    public void DisplayName(){}
    //    // Display description
    //    public void DisplayDescription(){}
    //    // Display Points 
    //    public void DisplayPoints(){}
          public virtual string DisplayGoal(string name, string description){
           return $"{name} ({description})";
          }
       // save goals 
       public void saveGoals(){}
       // loag goals 
       public void loadGoals(){} 
    }

}

     