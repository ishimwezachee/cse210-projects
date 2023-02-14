using System;

class Program
{
    static void Main(string[] args)
    {
        // Journal j = new Journal();
        // Console.WriteLine("Enter a Scripture: ");
        // string input = Console.ReadLine();
        Word word = new Word();
        // Reference reference = new Reference("John",10,9);
        // Reference reference2 = new Reference("John",10,9,20);
        // Console.WriteLine(reference.Book);
        // Console.WriteLine(reference.Chapter);
        // Console.WriteLine(reference.Verse);
        // Console.WriteLine(reference2.EndVerse);
        Scripture scripture = new Scripture();
        scripture.HideWords();
        // scripture.GetDisplayText();
        // scripture.HideWords(input);
        // Console.WriteLine(word.getDisplayText());
    }
}