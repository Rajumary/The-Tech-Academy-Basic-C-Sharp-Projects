namespace MathApp
{
    class Program
    {
        static void Main()
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the first method with an integer input
            Console.WriteLine("Enter an integer number:");
            int userInputInt = Convert.ToInt32(Console.ReadLine());
            int resultInt = mathOps.PerformOperation(userInputInt);  // Call method for integer
            Console.WriteLine($"Result from integer input: {resultInt}");

            // Call the second method with a decimal input
            Console.WriteLine("Enter a decimal number:");
            decimal userInputDecimal = Convert.ToDecimal(Console.ReadLine());
            int resultDecimal = mathOps.PerformOperation(userInputDecimal);  // Call method for decimal
            Console.WriteLine($"Result from decimal input: {resultDecimal}");

            // Call the third method with a string input
            Console.WriteLine("Enter a string representing an integer:");
            string userInputString = Console.ReadLine();
            int resultString = mathOps.PerformOperation(userInputString);  // Call method for string
            Console.WriteLine($"Result from string input: {resultString}");
        }
    }
}