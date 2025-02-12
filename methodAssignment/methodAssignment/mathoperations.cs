namespace Math
{
    // Define the MathOperations class
    public class MathOperations
    {
        // Method that takes two integers, with the second integer being optional.
        // The second parameter has a default value of 0.
        public int PerformOperation(int number1, int number2 = 0)
        {
            // Perform an addition operation by default (number1 + number2)
            // If the second number is not provided, it will default to 0, so it will just return number1.
            return number1 + number2;
        }
    }
}