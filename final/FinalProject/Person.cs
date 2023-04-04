using System;
using System.Text.RegularExpressions;

namespace schoolLibrary
{
    public class Person
    {
        // attributes 
        private List<string> rentals { get; set; }
        protected string Name { get; set; }
        protected int Age { get; set; }
        protected string Parent_permission { get; set; }
        private int Id { get; set; }
        // constructors 
        
        public List<string> createdRentals(){
            rentals = new List<string>();
            return rentals;
        } 
        // Methods 
        public void add_rental(string person){
          rentals.Add(person);
        }
        // public virtual string can_use_service(){
        //      Parent_permission = Age >= 18 ? "Y" : "N";
        //      return Parent_permission;
        // }
        public virtual string validate_name(string name){
            return name;
        }
        public void is_of_age(){}
        public void list_all_people()
        {
        // display the data from the file `
        string filename = "person.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string fileData = parts[0];
            Console.WriteLine(fileData);
        }
        }
    }
}