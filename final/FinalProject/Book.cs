using System;

namespace schoolLibrary
{
    public class Book
    {
        // attributes 
        private string Title {get; set; }
        private string Author {get; set; }
        private string rentals;
        // constructors 
        // Properties 
        // Methods 
        public void add_rentals(){

        }

        public void create_book(int n){
            Console.Write("Title: ");
             Title = Console.ReadLine();
            Console.Write("Name: ");
              Author = Console.ReadLine();
            // Console.Write("Specialization: ");
            // string Specialization = Console.ReadLine();
            // create a person 
            //   Object[] library = {
            //     new { key = "key", value = "value"}};
            List<object> library = new List<object>();
            // library.Add(new { title = Title, author = Author });
            // Console.WriteLine(library[0]);
            saveToFile(Title,Author);;
        }
        public void saveToFile(string title, string author)
        {
            string fileName = "book.txt";
            using (StreamWriter outputFile = new StreamWriter(fileName,true))
            {
                outputFile.WriteLine($" Title: {title},Author: {author}");
            }
        }

        public void list_all_books()
        {
        // display the data from the file `
        string filename = "book.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string fileData = parts[0];
            Console.WriteLine(fileData);
        }
        }


        
            

    }
}