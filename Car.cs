using System;
 
namespace ConsoleApp1.Exam
{
    public class Car
    {
        private readonly Engine _engine; // Composition: Car has an Engine
        public bool IsEngineStarted { get; private set; } = false; // Property to track engine status
 
        // Constructor for Car, takes an Engine instance
        public Car(Engine engine)
        {
            _engine = engine; // Assign the Engine instance to the private field
        }
 
        // Method to start the car
        public void StartCar()
        {
            if (!IsEngineStarted) // Check if the engine is already started
            {
                _engine.Start(); // Start the engine
                IsEngineStarted = true; // Update the property to indicate the engine has started
                Console.WriteLine("Car started.");
            }
            else
            {
                Console.WriteLine("Engine is already running.");
            }
        }
 
        // Method to stop the car
        public void StopCar()
        {
            if (IsEngineStarted) // Check if the engine is running
            {
                _engine.Stop(); // Stop the engine (assuming you add this method in Engine)
                IsEngineStarted = false; // Update the property
                Console.WriteLine("Car stopped.");
            }
            else
            {
                Console.WriteLine("Engine is not running.");
            }
        }
    }
 
    // Engine class
    public class Engine
    {
        // Method to start the engine
        public void Start()
        {
            Console.WriteLine("Engine started.");
        }
 
        // Method to stop the engine
        public void Stop()
        {
            Console.WriteLine("Engine stopped.");
        }
    }
 
    // Main program class to test Car and Engine classes
    class Program
    {
        static void Main(string[] args)
        {
            Engine carEngine = new Engine(); // Create an instance of Engine
            Car myCar = new Car(carEngine); // Create a Car instance with the Engine
 
            myCar.StartCar(); // Start the car
            myCar.StartCar(); // Attempt to start the car again
            myCar.StopCar(); // Stop the car
            myCar.StopCar(); // Attempt to stop the car again
        }
    }
}





