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
        
        // public Person( string name,int age,int id,bool parent_permission)
        // {
        //     Name = name;
        //     Age = age;
        //     Id = id;
        //     Parent_permission = parent_permission;
            
        // }
        // Properties 
        public List<string> createdRentals(){
            rentals = new List<string>();
            return rentals;
        } 
        // Methods 
        public void add_rental(string person){
          rentals.Add(person);
        }
        public virtual string can_use_service(){
             Parent_permission = Age >= 18 ? "Y" : "N";
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
        public void list_all_people(){
            Console.WriteLine("The lists of people");
        }
    }
}