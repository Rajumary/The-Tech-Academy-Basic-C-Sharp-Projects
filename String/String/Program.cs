using System.Text;

class Program
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = " ";
        string str3 = "World!";

        // Concatenating three strings using the + operator
        string result = str1 + str2 + str3;
        Console.WriteLine(result);  // Output: Hello World!


        string text = "hello world";

        // Convert string to uppercase
        string upperText = text.ToUpper();
        Console.WriteLine(upperText);  // Output: HELLO WORLD
        StringBuilder sb = new StringBuilder();

        // Adding sentences to the StringBuilder
        sb.AppendLine("This is the first sentence.");
        sb.AppendLine("Here's the second sentence.");
        sb.AppendLine("Finally, this is the third sentence.");

        // Convert the StringBuilder content to a string and print it
        string paragraph = sb.ToString();
        Console.WriteLine(paragraph);


    }
}