using System;

namespace schoolLibrary
{
    public class Student: Person
    {
        // attributes 
         private string classroom { get; set; }
        // constructors 
        // public Student(string classroom,int age,int id,string name,bool parent_permission):base(name,age,id,parent_permission)
        // {
        //     classroom = classroom;
        // }
        // Properties 
        // Methods 
        public void create_student(){
            Console.Write("Age: ");
            Age  = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Has parent permission? [Y/N]: ");
            Parent_permission = Console.ReadLine();
            // create a person 
        }
    }
}