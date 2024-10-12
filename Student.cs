using System;
using System.Collections.Generic;
 
namespace ConsoleApp1.Exam
{
    public class Student
    {
        public string StudentName { get; }  
        public List<Course> Courses { get; set; } = new List<Course>(); // Initialize the list
 
        public Student(string name) 
        {
            StudentName = name;
        }
 
        public void Enroll(Course course)
        {
            Courses.Add(course);
        }
 
        public void ShowCourses()
        {
            Console.WriteLine($"{StudentName} is enrolled in the following courses:");
            foreach (var course in Courses)
            {
                Console.WriteLine($"- {course.CourseName}");
            }
        }
    }
 
    // Association (Student - Course)
    public class Course
    {
        public string CourseName { get; } // Property for course name
 
        public Course(string name) // Change to non-nullable string
        {
            CourseName = name; // Assume name is provided and is not null
        }
    }
 
    // Main program class to test the functionality
    class Program
    {
        static void Main(string[] args)
        {
            // Create a student
            Student student = new Student("Alice");
 
            // Create courses
            Course math = new Course("Mathematics");
            Course science = new Course("Science");
 
            // Enroll student in courses
            student.Enroll(math);
            student.Enroll(science);
 
            // Show enrolled courses
            student.ShowCourses();
        }
    }
}

