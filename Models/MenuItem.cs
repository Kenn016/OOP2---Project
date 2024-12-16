using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RestaurantMaster.Models
{
    public class MenuItem
    {
        // Properties
        public int MenuItemID { get; set; } // Gets or sets the unique Menu Item ID
        public string Name { get; set; } // Gets or sets the name of the menu item
        public string Description { get; set; } // Gets or sets the description of the menu item
        public decimal Price { get; set; } // Gets or sets the price of the menu item
        public string Category { get; set; } // Gets or sets the category of the menu item
        public int Stock { get; set; } // Gets or sets the stock quantity of the menu item
        public bool IsAvailable { get; set; } // Gets or sets the availability status of the menu item

        // Constructor
        public MenuItem(int menuItemID, string name, string description, decimal price, string category, int stock, bool isAvailable)
        {
            MenuItemID = menuItemID; // Assigns the unique Menu Item ID
            Name = name; // Assigns the name of the menu item
            Description = description; // Assigns the description of the menu item
            Price = price; // Assigns the price of the menu item
            Category = category; // Assigns the category of the menu item
            Stock = stock; // Assigns the stock quantity of the menu item
            IsAvailable = isAvailable; // Assigns the availability status of the menu item
        }

        // Method to add a menu item and log the action
        public void AddMenuItem()
        {
            Console.WriteLine($"MenuItem {Name} added."); // Logs the addition of the menu item
        }

        // Method to remove a menu item and update its availability status
        public void RemoveMenuItem()
        {
            IsAvailable = false; // Sets the menu item as unavailable
            Console.WriteLine($"MenuItem {Name} removed."); // Logs the removal of the menu item
        }

        // Method to update the details of an existing menu item
        public void UpdateMenuItem(string name, string description, decimal price)
        {
            Name = name; // Updates the name of the menu item
            Description = description; // Updates the description of the menu item
            Price = price; // Updates the price of the menu item
            Console.WriteLine($"MenuItem {Name} updated."); // Logs the update of the menu item
        }

        // Method to place an order for a specific quantity of the menu item
        public void PlaceOrder(int quantity)
        {
            if (Stock >= quantity)
            {
                Stock -= quantity; // Reduces the stock based on the ordered quantity
                Console.WriteLine($"{quantity} of {Name} ordered."); // Logs the order of the menu item
            }
            else
            {
                Console.WriteLine($"Not enough stock for {Name}."); // Logs when there is not enough stock
            }
        }
    }
}
