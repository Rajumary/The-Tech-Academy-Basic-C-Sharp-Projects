class Program
{
    static void Main()
    {
        // Step 1: Create a list of integers
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // Step 2: Ask the user for a number to divide by
        Console.WriteLine("Please enter a number to divide each number in the list by:");

        // Step 3: Try to read and convert the user input
        try
        {
            // Read the user's input as a string and try to convert it to an integer
            int divisor = Convert.ToInt32(Console.ReadLine());

            // Step 4: Loop through each number in the list
            foreach (int number in numbers)
            {
                // Divide each number by the user input and display the result
                // If the divisor is zero, this will cause a DivideByZeroException
                Console.WriteLine($"{number} ÷ {divisor} = {number / divisor}");
            }
        }
        // Step 5: Handle different exceptions that might occur
        catch (DivideByZeroException ex)
        {
            // If the user tries to divide by zero, this block will be executed
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (FormatException ex)
        {
            // If the user enters a non-numeric value (e.g., a string), this block will be executed
            Console.WriteLine("Error: Please enter a valid number.");
        }
        catch (Exception ex)
        {
            // This will catch any other exceptions that might occur
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
        finally
        {
            // Step 6: Display a message indicating that the program has moved past the try/catch block
            Console.WriteLine("\nProgram execution continues beyond the try/catch block.");
        }
    }
}