using System;
 
namespace ConsoleApp1.Exam
{
    public class Circle
    {
        public double Radius { get; set; }
 
        
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2); 
        }
 
        
        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius; 
        }
    }
 
    
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(); 
            circle.Radius = 5; 
 
            
            Console.WriteLine($"Circle with radius {circle.Radius}:");
            Console.WriteLine($"Area: {circle.GetArea()}");
            Console.WriteLine($"Perimeter: {circle.GetPerimeter()}");
        }
    }
}







