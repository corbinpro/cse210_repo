using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._JobTitle = "Software Developer";
        job1._company = "Minecraft";
        job1._startYear = 2010;
        job1._endYear = 2015;

        Job job2 = new Job();
        job2._JobTitle = "Software Engineer";
        job2._company = "Haas";
        job2._startYear = 2015;
        job2._endYear = 2020;

        Resume resume = new Resume();
        resume._name = "Corbin Probasco";
        resume.AddJob(job1);
        resume.AddJob(job2);
        resume.Display();

    }

    public class Job
    {
        public string _JobTitle;
        public string _company;
        public int _startYear;
        public int _endYear;
        public void Display()
        {
            Console.WriteLine($"{_JobTitle} at {_company} from {_startYear} to {_endYear}");
        }
    } 

    public class Resume
    {
        public string _name;
        public List <Job> _jobs = new List<Job>();
        public void AddJob(Job job)
        {
            _jobs.Add(job);
        }
        public void Display()
        {
            Console.WriteLine($"Name: {_name}" + "\n"+ "Jobs: ");
            foreach (Job job in _jobs)
            {
                job.Display();
            }
        }
    }   
}