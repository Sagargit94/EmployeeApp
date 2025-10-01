using System;

namespace EmployeeApp
{
    // Program entry point for the console application.
    public class Program
    {
        // The Main method is the first method that runs when the application starts.
        public static void Main(string[] args)
        {
            // Create the first Employee object and set its properties.
            var emp1 = new Employee
            {
                Id = 1,
                FirstName = "Sagar",
                LastName = "Vaghasiya"
            };

            // Create the second Employee object and set its properties.
            var emp2 = new Employee
            {
                Id = 2,
                FirstName = "Alex",
                LastName = "Johnson"
            };

            // Demonstrate operator overloading by comparing emp1 and emp2 using '=='.
            // This uses the overloaded operator in Employee to compare by Id.
            Console.WriteLine($"Are emp1 and emp2 equal by Id? { (emp1 == emp2) }"); // expected: False

            // Now create an IQuittable reference that points to an Employee instance.
            // This demonstrates polymorphism: empAsQuittable's compile-time type is the interface,
            // but the runtime object is an Employee which implements Quit().
            IQuittable empAsQuittable = emp1;

            // Call Quit through the interface reference. This will call Employee.Quit().
            empAsQuittable.Quit();

            // Pause the console so the output stays visible until the user presses a key.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
