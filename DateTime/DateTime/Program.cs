class Program
{
    static void Main(string[] args)
    {
        // Step 1: Print the current date and time to the console
        DateTime currentDateTime = DateTime.Now;  // Get the current date and time using DateTime.Now
        Console.WriteLine("Current date and time: " + currentDateTime);  // Display the current date and time

        // Step 2: Ask the user for a number
        Console.Write("Please enter a number of hours to add to the current time: ");
        string userInput = Console.ReadLine();  // Read the user's input as a string

        // Step 3: Convert the user input from string to an integer (for number of hours)
        int hoursToAdd;
        bool isValidInput = int.TryParse(userInput, out hoursToAdd);  // Try to parse the input to an integer

        if (isValidInput)  // Check if the parsing was successful
        {
            // Step 4: Add the user-provided number of hours to the current time
            DateTime futureDateTime = currentDateTime.AddHours(hoursToAdd);  // Add the specified number of hours

            // Step 5: Print the new time after adding the hours to the console
            Console.WriteLine("The time after adding " + hoursToAdd + " hours: " + futureDateTime);
        }
        else
        {
            // If the user input is not a valid number, print an error message
            Console.WriteLine("Please enter a valid number.");
        }
    }
}
