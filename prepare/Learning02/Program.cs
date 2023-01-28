using System;

class Program
{
    static void Main(string[] args)
    {
        // we call insttance in main 
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

       // instance two 
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
       // add/append jobs we have to our list. 
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

  
    }

}

  public class Job{
            //attributes 
            public string _company;
            public string _jobTitle;
            public int _startYear;
            public int _endYear;
            // constructor 
            public Job()
            {

            }
            // methods 
            public void Display(){
                Console.WriteLine($"Software Engineer {_company} {_startYear}-{_endYear}");
            }
    
    }
    public class Resume
    {
    public string _name;

    // Make sure to initialize your list to a new List before you use it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.Display();
        }
    }
}
