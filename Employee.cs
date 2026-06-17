using System;

namespace EmployeeInterfaceDemo
{
    // Create an interface named IQuittable
    // Interfaces define methods that classes must implement
    interface IQuittable
    {
        // Declare a Quit method with no return value
        void Quit();
    }

    // Employee class implements the IQuittable interface
    class Employee : IQuittable
    {
        // Property to store the employee's first name
        public string FirstName { get; set; }

        // Property to store the employee's last name
        public string LastName { get; set; }

        // Property to store the employee ID
        public int Id { get; set; }

        // Implement the Quit() method required by the interface
        public void Quit()
        {
            // Display a message indicating the employee has quit
            Console.WriteLine($"{FirstName} {LastName} has quit the company.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object and assign values
            Employee employee = new Employee()
            {
                FirstName = "John",
                LastName = "Smith",
                Id = 101
            };

            // Use polymorphism:
            // Create an object of type IQuittable
            // and assign it an Employee object because
            // Employee implements the IQuittable interface
            IQuittable quittableEmployee = employee;

            // Call the Quit() method through the interface reference
            quittableEmployee.Quit();

            // Pause the program so the user can see the output
            Console.ReadLine();
        }
    }
}
