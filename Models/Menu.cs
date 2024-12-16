using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMaster.Models
{
    public class Menu
    {
        // Properties
        public int MenuID { get; set; } // Gets or sets the unique Menu ID
        public string MealName { get; set; } // Gets or sets the name of the meal
        public List<MenuItem> MenuItems { get; set; } // Gets or sets the list of menu items

        // Constructor
        public Menu(int menuID, string mealName)
        {
            MenuID = menuID; // Assigns unique Menu ID
            MealName = mealName; // Assigns the name of the meal
            MenuItems = new List<MenuItem>(); // Initializes the list of menu items
        }

        // Method to add a menu item to the menu
        public void AddMenuItem(MenuItem menuItem)
        {
            MenuItems.Add(menuItem); // Adds the menu item to the list
            Console.WriteLine($"Menu item {menuItem.Name} added to {MealName}."); // Logs the addition of the menu item
        }

        // Method to remove a menu item from the menu
        public void RemoveMenuItem(MenuItem menuItem)
        {
            MenuItems.Remove(menuItem); // Removes the menu item from the list
            Console.WriteLine($"Menu item {menuItem.Name} removed from {MealName}."); // Logs the removal of the menu item
        }

        // Method to display all the menu items in the menu
        public void DisplayMenuItem()
        {
            foreach (var item in MenuItems)
            {
                Console.WriteLine($"Menu Item: {item.Name}, Price: {item.Price}, Available: {item.IsAvailable}"); // Displays each menu item with its details
            }
        }
    }
}
