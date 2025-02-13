namespace MathApp
{
    class Program
    {
        static void Main()
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Ask the user to input two numbers
            Console.WriteLine("Enter the first number (integer):");
            int userInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number (integer):");
            int userInput2 = Convert.ToInt32(Console.ReadLine());

            // Call the PerformOperation method using positional parameters
            mathOps.PerformOperation(userInput1, userInput2);

            // Call the PerformOperation method using named parameters
            mathOps.PerformOperation(number1: 10, number2: 5);
        }
    }
}