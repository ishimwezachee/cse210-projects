using System;

class Program
{
    static void Main(string[] args)
    {

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
        ListingActivity listAct = new ListingActivity();
        if(n == 1){
          Console.Clear();
          breathingAct.breathingActivity();
        }else if(n == 2){
          reflectingAct.ReflectionActivity();
        }else if (n == 3){
          listAct.Listing();
        }else if(n == 4){
           Console.WriteLine();
        }else{
           Console.WriteLine("Please select among the given choice");
        }
        }
    }
}