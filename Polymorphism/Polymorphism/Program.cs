// Define an abstract class Person
public abstract class Person
{
    // Properties for first and last name
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Abstract method SayName (must be implemented by derived classes)
    public abstract void SayName();
}

// Define the IQuittable interface
public interface IQuittable
{
    // Method declaration for Quit
    void Quit();
}

// Define the Employee class that inherits from Person and implements IQuittable
public class Employee : Person, IQuittable
{
    // Implement the SayName method from the Person class
    public override void SayName()
    {
        // Display the full name of the employee
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }

    // Implement the Quit method from the IQuittable interface
    public void Quit()
    {
        // Define what happens when an employee quits
        Console.WriteLine("The employee has quit their job.");
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

        // Create a variable of type IQuittable and assign it the Employee object
        IQuittable quittableEmployee = employee;

        // Call the Quit method using the IQuittable reference
        quittableEmployee.Quit(); // This will call the Quit method implemented in Employee
    }
}