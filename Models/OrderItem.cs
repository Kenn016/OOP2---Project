using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMaster.Models
{
    public class OrderItem
    {
        // Properties
        public int OrderItemID { get; set; } // Gets or sets the unique Order Item ID
        public MenuItem MenuItem { get; set; } // Gets or sets the MenuItem associated with the order item
        public int Quantity { get; set; } // Gets or sets the quantity of the menu item in the order
        public decimal Subtotal { get; set; } // Gets or sets the subtotal price for this order item (Quantity * MenuItem price)

        // Constructor
        public OrderItem(int orderItemID, MenuItem menuItem, int quantity, decimal subtotal)
        {
            OrderItemID = orderItemID; // Assigns the unique Order Item ID
            MenuItem = menuItem; // Assigns the MenuItem to this order item
            Quantity = quantity; // Assigns the quantity of the menu item in the order
            Subtotal = subtotal; // Assigns the subtotal price of the order item
        }

        // Method to display the details of the order item
        public void DisplayOrderItemInfo()
        {
            Console.WriteLine($"OrderItemID: {OrderItemID}"); // Displays the OrderItemID
            Console.WriteLine($"MenuItem: {MenuItem.Name}"); // Displays the name of the MenuItem
            Console.WriteLine($"Quantity: {Quantity}"); // Displays the quantity of the MenuItem in the order
            Console.WriteLine($"Subtotal: {Subtotal:C}"); // Displays the subtotal of the order item in currency format
        }
    }
}
