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
            int select = int.Parse(Console.ReadLine());
            
        }
    }
}