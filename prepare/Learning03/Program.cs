using System;

class Program
{
    static void Main(string[] args)
    {
        // where we are supposed to call our functions 
       // instantiate a fraction 
       Fractions f1 =  new Fractions();
       Fractions f2 = new Fractions(6);
       Fractions f3 = new Fractions(6,7);
       Console.WriteLine(f1.GetFractionString(f1.GetTopNumber(),f1.GetBottomNumber()));
       Console.WriteLine(f1.GetFractionString(f1.GetTopNumber(),f1.GetBottomNumber()));
              Console.WriteLine(f1.GetFractionString(f1.GetTopNumber(),f1.GetBottomNumber()));
    //    Console.WriteLine(f2.GetBottomNumber());
    //    Console.WriteLine(f3.GetBottomNumber());
    }
}