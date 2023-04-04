using System;

namespace schoolLibrary
{
    public class rentals
    {
        // attributes 
        private string person;
        private string book;
        private string date;
        // constructors 
        // Properties 
        // Methods 
        public void create_rentals()
        {
            Console.WriteLine("Select a book from the following list by number");
            Book book = new Book();
            book.list_all_books(); 
              Console.WriteLine("Enter a book number:");
            string input = Console.ReadLine();
        string[] books = File.ReadAllLines("book.txt");
        string selectedBook = "";
        foreach (string elem in books) {
            if (elem.StartsWith(" "+input)) {
                selectedBook = elem;
                break;
            }
        }

         if (selectedBook != "") {
            List<string> selectedBooks = new List<string>();
            selectedBooks.Add(selectedBook);
            Console.WriteLine("Book selected:" + selectedBook);
            // Write a function that will list all persons that we have
            
        }
        else {
            Console.WriteLine("Book not found.");
        }
        }
    }
}