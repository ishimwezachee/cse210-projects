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
            Random rnd = new Random();
            int Id = rnd.Next(1,1000);
            Console.Write("Age: ");
            Age  = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Has parent permission? [Y/N]: ");
            Parent_permission = Console.ReadLine();
            // create a person 
            saveToFile(Name,Age,Parent_permission,Id);
            Console.WriteLine("The teacher is created successflly");
        }
        public void saveToFile(string name, int age,string parent_permission,int id)
        {
            string fileName = "person.txt";
            using (StreamWriter outputFile = new StreamWriter(fileName,true))
            {
                outputFile.WriteLine($"{id})(Student)Name: {name},Age: {age},permission:{parent_permission}");
            }
            Console.WriteLine("Person is created Book successfully");
        }

    }
}