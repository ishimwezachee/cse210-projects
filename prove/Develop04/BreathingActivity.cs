using System;

    public class BreathingActivity:Activity {
          // attributes (private)

        private string _breatheIn; 
        private string _breathOut;

        private string _activityDescription;
        // private string _randomPrompt<list>; 
       private string _description;
        // constructors 
        // getters and setters
        // methods 
        public void breathingActivity(){
          Console.WriteLine(StartMessage("Breathing"));
          Console.WriteLine("");
          Console.WriteLine(DescribtionMessage("Walking you through breathing in and out slowly. Clear your mind and focus on your breathing."));
          Console.WriteLine("");
          int duration = HowLongTimer();
          Console.WriteLine(duration);
        }

    }