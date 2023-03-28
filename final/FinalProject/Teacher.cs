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
        public override bool can_use_service()
        {
            return true;
        }
        public void create_teacher(){
            Console.WriteLine("Teacher is created");
        }
    }
}