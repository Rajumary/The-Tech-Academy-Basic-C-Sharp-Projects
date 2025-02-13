// Define the Person class with two properties: FirstName and LastName
public class Person
{
    // Property for the first name
    public string FirstName { get; set; }

    // Property for the last name
    public string LastName { get; set; }

    // Method to display the full name
    public void SayName()
    {
        // Print the person's full name to the console
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}

// Define the Employee class that inherits from Person
public class Employee : Person
{
    // Property for the employee's ID, which is an integer
    public int Id { get; set; }
}

class Program
{
    static void Main()
    {
        // Instantiate and initialize an Employee object with first name "Sample" and last name "Student"
        Employee employee = new Employee()
        {
            FirstName = "Raju",
            LastName = "Michael",
            Id = 123 // Set the employee's ID
        };

        // Call the SayName method from the base class (Person) to display the employee's name
        employee.SayName();
    }
}
