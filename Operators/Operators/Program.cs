public class Employee
{
    // Properties to hold employee details
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the == operator to compare two Employee objects based on Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Check if both objects are null or both have the same Id
        if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
        {
            return true;  // Both are null, so they are considered equal
        }

        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
        {
            return false;  // One is null and the other is not, so they are not equal
        }

        return emp1.Id == emp2.Id;  // Check if their Ids are equal
    }

    // Overload the != operator to compare two Employee objects based on Id
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        // If they are not equal based on Id, then return true for inequality
        return !(emp1 == emp2);  // Reuse the overloaded == operator
    }

    // Override the Equals method to check equality based on Id
    public override bool Equals(object obj)
    {
        // Check if the object is of type Employee
        if (obj is Employee)
        {
            var otherEmployee = (Employee)obj;
            return this.Id == otherEmployee.Id;
        }
        return false;
    }

    // Override the GetHashCode method to ensure consistency with Equals
    public override int GetHashCode()
    {
        return Id.GetHashCode(); // Use the Id to generate a hash code
    }

    // Constructor to initialize an Employee object
    public Employee(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate two Employee objects and assign values to their properties
        Employee employee1 = new Employee(101, "John", "Doe");
        Employee employee2 = new Employee(101, "Jane", "Smith");

        // Compare the two Employee objects using the overloaded == operator
        if (employee1 == employee2)
        {
            Console.WriteLine("Both employees are equal based on their ID.");
        }
        else
        {
            Console.WriteLine("The employees are not equal based on their ID.");
        }

        // Compare the two Employee objects using the overloaded != operator
        if (employee1 != employee2)
        {
            Console.WriteLine("The employees are different based on their ID.");
        }
        else
        {
            Console.WriteLine("Both employees are equal based on their ID.");
        }
    }
}
