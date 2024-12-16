using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RestaurantMaster.Models
{

    // Represents a customer in the restaurant management system.
    public class Customer
    {
        // Properties
        public int CustomerID { get; set; } // Gets or sets the ID of the customer.
        public string Name { get; set; } // Gets or sets the name of the customer.
        public string Email { get; set; } // Gets or sets the email address of the customer.
        public string Phone { get; set; } // Gets or sets the phone number of the customer.
        public string Address { get; set; } // Gets or sets the address of the customer.

        // Constructor
        public Customer(int customerID, string name, string email, string phone, string address)
        {
            CustomerID = customerID; // Assigns unique ID of a customer
            Name = name; // Assigns name of the customer
            Email = email; // Assigns the email address of the customer
            Phone = phone; // Assigns the phone number of the customer
            Address = address; // Assigns the address of the customer
        }

        // Methods
        // Makes a reservation for the customer
        public void MakeReservation(Reservation reservation)
        {
            Console.WriteLine($"Reservation made by {Name} on {reservation.ReservationDate}");
        }

        // Views the reservation details
        public void ViewReservation(Reservation reservation)
        {
            Console.WriteLine($"Reservation details: {reservation.ReservationID}, {reservation.Status}");
        }

        // Cancels the reservation for the customer
        public void CancelReservation(Reservation reservation)
        {
            reservation.Status = "Cancelled";
            Console.WriteLine($"Reservation {reservation.ReservationID} cancelled.");
        }

        // Validates the customer input to ensure required fields are present and valid.
        // <returns>True if customer data is valid, false otherwise.</returns>
        public bool ValidateCustomer()
        {
            // Ensure Name and Email are not empty
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Email))
                return false;

            // Validate Email Format (Basic regex check for an email)
            var emailValid = Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!emailValid)
                return false;

            // Validate Phone Format (10-digit phone number)
            var phoneValid = Regex.IsMatch(Phone, @"^\d{10}$");
            return phoneValid;
        }
    }
}
