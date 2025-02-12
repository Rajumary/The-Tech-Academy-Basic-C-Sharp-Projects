namespace MathApp
{
    public class MathOperations
    {
        // Method 1: Takes an integer, performs addition, and returns an integer
        public int PerformOperation(int number)
        {
            // Perform an addition operation
            return number + 10;
        }

        // Method 2: Takes a decimal, performs a different operation, and returns an integer
        public int PerformOperation(decimal number)
        {
            // Perform multiplication operation and cast to int
            return (int)(number * 2.5m);  // Multiplying by 2.5 and then converting to int
        }

        // Method 3: Takes a string, converts it to an integer, performs a subtraction, and returns an integer
        public int PerformOperation(string number)
        {
            int convertedNumber;
            // Check if the string can be converted to an integer
            if (int.TryParse(number, out convertedNumber))
            {
                // Perform a subtraction operation
                return convertedNumber - 5;
            }
            else
            {
                // If not convertible, return 0
                Console.WriteLine("Invalid input string, could not convert to integer.");
                return 0;
            }
        }
    }
}