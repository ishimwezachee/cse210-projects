using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's do some simple practice...");
        // count down timer ....
        // Console.WriteLine(5);
        // Thread.Sleep(1000);
        // Console.WriteLine(4);
        // Thread.Sleep(1000);
        // Console.WriteLine(3);
        // Thread.Sleep(1000);
        // Console.WriteLine(2);
        // Thread.Sleep(1000);
        // Console.WriteLine(1);
        // Thread.Sleep(1000);

       // Number timer ...

        // for( int i = 5; i>0; i--)
        // {
        //     Console.Write(i);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        // }

        // for( int i = 5; i>0; i--)
        // {
        //     Console.Write(".");
        //     Thread.Sleep(1000);
        //     // Console.Write("\b \b");
        // }

        // |/-\|/-\|

        // Let us create a list that will help us to spin 


        List<string> animationsString = new List<string>();
        animationsString.Add("|");
        animationsString.Add("/");
        animationsString.Add("-");
        animationsString.Add("\\");
        animationsString.Add("|");
        animationsString.Add("/");
        animationsString.Add("-");
        animationsString.Add("\\");

        // foreach (string s in animationsString)
        // {
        //     Console.Write(s);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        // }

        // We are going to make it spin for 8 second 

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

        int i = 0;

        while(DateTime.Now < endTime){
            string s = animationsString[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i>= animationsString.Count)
            {
                i = 0;
            }
        }



        Console.WriteLine("Done.");
    }
}