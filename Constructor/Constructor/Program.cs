class Program
{
    // Step 1: Create a const variable
    // A constant variable whose value cannot be changed after it is initialized.
    // Here, we are defining the number of days in a week.
    const int DaysInWeek = 7;

    static void Main()
    {
        // Step 2: Create a variable using the "var" keyword
        // The "var" keyword allows the compiler to infer the type of the variable.
        // In this case, it infers that "message" is of type string since we assign a string value to it.
        var message = "Hello, world!";

        // Print the message to the console
        Console.WriteLine(message);

        // Step 3: Chain two constructors together
        // Constructor chaining is used to call one constructor from another within the same class.
        // Here, we create an instance of the "Person" class and pass data to the constructor.

        // First, instantiate the "Person" class using a constructor that takes "name" and "age".
        var person1 = new Person("John", 30);

        // Now, use another constructor of the "Person" class that takes "name", "age", and "address".
        // The constructor chaining happens in the "Person" class itself.
        person1.DisplayInfo(); // This will display the name, age, and address for person1
    }
}

// Step 4: Define the "Person" class with two constructors
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }

    // Constructor 1: Takes two parameters (name and age) and initializes the object
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        // Call another constructor to set the default address to "Unknown"
        Address = "Unknown";
    }

    // Constructor 2: Takes three parameters (name, age, and address) and initializes the object
    // This constructor is chained from the first constructor using ": this(name, age)"
    public Person(string name, int age, string address) : this(name, age)
    {
        Address = address;
    }

    // Display the person's information to the console
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address}");
    }
}