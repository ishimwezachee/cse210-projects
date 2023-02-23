using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("    1. Start breathing activity");
        Console.WriteLine("    2. Start reflecting activity");
        Console.WriteLine("    3. Start listing activity");
        Console.WriteLine("    4. Quit");
        Console.Write("Select a choice from the menu: ");

        // initialize Activity itself 

        Activity activity = new Activity();
        
        int n = activity.GetRandomPrompt();

         BreathingActivity breathingAct = new BreathingActivity();
         ReflectingActivity reflectingAct = new ReflectingActivity();

        if(n == 1){
          Console.Clear();
          breathingAct.breathingActivity();
        }else if(n == 2){
          reflectingAct.reflection();
        }else if (n == 3){
          Console.WriteLine("Selected 3");
        }else if(n == 4){
           Console.WriteLine("Selected 4");
        }else{
           Console.WriteLine("Please select among the given choice");
        }
    }
}