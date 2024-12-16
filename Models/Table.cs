using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RestaurantMaster.Models
{
    public class Table : IReservable
    {
        // Properties
        public int TableID { get; set; } // Gets or sets the unique Table ID
        public string TableNumber { get; set; } // Gets or sets the table number
        public int Capacity { get; set; } // Gets or sets the seating capacity of the table
        public bool IsAvailable { get; set; } // Gets or sets the availability status of the table (true if available, false otherwise)
        public string Location { get; set; } // Gets or sets the location or section where the table is situated
        public bool IsReserved { get; set; } // Whether the table is currently reserved or not


        // Constructor
        public Table(int tableID, string tableNumber, int capacity, bool isAvailable, string location)
        {
            TableID = tableID; // Assigns the unique Table ID
            TableNumber = tableNumber; // Assigns the table number
            Capacity = capacity; // Assigns the seating capacity of the table
            IsAvailable = isAvailable; // Assigns the availability status of the table
            Location = location; // Assigns the location or section of the table
        }

        // Method to assign the table to a reservation and update its availability status
        public void AssignTable(int reservationID)
        {
            IsAvailable = false; // Sets the table availability to false, indicating it is assigned
            Console.WriteLine($"Table {TableNumber} has been assigned to Reservation {reservationID}"); // Logs the assignment of the table to the reservation
        }

        // Method to check and display the availability of the table
        public void CheckAvailability()
        {
            Console.WriteLine(IsAvailable ? "Table is available." : "Table is not available."); // Logs the availability status of the table
        }

        // Method to create a reservation for this table
        public void CreateReservation()
        {
            if (IsReserved)
            {
                Console.WriteLine($"Table {TableNumber} is already reserved.");
            }
            else
            {
                IsReserved = true;
                Console.WriteLine($"Table {TableNumber} has been reserved.");
            }
        }

        // Cancels a reservation for this table
        public void CancelReservation()
        {
            if (!IsReserved) // Checks if the table is not reserved
            {
                Console.WriteLine($"Table {TableNumber} is not currently reserved."); // Logs that the table is not reserved
            }
            else
            {
                IsReserved = false; // Marks the table as available again
                Console.WriteLine($"Reservation for Table {TableNumber} has been canceled."); // Logs the cancellation of the reservation
            }
        }
    }
}
