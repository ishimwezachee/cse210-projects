using System;

class Program
{
    static void Main(string[] args)
    {


        // initialize Activity itself 

        int n = -1;

        while(n != 4){
        // every time user did not click 4 ;
        Console.WriteLine("Menu Options:");
        Console.WriteLine("    1. Start breathing activity");
        Console.WriteLine("    2. Start reflecting activity");
        Console.WriteLine("    3. Start listing activity");
        Console.WriteLine("    4. Quit");
        Console.Write("Select a choice from the menu: ");

        Activity activity = new Activity();
        n = activity.GetRandomPrompt();
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
}