using System;

    public class ListingActivity:Activity {
    // attribures 
    private string _listing = "Listing";
    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    // constructors 
    // methods 

    public void Listing(){
        Console.Clear();
        Console.WriteLine(StartMessage(_listing));
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        int duration = HowLongTimer();
        Console.WriteLine(duration);
    }
    }