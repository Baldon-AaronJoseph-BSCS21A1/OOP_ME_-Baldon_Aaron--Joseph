using System;
 
namespace ConsoleApp1.Exam
{
    // Interface for shapes
    public interface IShape
    {
        double GetArea();
        double GetPerimeter();
    }
 
    // Rectangle class implementing IShape
    public class Rectangle : IShape
    {
        // Properties for length and width
        public double Length { get; set; }
        public double Width { get; set; }
 
        // Constructor to initialize length and width
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
 
        // Method to calculate area
        public double GetArea()
        {
            return Length * Width; // Area = length * width
        }
 
        // Method to calculate perimeter
        public double GetPerimeter()
        {
            return 2 * (Length + Width); // Perimeter = 2 * (length + width)
        }
    }
 
    // Triangle class implementing IShape
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
 
        // Constructor to initialize sides
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
 
        
        public double GetArea()
        {
            double semiPerimeter = GetPerimeter() / 2; // Calculate semi-perimeter
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC)); // Area
        }
 
        // Method to calculate perimeter
        public double GetPerimeter()
        {
            return SideA + SideB + SideC; // Perimeter = A + B + C
        }
    }
 
    
    class Program
    {
        static void Main(string[] args)
        {
            
            Rectangle rectangle = new Rectangle(5, 3);
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
            Console.WriteLine($"Rectangle Perimeter: {rectangle.GetPerimeter()}");
 
            
            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine($"Triangle Area: {triangle.GetArea()}");
            Console.WriteLine($"Triangle Perimeter: {triangle.GetPerimeter()}");
        }
    }
}





