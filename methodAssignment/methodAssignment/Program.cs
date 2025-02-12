namespace Math
{
    class Program
    {
        static void Main()
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Ask the user to input the first number
            Console.WriteLine("Enter the first number:");

            // Read the first number and convert it to an integer
            int userInput1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to input the second number
            Console.WriteLine("Enter the second number (or press Enter to leave it empty):");

            // Read the second input, but check if it's empty
            string userInput2 = Console.ReadLine();

            // Convert the second input to an integer, if it's not empty
            int userInput2Int = string.IsNullOrEmpty(userInput2) ? 0 : Convert.ToInt32(userInput2);

            // Call the method, passing both numbers (the second number will default to 0 if it's empty)
            int result = mathOps.PerformOperation(userInput1, userInput2Int);

            // Display the result to the user
            Console.WriteLine($"The result of the operation is: {result}");
        }
    }
}