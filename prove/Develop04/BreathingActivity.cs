using System;

    public class BreathingActivity:Activity {
          // attributes (private)
        private string _breathing = "Breathing"; 
        private string _activityDescription;
        // private string _randomPrompt<list>; 
       private string _description;
        // constructors 
        // getters and setters
        // methods 
        public void BreathIn(){
         Console.Write($"Breathe in..."); 
        for( int i = 3; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        }
        public void BreathOut(){
          Console.Write("Now breath out...");
          for( int i = 4; i>0; i--)
          {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            }
            }
        public void breathingActivity(){
          Console.Clear();
          Console.WriteLine(StartMessage(_breathing));
          Console.WriteLine("");
          Console.WriteLine(DescribtionMessage("Walking you through breathing in and out slowly. Clear your mind and focus on your breathing."));
          Console.WriteLine("");
          int duration = HowLongTimer();
          // Console.WriteLine(duration);
          Console.Clear();
          Console.WriteLine("Get ready...");
          Spinning();
          Console.WriteLine("");
          // logic for breathing ...
          DateTime startTime = DateTime.Now;
          DateTime endTime = startTime.AddSeconds(duration);
          while(DateTime.Now < endTime){
            BreathIn();
            Console.WriteLine("");
            BreathOut();
            Console.WriteLine("");
            Console.WriteLine("");
         }
         WellDone();
         Spinning();
         FinishMessage(duration,_breathing);
         Spinning();
         Console.Clear();
        }

    }