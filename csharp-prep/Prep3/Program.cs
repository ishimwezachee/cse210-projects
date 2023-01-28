using System;

class Program
{
    static void Main(string[] args)
    {
        // use while loop 
         // ask user the magic number 
        // Console.Write("What is the magic number:");
        // int magicNum = int.Parse(Console.ReadLine());

        // generate a random number 
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101); 
        int guess = -1;
        int i = 0;
        string ans = "";

        while(guess != magicNum)
        {
        if(i==5)
        {
            Console.WriteLine("You've excided the number of guess");
            Console.Write("do you want to proceed yes or no: ");
            ans = Console.ReadLine();
            if(ans=="yes")
            {
                i=0;
                magicNum = randomGenerator.Next(1, 101); 
            }
            else
            {
               break;
            }
            
        }
        // Ask for user the guess 
        Console.Write("What is your guess?");

        

        guess = int.Parse(Console.ReadLine());
        i = i + 1;

        if(guess == magicNum)
        {
            Console.WriteLine("You guessed it!");
        }else if(guess>magicNum)
        {
            Console.WriteLine("Lower");
        }else
        {
            Console.WriteLine("Higher");
        }
        }
    }
}