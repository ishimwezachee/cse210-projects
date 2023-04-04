using System;
using System.IO;
using System.Collections.Generic;
namespace schoolLibrary
{
    class Program
{
    static void Main(string[] args)
    {
        int n = - 1;

        while(n!=7){
            Console.WriteLine("Welcome to school Library App!");
            Console.WriteLine("");
            Console.WriteLine("Please choose an option by enterin a number:");
            Console.WriteLine("1 - List all books");
            Console.WriteLine("2 - List all people");
            Console.WriteLine("3 - Create a person");
            Console.WriteLine("4 - Create a book");
            Console.WriteLine("5 - Create a rental");
            Console.WriteLine("6 - List all rentals for a given person id");
            Console.WriteLine("7 - Exit");
            n = int.Parse(Console.ReadLine());
            // create instances 
            Student student = new Student();
            Teacher teacher = new Teacher();
            Book book = new Book();
            Person person = new Person();
            rentals rental = new rentals();
            // Activity activity = new Activity();

            if(n == 1)
            {
                // list_all_books
                book.list_all_books();
            }else if(n == 2)
            {
                // list_all_people
                person.list_all_people();
                
            }else if(n == 3)
            {
                // create_person: if 1: create student, 2: create teacher
                Console.WriteLine("Do you want to create a student (1) or a teacher (2)? [input the number]: ");
                 int num = int.Parse(Console.ReadLine());
                if(num == 1){
                    // create student: create_student method 
                    student.create_student();
                }else if(num == 2){
                    // create teacher : create_teacher metod 
                    teacher.create_teacher();
                }
                // create a person : student & teacher 
            }
            else if(n == 4)
            {
                // create_book
                book.create_book(n);
            }
            else if(n == 5)
            {
                // create_rental
                rental.create_rentals();
            }
            else if(n == 6)
            {
                // list_rentals
                Console.WriteLine("Selected Six");
            }
            else if(n == 7)
            {
                Console.WriteLine("Selected seven");
            }
        }
    }


}
}


/*
I have exceeded the requirements by validating the names by using Regular expressions
*/