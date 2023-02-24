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
        public void WellDone(){
          Console.WriteLine("Well done!!");
        }
        public void FinishMessage(int duration ,string activity){
           Console.WriteLine("");
          Console.WriteLine($"You have completed another {duration} seconds of the {activity} Activity.");
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
        public void Spinning(){
           List<string> animationsString = new List<string>();
            animationsString.Add("|");
            animationsString.Add("/");
            animationsString.Add("-");
            animationsString.Add("\\");
            animationsString.Add("|");
            animationsString.Add("/");
            animationsString.Add("-");
            animationsString.Add("\\");
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(8);
            int i = 0;
            while(DateTime.Now < endTime){
                string s = animationsString[i];
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                i++;
                if (i>= animationsString.Count)
                {
                    i = 0;
                }
            }
        }
        public void GetReadyTimer(){} 
        public int  HowLongTimer(){
         Console.Write("How long, in seconds, would you like for your session? ");
         int duration = int.Parse(Console.ReadLine());
         return duration;
        } 
        public void Menu(){} 
        public void DisplayDescription(){} 
        
    }