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
            saveToFile(Name,Age,Specialization);
        }

        public void saveToFile(string name, int age,string Specialization)
        {
            string fileName = "person.txt";
            using (StreamWriter outputFile = new StreamWriter(fileName,true))
            {
                outputFile.WriteLine($"(Teacher) Name: {name},Age: {age},Specialization:{Specialization}");
            }
        }
    }
}