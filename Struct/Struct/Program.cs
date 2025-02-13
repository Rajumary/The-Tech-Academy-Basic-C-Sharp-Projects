// Define a struct called Number
public struct Number
{
    // Define a property called Amount of type decimal
    public decimal Amount { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of type Number
        Number mynumber;

        // Assign a value to the Amount property of the myNumber object

        mynumber.Amount = 50.75m;  // The 'm' suffix indicates the value is a decimal

        // Print the Amount to the console
        Console.WriteLine("The amount is: " + mynumber.Amount); // Display the Amount property of the myNumber object
    }
}