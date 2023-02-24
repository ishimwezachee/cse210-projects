using System;

    public class ReflectingActivity:Activity {
        private string _reflection = "Reflecting"; 
        private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        // constructors 
        // methods 

        public string randomQuestions(){
            List<string> reflectingQuestions = new List<string>();
            reflectingQuestions.Add("Think of a time when you stood up for someone else.");
            reflectingQuestions.Add("Think of a time when you did something really difficult.");
            reflectingQuestions.Add("Think of a time when you helped someone in need.");
            reflectingQuestions.Add("Think of a time when you did something truly selfless.");
            Random rand = new Random();
            int index = rand.Next(reflectingQuestions.Count);
            return reflectingQuestions[index];
        }
        public void PonderQuestion(){
            Console.Write($"You may begin in..."); 
            for( int i = 5; i>0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

        }
        public void exprienceAswering(){}
        public void reflection(){
            Console.WriteLine(StartMessage(_reflection));
            Console.WriteLine("");
            Console.WriteLine(_description);
            Console.WriteLine("");
            int duration = HowLongTimer();
            Console.WriteLine(duration);
            Console.Clear();
            Console.WriteLine("Get ready...");
            Spinning();
            Console.WriteLine("");
            // logic for reflecting ...
            Console.WriteLine("Consider the following prompt:");
            // function that provide random questions  
            string question = randomQuestions();
            Console.WriteLine($"--- {question} ---");
            Console.WriteLine("");
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            // Stopped on this function .................................
            PonderQuestion();


        }

       

    }