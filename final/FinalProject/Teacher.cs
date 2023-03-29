using System;

namespace schoolLibrary
{
    public class Teacher: Person
    {
        // attributes 
        // constructors 

        // public Teacher(string classroom,int age,int id,string name,bool parent_permission):base(name,age,id,parent_permission)
        // {
        //     classroom = classroom;
        // }
        
        // Properties 
        // Methods 
        public override string can_use_service()
        {
            return "Y";
        }
        public void create_teacher(){
            Console.Write("Age: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Specialization: ");
            string Specialization = Console.ReadLine();
            // create a person 
        }
    }
}