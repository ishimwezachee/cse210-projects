using System;

    public class Activity {
        // attributes (private)
        private string _startMessageActivity ;
        private string _descriptionActivity;
        private string _finishMessage;
        private string _activityDoneMessage;
        private int _durationInSec;
    //    private string _getReady ;
       
        // private string _randomPrompt<list>; 
       
        // constructors 
        // getters and setters
        public string StartMessageActivity
        {
          get { return _startMessageActivity; }
          set { _startMessageActivity = value; }
        }
        // methods 
        public string StartMessage(string activity){
          _startMessageActivity= $"Welcome to the {activity} Activity.";
          return _startMessageActivity;
        }
        public string DescribtionMessage (string description){
          _descriptionActivity= $"This activity will help you by {description}";
          return _descriptionActivity;
        }
        public int GetRandomPrompt(){
        string choice = Console.ReadLine();
        int num = int.Parse(choice);
        return num;
        }
        public void voidFinishMessage(){}
        public void GetReadyTimer(){} 
        public int  HowLongTimer(){
         Console.Write("How long, in seconds, would you like for your session? ");
         int duration = int.Parse(Console.ReadLine());
         return duration;
        } 
        public void Menu(){} 
        public void DisplayDescription(){} 
        
    }