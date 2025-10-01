using System;

namespace EmployeeApp
{
    // The Employee class represents a simple employee with an Id, FirstName and LastName.
    // It implements the IQuittable interface so it must implement the Quit() method.
    public class Employee : IQuittable
    {
        // Public property for the employee's unique identifier.
        public int Id { get; set; }

        // Public property for the employee's first name.
        public string FirstName { get; set; }

        // Public property for the employee's last name.
        public string LastName { get; set; }

        // Parameterless constructor that initializes strings to empty to avoid nulls.
        public Employee()
        {
            FirstName = string.Empty; // initialize to empty string
            LastName = string.Empty;  // initialize to empty string
        }

        // Implement the Quit method required by the IQuittable interface.
        // Here it simply writes a message to the console indicating the employee quit.
        public void Quit()
        {
            // Write a formatted message including the employee's full name and Id.
            Console.WriteLine($"Employee {{Id}} - {{FirstName}} {{LastName}} has quit.");
        }

        // Overload the equality operator '==' to compare two employees by their Id property.
        // Note: When overloading ==, you must also overload !=.
        public static bool operator ==(Employee left, Employee right)
        {
            // If both are null, they are equal.
            if (ReferenceEquals(left, null) && ReferenceEquals(right, null)) return true;
            // If one is null but not the other, they are not equal.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) return false;
            // Compare by Id
            return left.Id == right.Id;
        }

        // Overload the inequality operator '!=' to complement the '==' operator.
        public static bool operator !=(Employee left, Employee right)
        {
            // Use the inverse of the == operator.
            return !(left == right);
        }

        // Override Equals to match the operator overload behavior.
        public override bool Equals(object? obj)
        {
            // Try to cast the object to Employee and compare Id values.
            var other = obj as Employee;
            if (other is null) return false;
            return this.Id == other.Id;
        }

        // Override GetHashCode when overriding Equals.
        public override int GetHashCode()
        {
            // Use Id's hash code (safe because Id is int).
            return Id.GetHashCode();
        }
    }
}
