using System;

namespace GoalSpace
{
    public class Goal
    {
        // attributes 
        //   private List<string> myList = new List<string>();
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
    public  void SaveUserData(string userName, string data)
        {
            // Create a file path using the user's name
            string filePath = $"{userName}.txt";

            // Write the data to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(data);
            }
        }
        
        // public virtual string DisplayGoal(string name, string description){
        //    return $"{name} ({description})";
        //   }
       // save goals 
       public void saveGoals(){}
       // loag goals 
       public void loadGoals(){} 
    }

}

     