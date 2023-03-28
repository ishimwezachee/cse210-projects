using System;
using System.Text.RegularExpressions;

namespace schoolLibrary
{
    public class Person
    {
        // attributes 
        private List<string> rentals { get; set; }
        private string Name { get; set; }
        private int Age { get; set; }
        private bool Parent_permission { get; set; }
        private int Id { get; set; }
        // constructors 
        public Person( string name,int age,int id,bool parent_permission)
        {
            Name = name;
            Age = age;
            Id = id;
            Parent_permission = parent_permission;
            rentals = new List<string>();
        }
        // Properties 
        // Methods 
        public void add_rental(string person){
          rentals.Add(person);
        }
        public virtual bool can_use_service(){
             Parent_permission = Age >= 18 ? true : false;
             return Parent_permission;
        }
        public string validate_name(){
            Regex regex = new Regex(@"^[a-zA-Z]+$");
            if(regex.IsMatch(Name)){
                return Name;
            }else{
                Console.WriteLine("Please add a valid name");
                return "Please add a valid name";
            }
        }
        public void is_of_age(){}
    }
}