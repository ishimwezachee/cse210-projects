using System;
using System.Text.RegularExpressions;
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
        public override string validate_name(string name){
            Regex regex = new Regex(@"^[a-zA-Z]+$");
            if(regex.IsMatch(name)){
                return name;
            }else{
                Console.WriteLine("Please add a valid name");
                return "Please add a valid name";
            }
        }
        public void create_teacher(){
            Random rnd = new Random();
            int Id = rnd.Next(1,1000);
            Console.Write("Age: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            Name = validate_name(Console.ReadLine());
            Console.Write("Specialization: ");
            string Specialization = Console.ReadLine();
            // create a person 
            saveToFile(Name,Age,Specialization,Id);
            Console.WriteLine("The teacher is created successflly");
        }

        public void saveToFile(string name, int age,string Specialization,int id)
        {
            string fileName = "person.txt";
            using (StreamWriter outputFile = new StreamWriter(fileName,true))
            {
                outputFile.WriteLine($"{id}.(Teacher)Name: {name},Age: {age},Specialization:{Specialization}");
            }
        }
    }
}