using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMaster.Models
{
    public class Employee
    {
        // Properties
        public int EmployeeID { get; set; }  // Unique identifier for the employee
        public string Name { get; set; }  // Name of the employee
        public string Role { get; set; }  // Role of the employee (e.g., Chef, Waiter)
        public string Phone { get; set; }  // Phone number of the employee
        public string Email { get; set; }  // Email address of the employee

        // Constructor
        public Employee(int employeeID, string name, string role, string phone, string email)
        {
            EmployeeID = employeeID;  // Initializes EmployeeID with the provided value
            Name = name;  // Initializes Name with the provided value
            Role = role;  // Initializes Role with the provided value
            Phone = phone;  // Initializes Phone with the provided value
            Email = email;  // Initializes Email with the provided value
        }

        // Methods

        // Updates the role of the employee
        public void AssignRole(string newRole)
        {
            Role = newRole;  // Sets the employee's role to the new role
            Console.WriteLine($"Role updated to {Role}");  // Outputs the updated role
        }

        // Updates the employee details (name, phone, and email)
        public void UpdateEmployeeDetails(string name, string phone, string email)
        {
            Name = name;  // Updates the employee's name
            Phone = phone;  // Updates the employee's phone number
            Email = email;  // Updates the employee's email address
            Console.WriteLine("Employee details updated.");  // Outputs confirmation message
        }
    }
}
