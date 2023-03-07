using System;

    public class ListingActivity:Activity {
    // attribures 
    private string _listing = "Listing";
    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    // constructors 
    // methods 
    public string randomListingQuestion(){
        string filePath = "randomListingQuestion.txt";
        string[] lines = File.ReadAllLines(filePath);
        List<string> listQuestions = lines.ToList();
        Random rand = new Random();
        int index = rand.Next(listQuestions.Count);
        return listQuestions[index];
    }
   
    public void Listing(){
        Console.Clear();
        Console.WriteLine(StartMessage(_listing));
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        int duration = HowLongTimer();
        Console.WriteLine(duration);
        Console.Clear();
        Console.WriteLine("Get ready ...");
        Spinning();
        Console.WriteLine("");
        // Where we will empliment our loop 
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("");
        string question = randomListingQuestion();
        Console.WriteLine($"--- {question} ---");
        TimeToStart();
        Console.WriteLine("");
        // this is where we are going to apply the real logic 
        int i=0;
         while(DateTime.Now<endTime){
          Console.Write("> ");
          Console.ReadLine();
          i++;
         }
         Console.WriteLine($"You listed {i} itmes!");
         Console.WriteLine("");
         Console.WriteLine("");
         WellDone();
         Spinning();
         FinishMessage(duration,_listing);
         Spinning();
         Console.Clear();
        
    }
    }