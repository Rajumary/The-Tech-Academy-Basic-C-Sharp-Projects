class Program
{
    static void Main(string[] args)
    {
        // Ask the user to input a number
        Console.Write("Please enter a number: ");
        string userInput = Console.ReadLine();  // Read the user's input as a string

        // Define the path to the text file where the number will be saved
        string filePath = "userNumber.txt";

        try
        {
            // Write the number to the text file
            // We open the file for writing, and if the file already exists, it will overwrite it
            File.WriteAllText(filePath, userInput);

            // Log a confirmation message to the console
            Console.WriteLine("Your number has been saved to the text file.");

            // Now we will read the content of the text file
            string fileContent = File.ReadAllText(filePath);  // Read the entire content of the text file

            // Print the content of the text file (which should be the number entered by the user)
            Console.WriteLine("\nThe content of the text file is: ");
            Console.WriteLine(fileContent);  // Output the content to the console
        }
        catch (Exception ex)
        {
            // If there is an error (like if the file path is invalid or there is a file access issue),
            // it will be caught here, and the error message will be printed
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}