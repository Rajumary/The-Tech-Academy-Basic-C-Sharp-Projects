// Define an abstract class Person
public abstract class Person
{
    // Properties for first and last name
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Abstract method SayName (must be implemented by derived classes)
    public abstract void SayName();
}

// Define the Employee class that inherits from Person
public class Employee : Person
{
    // Implement the SayName method
    public override void SayName()
    {
        // Display the full name of the employee
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}

class Program
{
    static void Main()
    {
        // Instantiate an Employee object with first name "Sample" and last name "Student"
        Employee employee = new Employee()
        {
            FirstName = "Raju",
            LastName = "Michael"
        };

        // Call the SayName method on the employee object
        employee.SayName();
    }
}
