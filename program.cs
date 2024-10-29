using System;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a number
            Console.WriteLine("Enter a number to perform operations on:");
            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Please enter a valid integer.");
            }

            // Call DivideByTwo method for integer and display the result
            MathOperations.DivideByTwo(userInput, out int resultInt);
            Console.WriteLine($"Half of {userInput} is: {resultInt}");

            // Call overloaded DivideByTwo method for double type and display the result
            double userDouble = Convert.ToDouble(userInput);
            MathOperations.DivideByTwo(userDouble, out double resultDouble);
            Console.WriteLine($"Half of {userDouble} as a double is: {resultDouble}");

            // Call AddFive method and display the result
            MathOperations.AddFive(userInput, out int resultAdd);
            Console.WriteLine($"{userInput} plus 5 is: {resultAdd}");

            // Pause to allow the user to see the output
            Console.ReadKey();
        }
    }
}
