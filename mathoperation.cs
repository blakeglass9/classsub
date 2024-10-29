using System;

namespace MathApp
{
    // Static class to hold mathematical operations
    public static class MathOperations
    {
        // Method that divides an integer by 2 and outputs the result as an integer
        public static void DivideByTwo(int input, out int result)
        {
            result = input / 2;  // Divide the input by 2 and set the output parameter
        }

        // Overloaded DivideByTwo method for double type input
        public static void DivideByTwo(double input, out double result)
        {
            result = input / 2.0;  // Divide the input by 2.0 and set the output parameter
        }

        // Method with an output parameter that adds 5 to the input and outputs the result
        public static void AddFive(int input, out int result)
        {
            result = input + 5;  // Add 5 to the input and set the output parameter
        }
    }
}
