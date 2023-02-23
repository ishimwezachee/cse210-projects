using System;
namespace library_demo
{
class Program
{
    
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.setAuthor("Smith");
        book1.setTitle("A Great BOOK");

        PictureBook book2 = new PictureBook();
        book2.setAuthor("John");
        book2.setTitle("Wonderful pciture Book");
        book2.setIllustrator("Burton");
        
        Console.WriteLine(book2.GetBookInfo());
        Console.WriteLine(book2.GetPictureBookInfo());

        Book book3 = new Book("Edwards","Another book");
        Console.WriteLine(book3.GetBookInfo());

        PictureBook book4 = new PictureBook("new author","new title","new illustrator");

        Console.WriteLine(book4.GetPictureBookInfo());
    }
         
}

}