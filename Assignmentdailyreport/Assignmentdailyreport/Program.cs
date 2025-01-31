class Program
{
    static void Main()
    {
        // Print the first line to the console
        Console.WriteLine("Academy of Learning Career College");

        // Print the second line to the console
        Console.WriteLine("Student Daily Report.");

        // Declare and prompt the user for their name
        Console.Write("What is your name? ");
        string studentName = Console.ReadLine(); // Stores the user's input as a string

        // Declare and prompt the user for their course
        Console.Write("What course are you on? ");
        string courseName = Console.ReadLine(); // Stores the user's input as a string

        // Declare and prompt the user for the page number
        Console.Write("What page number? ");
        int pageNumber = Convert.ToInt32(Console.ReadLine()); // Converts the input string to an integer

        // Declare and prompt the user whether they need help or not
        Console.Write("Do you need help with anything? Please answer 'true' or 'false': ");
        bool needsHelp = Convert.ToBoolean(Console.ReadLine()); // Converts the input string to a boolean value

        // Declare and prompt the user for positive experiences
        Console.Write("Were there any positive experiences you’d like to share? Please give specifics: ");
        string positiveExperiences = Console.ReadLine(); // Stores the user's input as a string

        // Declare and prompt the user for other feedback
        Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
        string additionalFeedback = Console.ReadLine(); // Stores the user's input as a string

        // Declare and prompt the user for the number of hours studied
        Console.Write("How many hours did you study today? ");
        int studyHours = Convert.ToInt32(Console.ReadLine()); // Converts the input string to an integer

        // Print the final thank you message
        Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
    }
}