class Program
{
    static void Main()
    {
        // Step 1: Create a one-dimensional array of strings
        string[] stringArray = { "apple", "banana", "cherry", "date", "elderberry" };

        // Step 2: Ask the user to select an index of the array
        Console.WriteLine("Select an index (0-4) to display a fruit from the array:");
        try
        {
            // Try to parse the input as an integer
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            // Step 3: Display the string at the selected index if it is valid
            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                Console.WriteLine($"The fruit at index {stringIndex} is: {stringArray[stringIndex]}");
            }
            else
            {
                // If the index is out of range, display this message
                Console.WriteLine("The index you selected is out of range for the string array.");
            }
        }
        catch (FormatException)
        {
            // Handle invalid input (non-integer input)
            Console.WriteLine("Invalid input! Please enter a valid integer.");
        }

        // Step 4: Create a one-dimensional array of integers
        int[] intArray = { 10, 20, 30, 40, 50 };

        // Step 5: Ask the user to select an index of the integer array
        Console.WriteLine("\nSelect an index (0-4) to display a number from the integer array:");
        try
        {
            // Try to parse the input as an integer
            int intIndex = Convert.ToInt32(Console.ReadLine());

            // Step 6: Display the integer at the selected index if it is valid
            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                Console.WriteLine($"The integer at index {intIndex} is: {intArray[intIndex]}");
            }
            else
            {
                // If the index is out of range, display this message
                Console.WriteLine("The index you selected is out of range for the integer array.");
            }
        }
        catch (FormatException)
        {
            // Handle invalid input (non-integer input)
            Console.WriteLine("Invalid input! Please enter a valid integer.");
        }

        // Step 7: Create a list of strings
        string[] stringList = { "cat", "dog", "bird", "fish", "hamster" };

        // Step 8: Ask the user to select an index of the list
        Console.WriteLine("\nSelect an index (0-4) to display an animal from the list:");
        try
        {
            // Try to parse the input as an integer
            int listIndex = Convert.ToInt32(Console.ReadLine());

            // Step 9: Display the string at the selected index if it is valid
            if (listIndex >= 0 && listIndex < stringList.Length)
            {
                Console.WriteLine($"The animal at index {listIndex} is: {stringList[listIndex]}");
            }
            else
            {
                // If the index is out of range, display this message
                Console.WriteLine("The index you selected is out of range for the list.");
            }
        }
        catch (FormatException)
        {
            // Handle invalid input (non-integer input)
            Console.WriteLine("Invalid input! Please enter a valid integer.");

        }

    }

}
