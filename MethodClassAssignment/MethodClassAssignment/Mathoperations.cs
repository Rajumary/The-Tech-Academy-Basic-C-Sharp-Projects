// MathOperations.cs
namespace MathApp
{
    // Define the MathOperations class
    public class MathOperations
    {
        // Method that takes two integers as parameters.
        // The method performs a math operation (multiplication) on the first integer.
        // Then, it displays the second integer to the screen.
        public void PerformOperation(int number1, int number2)
        {
            // Perform a math operation on the first number (multiplying it by 2)
            int result = number1 * 2;

            // Display the result of the operation
            Console.WriteLine($"The result of multiplying {number1} by 2 is: {result}");

            // Display the second integer to the screen
            Console.WriteLine($"The second number entered is: {number2}");
        }
    }
}