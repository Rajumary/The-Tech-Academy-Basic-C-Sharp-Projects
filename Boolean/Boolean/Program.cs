class Program
{
    static void Main()
    {
        // Ask for the user's age
        Console.Write("What is your age? ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Ask if the user has had a DUI
        Console.Write("Have you ever had a DUI? (yes/no) ");
        string duiResponse = Console.ReadLine().ToLower();
        bool hasDUI = duiResponse == "yes"; // Convert to boolean

        // Ask for the number of speeding tickets
        Console.Write("How many speeding tickets do you have? ");
        int speedingTickets = Convert.ToInt32(Console.ReadLine());

        // Apply qualification rules
        bool qualifies = (age > 15) && !hasDUI && speedingTickets <= 3;

        // Print the result
        if (qualifies)
        {
            Console.WriteLine("You qualify for car insurance.");
        }
        else
        {
            Console.WriteLine("You do not qualify for car insurance.");
        }
    }
}