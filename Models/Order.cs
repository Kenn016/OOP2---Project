using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMaster.Models
{
    public class Order
    {
        // Properties
        public int OrderID { get; set; } // Gets or sets the unique Order ID
        public DateTime OrderDate { get; set; } // Gets or sets the date and time when the order was placed
        public string Status { get; set; } // Gets or sets the status of the order
        public decimal TotalPrice { get; set; } // Gets or sets the total price of the order
        public int TableID { get; set; } // Gets or sets the ID of the table associated with the order
        public List<MenuItem> Items { get; set; } // Gets or sets the list of items in the order

        // Constructor
        public Order(int orderID, DateTime orderDate, string status, decimal totalPrice, int tableID)
        {
            OrderID = orderID; // Assigns the unique Order ID
            OrderDate = orderDate; // Assigns the date and time when the order was placed
            Status = status; // Assigns the status of the order
            TotalPrice = totalPrice; // Assigns the total price of the order
            TableID = tableID; // Assigns the table ID associated with the order
            Items = new List<MenuItem>(); // Initializes the list of items in the order
        }

        // Method to place an order for a menu item with a specified quantity
        public void PlaceOrder(MenuItem menuItem, int quantity)
        {
            Items.Add(menuItem); // Adds the menu item to the order
            TotalPrice += menuItem.Price * quantity; // Updates the total price based on the item and quantity
            Console.WriteLine($"Order {OrderID} placed with {menuItem.Name}."); // Logs the order placement
        }

        // Method to update the status of an existing order
        public void UpdateOrder(int orderID, string newStatus)
        {
            Status = newStatus; // Updates the status of the order
            Console.WriteLine($"Order {orderID} updated to {Status}."); // Logs the status update of the order
        }

        // Method to mark the order as completed
        public void CompleteOrder()
        {
            Status = "Completed"; // Sets the order status to "Completed"
            Console.WriteLine($"Order {OrderID} completed."); // Logs the completion of the order
        }
    }
}
