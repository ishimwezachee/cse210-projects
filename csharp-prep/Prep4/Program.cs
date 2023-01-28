using System;

class Program
{
    static void Main(string[] args)
    {
        // declar an empty array 
         int average = 0;
         int max = 0;
        List<int> numbers = new List<int>();
        Console.WriteLine(numbers.Count);
        int i = -1;
        while(i!=0)
        {   Console.WriteLine("Add a number:");
            i = int.Parse(Console.ReadLine());
            numbers.Add(i);
        }
        for (int j = 0; i < numbers.Count; j++)
        {
            average += numbers[j];
            if(max < numbers[j])
            {
                max = numbers[j];
            }
            
    }
    Console.WriteLine($"The average is : {average/numbers.Count}");
    Console.WriteLine($"The max is : {max}");
    }
}