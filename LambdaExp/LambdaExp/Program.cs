// Define the Employee class
public class Employee
{
    // Define properties for the Employee class
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a list of employees
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
            new Employee { Id = 2, FirstName = "Anna", LastName = "Johnson" },
            new Employee { Id = 3, FirstName = "Tom", LastName = "Williams" },
            new Employee { Id = 4, FirstName = "Joe", LastName = "Brown" },
            new Employee { Id = 5, FirstName = "Alice", LastName = "Davis" },
            new Employee { Id = 6, FirstName = "Eve", LastName = "Miller" },
            new Employee { Id = 7, FirstName = "Mike", LastName = "Wilson" },
            new Employee { Id = 8, FirstName = "Zoe", LastName = "Moore" },
            new Employee { Id = 9, FirstName = "Paul", LastName = "Taylor" },
            new Employee { Id = 10, FirstName = "Emily", LastName = "Anderson" }
        };

        // Part 1: Use a foreach loop to create a list of employees with the first name "Joe"
        List<Employee> joeEmployees = new List<Employee>();
        foreach (var employee in employees)
        {
            // Check if the employee's first name is "Joe"
            if (employee.FirstName == "Joe")
            {
                // If yes, add them to the joeEmployees list
                joeEmployees.Add(employee);
            }
        }

        // Print the employees with the first name "Joe"
        Console.WriteLine("Employees with the first name 'Joe' (foreach loop):");
        foreach (var employee in joeEmployees)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName}");
        }

        // Part 2: Use a lambda expression to create a list of employees with the first name "Joe"
        var joeEmployeesLambda = employees.Where(e => e.FirstName == "Joe").ToList();

        // Print the employees with the first name "Joe" (using lambda expression)
        Console.WriteLine("\nEmployees with the first name 'Joe' (lambda expression):");
        foreach (var employee in joeEmployeesLambda)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName}");
        }

        // Part 3: Use a lambda expression to create a list of employees with an Id greater than 5
        var employeesWithIdGreaterThan5 = employees.Where(e => e.Id > 5).ToList();

        // Print the employees with Id greater than 5
        Console.WriteLine("\nEmployees with Id greater than 5:");
        foreach (var employee in employeesWithIdGreaterThan5)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName} (ID: {employee.Id})");
        }
    }
}