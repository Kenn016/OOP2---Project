using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMaster.Models
{
    public class Reservation : IReservable
    {
        // Properties
        public int ReservationID { get; set; } // Gets or sets the unique Reservation ID
        public DateTime ReservationDate { get; set; } // Gets or sets the date and time of the reservation
        public int CustomerID { get; set; } // Gets or sets the ID of the customer making the reservation
        public int TableID { get; set; } // Gets or sets the ID of the table reserved for the customer
        public string Status { get; set; } // Gets or sets the current status of the reservation (e.g., Confirmed, Cancelled)
        public bool IsConfirmed { get; set; }  // Whether the reservation is confirmed

        // Constructor
        public Reservation(int reservationID, DateTime reservationDate, int customerID, int tableID, string status)
        {
            ReservationID = reservationID; // Assigns the unique Reservation ID
            ReservationDate = reservationDate; // Assigns the date and time of the reservation
            CustomerID = customerID; // Assigns the ID of the customer making the reservation
            TableID = tableID; // Assigns the ID of the table reserved for the customer
            Status = status; // Assigns the current status of the reservation
        }

        public Reservation()
        {
            // Default constructor for creating an empty Reservation object
        }

        // Method to create a new reservation and set its status to "Confirmed"
        public void CreateReservation()
        {
            Status = "Confirmed"; // Sets the reservation status to Confirmed
            Console.WriteLine($"Reservation {ReservationID} created for Customer {CustomerID} at Table {TableID}"); // Logs the creation of the reservation
        }

        // Method to update an existing reservation with a new date and table ID
        public void UpdateReservation(DateTime newReservationDate, int newTableID)
        {
            ReservationDate = newReservationDate; // Updates the reservation date to the new date
            TableID = newTableID; // Updates the table ID to the new table
            Console.WriteLine($"Reservation {ReservationID} updated to {ReservationDate} at Table {TableID}"); // Logs the update of the reservation
        }

        // Method to cancel the reservation
        public void CancelReservation()
        {

            if (!IsConfirmed) // Checks if the reservation is not confirmed
            {
                Console.WriteLine($"Reservation for Customer {CustomerID} at Table {TableID} has already been canceled."); // Logs that the reservation has already been canceled
            }
            else
            {
                IsConfirmed = false; // Marks the reservation as canceled
                Console.WriteLine($"Reservation for Customer {CustomerID} at Table {TableID} has been canceled."); // Logs the cancellation of the reservation
            }
        }
    }
}
