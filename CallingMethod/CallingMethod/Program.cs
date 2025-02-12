namespace Math
{
    class Program
    {
        static void Main()
        {
            // Ask the user to input a number
            Console.WriteLine("Please enter a number:");

            // Read the user's input and convert it to an integer
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Create an instance of the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the AddTen method and display the result
            int resultAddTen = mathOps.AddTen(userInput);
            Console.WriteLine($"Add 10 to your number: {resultAddTen}");

            // Call the MultiplyByTwo method and display the result
            int resultMultiplyByTwo = mathOps.MultiplyByTwo(userInput);
            Console.WriteLine($"Multiply your number by 2: {resultMultiplyByTwo}");

            // Call the SubtractFive method and display the result
            int resultSubtractFive = mathOps.SubtractFive(userInput);
            Console.WriteLine($"Subtract 5 from your number: {resultSubtractFive}");
        }
    }
}