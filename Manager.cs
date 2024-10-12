using System;
 
namespace ConsoleApp1.Exam
{
    // Inheritance Example
    public class Employee
    {
        public string Name { get; } // No nullable type
        public decimal Salary { get; }
 
        public Employee(string name, decimal salary) // No nullable type
        {
            Name = name;
            Salary = salary;
        }
 
        public virtual void Work()
        {
            Console.WriteLine($"{Name} is working...");
        }
 
        public override string ToString()
        {
            return $"{Name} is working...";
        }
    }
 
    // Developer class extending Employee (Inheritance example)
    public class Developer : Employee
    {
        private string[] _skills; // Declare without initialization
 
        public Developer(string name, decimal salary, string[] skills = null) // No nullable type
            : base(name, salary)
        {
            _skills = skills ?? new string[0]; // Initialize with an empty array if null
        }
 
        public override void Work()
        {
            Console.WriteLine($"Developer {Name} is coding.");
        }
 
        public override string ToString()
        {
            return $"Developer {Name} is coding. Knows {string.Join(", ", _skills)}";
        }
    }
 
    public class Manager : Employee
    {
        public int TeamSize { get; }
 
        public Manager(string name, decimal salary, int teamSize) // No nullable type
            : base(name, salary)
        {
            TeamSize = teamSize;
        }
 
        public override void Work()
        {
            Console.WriteLine($"{Name} is managing a team of {TeamSize} members.");
        }
 
        public override string ToString()
        {
            return $"{Name} is managing a team of {TeamSize} members.";
        }
    }
 
    public class Program
    {
        public static void Main(string[] args)
        {
            Developer dev = new Developer("Alice", 60000, new[] { "C#", "Java", "SQL" });
            Manager mgr = new Manager("Bob", 80000, 5);
 
            dev.Work();
            Console.WriteLine(dev.ToString());
 
            mgr.Work();
            Console.WriteLine(mgr.ToString());
        }
    }
}

