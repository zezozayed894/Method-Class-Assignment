using System;

namespace MathOperationApp
{
    // Create a class that will contain our method
    class MathOperations
    {
        // Create a void method that takes two integers as parameters
        public void DoMath(int num1, int num2)
        {
            // Perform a math operation on the first integer
            int result = num1 * 2;

            // Display the result of the math operation
            Console.WriteLine("Result of math operation on first number: " + result);

            // Display the second integer to the screen
            Console.WriteLine("Second number is: " + num2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate (create an object of) the MathOperations class
            MathOperations mathObj = new MathOperations();

            // Call the method using positional parameters (normal way)
            mathObj.DoMath(5, 10);

            Console.WriteLine(); // Just adds a blank line for readability

            // Call the method again, this time using named parameters
            mathObj.DoMath(num1: 7, num2: 20);

            // Keep the console window open so we can see the output
            Console.ReadLine();
        }
    }
}