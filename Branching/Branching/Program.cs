class Program
{
    static void Main()
    {
        // Display the welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt for the package weight
        Console.Write("Please enter the package weight (in pounds): ");
        double weight = double.Parse(Console.ReadLine());

        // If the weight is greater than 50, display an error and end the program
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Exit the program
        }

        // Prompt for the package dimensions (width, height, length)
        Console.Write("Please enter the package width (in inches): ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Please enter the package height (in inches): ");
        double height = double.Parse(Console.ReadLine());

        Console.Write("Please enter the package length (in inches): ");
        double length = double.Parse(Console.ReadLine());

        // If the total of the dimensions is greater than 50, display an error and end the program
        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Exit the program
        }

        // Calculate the quote using the formula: (height * width * length * weight) / 100
        double quote = (height * width * length * weight) / 100;

        // Display the quote to the user
        Console.WriteLine($"The shipping quote for your package is: ${quote:F2}");
    }
}