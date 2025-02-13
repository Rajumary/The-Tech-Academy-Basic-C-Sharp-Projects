public enum DaysOfWeek  // Define an enum to represent the days of the week
{
    Sunday,     // Enum values representing each day of the week
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Prompt the user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week:");

            // Read the input from the user
            string userInput = Console.ReadLine();

            // Convert the user input to the DaysOfWeek enum
            // The Enum.TryParse method tries to convert the string to an enum value
            DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);  // 'true' makes the conversion case-insensitive

            // Print the valid enum day entered by the user
            Console.WriteLine($"You entered: {day}");
        }
        catch (ArgumentException)  // Catch the exception if the input cannot be parsed into an enum value
        {
            // Print an error message if the user enters an invalid day
            Console.WriteLine("Please enter an actual day of the week.");
        }
    }
}