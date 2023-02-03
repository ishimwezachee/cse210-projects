using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal Program!");
        Console.WriteLine("");
        Console.WriteLine("Please select one of the following choices:");

        Journal j = new Journal();
        j.DisplayAllEntries();
        PromptGenerator p = new PromptGenerator();
        int input = -1;

        while(input!=5){
        input = p.prompt();
        // Console.WriteLine(input);
        // j.DisplayAllEntries();
        j.AddEntry(input);
        }
  
    }
} 

// Journal class 

class Journal{
    // fields
     public List<Entries> _entries = new List<Entries>();

     // methods 
     public void DisplayAllEntries(){
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("6. Inspirations");
     }
     public void AddEntry(int input){
       Journal j = new Journal();
         if(input == 1){
            // add prompt for writing the data 
            string[] questions = {"Who was the most interesting person I interacted with today?", 
                                "What was the best part of my day?",
                                "What was the strongest emotion I felt today?",
                                "If I had one thing I could do over today, what would it be?",
                                "What am I grateful for today?",
                                "What did I learn today?",
                                "What are my goals for tomorrow?",
                                "How did I handle a difficult situation today?",
                                "What is something that made me happy today?",
                                "What is something that I am looking forward to in the future?",
                                "What did I do for self-care today?",
                                "What did I do to be productive today?",
                                "What am I currently struggling with?",
                                "What are my thoughts and feelings about recent events in my life?"
                                }; 
                                
            Random random = new Random();
            int value = random.Next(0, questions.Length);
            Console.WriteLine(questions[value]);
            // date 
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
           // collect answer from the users 
            string answer = Console.ReadLine();
            // Console.WriteLine(answer);
            j.saveToFile(dateText,answer,questions[value]);
            // send the data into the document 
            j.DisplayAllEntries();
         }else if (input == 2){
            Entries e = new Entries();
            e.Display();
            // Console.WriteLine("Display ");
            // j.DisplayAllEntries();
        }else if (input == 3){
            j.LoadFromFile();
             j.DisplayAllEntries();
        }else if (input == 4){
            Console.WriteLine("What is the file name?");
            string userFileName = Console.ReadLine(); 
            // move the data from previous file and move them to the new file 
            // with a name from the user, then delete the previous file
            // to stay with the file from the user 
            using (StreamWriter outputFile = new StreamWriter(userFileName,true)){

                // function to add the data to file 
                
                 string filename = "default.txt";
                 string[] lines = System.IO.File.ReadAllLines(filename);
                 foreach (string line in lines){
                    string[] parts = line.Split(",");
                    string fileData = parts[0];
                    outputFile.WriteLine(fileData);
                    }
             }

            j.DisplayAllEntries();
            }else if (input == 5){
            Console.WriteLine("Done");
            }else if(input == 6){
            string[] insipiration = {"\nDear Past, thank you for the lessons. Dear Future, I am ready.\n",
                                    "Choose happy.\n",
                                    "There is no such thing as ready. There is only now.\n",
                                    "Some days, you just have to create your own sunshine.\n",
                                    "Great things take time.\n",
                                    "And so the adventure begins.\n",
                                    "It always seems impossible until it’s done. –Nelson Mandela\n",
                                    "Every day is a new beginning.\n",
                                    "Dream one size too big.\n",
                                    "Rejection is mere redirection. Keep working.\n" }; 
                                    foreach (string txt in insipiration){
                                        Console.WriteLine(txt);
                                    }
            }
            else{
            Console.WriteLine("Select The Right number please");
        }
    }
    // and more other methods .....
    public void saveToFile(string dateText,string data,string question){
        string fileName = "default.txt";
      using (StreamWriter outputFile = new StreamWriter(fileName,true)){
    // You can add text to the file with the WriteLine method
    outputFile.WriteLine($"Date: {dateText}- Prompt: {question}\n{data}\n");
}
    }

    public void LoadFromFile(){
        // display the data from the file 
        string filename = "default.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string fileData = parts[0];
            Console.WriteLine(fileData);
        }
        
    }

}


// Entrt class 
class Entries {
    // attributes 
    public string _content;
    // methods 
    public void Display(){
        // display the data from the file 
        string filename = "default.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string fileData = parts[0];
            Console.WriteLine(fileData);
        }
        
    }
}




// Prompt Generator class
class PromptGenerator {
    // field
    public string select;
    // method 
    public int prompt(){
        Console.Write("What would you like to do? ");
        select = Console.ReadLine();
        // Console.WriteLine(select);
        return int.Parse(select);
    }

}


/*
Showing Creativity and Exceeding Requirements:

1. I have added many questions a user can ask him/herself to write the journal 
2. I have added another feature so that user can insipire him/herself to write the journal. (opition six).

*/