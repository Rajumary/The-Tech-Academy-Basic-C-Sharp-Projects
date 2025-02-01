class Program
{
    static void Main()
    {
        bool condition = true;  // Boolean variable

        // Using a while loop for boolean comparison
        while (condition)
        {
            Console.WriteLine("Condition is true in the while loop.");
            // Change the condition to false after one iteration to prevent an infinite loop
            condition = false;
        }

        Console.WriteLine("Exited while loop.");

        do
        {
            Console.WriteLine("Condition is true in the do-while loop.");
            // Change the condition to false after one iteration to prevent an infinite loop
            condition = false;
        }
        while (condition);

        Console.WriteLine("Exited do-while loop.");
    }
}