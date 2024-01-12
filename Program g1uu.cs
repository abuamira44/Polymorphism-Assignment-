using System;

// Define the IQuittable interface
public interface IQuittable
{
    void Quit();
}

// Modify the Employee class to inherit from IQuittable and implement the Quit() method
public class Employee : IQuittable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Implement the Quit method from the IQuittable interface
    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} has quit the organization.");
    }
}

class Program
{
    static void Main()
    {
        // Instantiate an Employee object
        Employee employee = new Employee { FirstName = "John", LastName = "Doe" };

        // Use polymorphism to create an object of type IQuittable
        IQuittable quittableEmployee = employee;

        // Call the Quit method on the IQuittable object
        quittableEmployee.Quit();
    }
}
