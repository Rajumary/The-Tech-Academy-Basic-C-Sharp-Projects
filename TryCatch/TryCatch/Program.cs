class Program
{
    static void Main()
    {
        // Step 1: Ask the user for their age
        // This prompts the user to enter their age and stores it in the 'age' variable.
        Console.Write("Please enter your age: ");

        try
        {
            // Step 2: Read the user input and try to convert it to an integer
            // 'age' will store the value entered by the user, and it will be parsed as an integer.
            int age = int.Parse(Console.ReadLine());

            // Step 3: Check for valid age input (positive number only)
            // If the user enters 0 or a negative number, this will handle that case specifically.
            if (age <= 0)
            {
                // Throw a custom exception if age is zero or negative
                throw new ArgumentOutOfRangeException("Age must be a positive number.");
            }

            // Step 4: Calculate the year the user was born
            // We subtract the age from the current year (using DateTime.Now.Year) to calculate the birth year.
            int currentYear = DateTime.Now.Year;
            int birthYear = currentYear - age;

            // Step 5: Display the year the user was born
            Console.WriteLine($"You were born in the year {birthYear}.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            // Step 6: Handle specific case when user enters a zero or negative number
            // If the user enters an invalid age (zero or negative), this block will handle the exception.
            Console.WriteLine(ex.Message);  // Print the message from the ArgumentOutOfRangeException.
        }
        catch (FormatException)
        {
            // Step 7: Handle the case where the user does not enter a valid number (e.g., enters text)
            // If the user enters something that cannot be converted to an integer, this exception is caught.
            Console.WriteLine("Please enter a valid number for your age.");
        }
        catch (Exception ex)
        {
            // Step 8: Catch any other unhandled exceptions
            // This general catch block will display a message for any unexpected errors.
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}