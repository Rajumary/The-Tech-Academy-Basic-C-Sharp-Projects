namespace FinalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new instance of the context (SchoolContext)
            using (var context = new SchoolContext())
            {
                //Create a New Student Object
                var student = new Student
                {
                    Name = "Arul",
                    Age = 25
                };
                //Add the student to the context
                context.Students.Add(student);

                //Save the changes to the database
                context.SaveChanges();

                //Display the student data
                Console.WriteLine("Student Added:");
                Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
            }
            Console.ReadLine();
        }
    }
}