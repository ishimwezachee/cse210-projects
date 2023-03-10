using System;

    public class ReflectingActivity:Activity {
        // attributes 
        private string _reflection = "Reflecting"; 
        private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        // constructors 
        // methods 

        public string randomQuestions(){
            // List<string> reflectingQuestions = new List<string>();
            // reflectingQuestions.Add("Think of a time when you stood up for someone else.");
            // reflectingQuestions.Add("Think of a time when you did something really difficult.");
            // reflectingQuestions.Add("Think of a time when you helped someone in need.");
            // reflectingQuestions.Add("Think of a time when you did something truly selfless.");
            // Random rand = new Random();
            // int index = rand.Next(reflectingQuestions.Count);
            // return reflectingQuestions[index];

            string filePath = "randomQuestions.txt";
            string[] lines = File.ReadAllLines(filePath);
            List<string> reflectingQuestions = lines.ToList();
            Random rand = new Random();
            int index = rand.Next(reflectingQuestions.Count);
            return reflectingQuestions[index];
        }
        public string PonderReply(){
            // List<string> reflectReply = new List<string>();
            // reflectReply.Add("Why was this experience meaningful to you?");
            // reflectReply.Add("Have you ever done anything like this before?");
            // reflectReply.Add("How did you get started?");
            // reflectReply.Add("How did you feel when it was complete?");
            // reflectReply.Add("What made this time different than other times when you were not as successful?");
            // reflectReply.Add("What is your favorite thing about this experience?");
            // reflectReply.Add("What could you learn from this experience that applies to other situations?");
            // reflectReply.Add("What did you learn about yourself through this experience?");
            // reflectReply.Add("How can you keep this experience in mind in the future?");
            
            string filePath = "reflectReply.txt";
            string[] lines = File.ReadAllLines(filePath);
            List<string> reflectReply = lines.ToList();
            Random rand = new Random();
            int index = rand.Next(reflectReply.Count);
            return reflectReply[index];
        }
        public void exprienceAswering(){}
        public void ReflectionActivity(){
            Console.Clear();
            Console.WriteLine(StartMessage(_reflection));
            Console.WriteLine("");
            Console.WriteLine(_description);
            Console.WriteLine("");
            int duration = HowLongTimer();
            Console.Clear();
            Console.WriteLine("Get ready...");
            Spinning();
            Console.WriteLine("");
            // logic for reflecting ...
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(duration);
            while(DateTime.Now<endTime){
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine("");
            // function that provide random questions  
            string question = randomQuestions();
            Console.WriteLine($"--- {question} ---");
            Console.WriteLine("");
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            // Stopped on this function .................................
            TimeToStart();
            Console.Clear();
            // quesion 1
            string questionReply = PonderReply();
            Console.Write($"> {questionReply} ");
            Spinning();
            // quesion 2
            Console.WriteLine("");
            string questionReply2 = PonderReply();
            Console.Write($"> {questionReply2} ");
            Spinning();
            } 
            Console.WriteLine("");
            Console.WriteLine("");
            WellDone();
            Spinning();
            FinishMessage(duration,_reflection);
            Spinning();
            Console.Clear();
        }

       

    }