using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantMaster.Models;
using MySql.Data.MySqlClient;

namespace RestaurantMaster.Database
{
    public class DatabaseHelper
    {
        private string _connectionString;
        private MySqlConnection _connection;

        // Constructor - initializing the MySQL connection string
        public DatabaseHelper(string server, string database, string username, string password)
        {
            _connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";
            _connection = new MySqlConnection(_connectionString);
        }

        // Method to open the database connection
        private void OpenConnection()
        {
            try
            {
                _connection.Open(); // Opens the connection to the database
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to database: {ex.Message}"); // Logs an error if the connection fails
            }
        }

        // Method to close the database connection
        private void CloseConnection()
        {
            _connection.Close(); // Closes the connection to the database
        }

        // Method to insert a new MenuItem into the database
        public void InsertMenuItem(MenuItem menuItem)
        {
            try
            {
                OpenConnection(); // Opens the connection to the database

                string query = "INSERT INTO MenuItems (Name, Description, Price, Category, Stock, IsAvailable) " +
                               "VALUES (@Name, @Description, @Price, @Category, @Stock, @IsAvailable)";
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.Parameters.AddWithValue("@Name", menuItem.MenuName); // Adds the menu item name parameter
                cmd.Parameters.AddWithValue("@Description", menuItem.Description); // Adds the description parameter
                cmd.Parameters.AddWithValue("@Price", menuItem.Price); // Adds the price parameter
                cmd.Parameters.AddWithValue("@Category", menuItem.Category); // Adds the category parameter
                cmd.Parameters.AddWithValue("@Stock", menuItem.Stock); // Adds the stock parameter
                cmd.Parameters.AddWithValue("@IsAvailable", menuItem.IsAvailable); // Adds the availability parameter

                cmd.ExecuteNonQuery(); // Executes the query to insert the menu item
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting MenuItem: {ex.Message}"); // Logs an error if the insertion fails
            }
            finally
            {
                CloseConnection(); // Closes the connection to the database after the operation
            }
        }

        // Method to get all MenuItems from the database
        public List<MenuItem> GetMenuItems()
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            try
            {
                OpenConnection(); // Opens the connection to the database

                string query = "SELECT * FROM MenuItems"; // SQL query to retrieve all menu items
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                MySqlDataReader reader = cmd.ExecuteReader(); // Executes the query and retrieves data

                // Loops through the retrieved rows and adds them to the menuItems list
                while (reader.Read())
                {
                    MenuItem menuItem = new MenuItem(
                        reader.GetInt32("MenuItemID"),    // menuItemID
                        reader.GetString("MenuName"),     // menuName
                        reader.GetString("Description"),  // description
                        reader.GetDecimal("Price"),       // price
                        reader.GetString("Category"),    // category
                        reader.GetInt32("Stock"),        // stock
                        reader.GetBoolean("IsAvailable") // isAvailable
                    );
                    menuItems.Add(menuItem); // Adds the menu item to the list
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving MenuItems: {ex.Message}"); // Logs an error if the retrieval fails
            }
            finally
            {
                CloseConnection(); // Closes the connection to the database after the operation
            }

            return menuItems; // Returns the list of menu items
        }

        // Method to update an existing MenuItem in the database
        public void UpdateMenuItem(MenuItem menuItem)
        {
            try
            {
                OpenConnection(); // Opens the connection to the database

                string query = "UPDATE MenuItems SET Name = @Name, Description = @Description, " +
                               "Price = @Price, Category = @Category, Stock = @Stock, IsAvailable = @IsAvailable " +
                               "WHERE MenuItemID = @MenuItemID"; // SQL query to update a menu item
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.Parameters.AddWithValue("@MenuItemID", menuItem.MenuItemID); // Adds the menu item ID parameter
                cmd.Parameters.AddWithValue("@Name", menuItem.MenuName); // Adds the name parameter
                cmd.Parameters.AddWithValue("@Description", menuItem.Description); // Adds the description parameter
                cmd.Parameters.AddWithValue("@Price", menuItem.Price); // Adds the price parameter
                cmd.Parameters.AddWithValue("@Category", menuItem.Category); // Adds the category parameter
                cmd.Parameters.AddWithValue("@Stock", menuItem.Stock); // Adds the stock parameter
                cmd.Parameters.AddWithValue("@IsAvailable", menuItem.IsAvailable); // Adds the availability parameter

                cmd.ExecuteNonQuery(); // Executes the query to update the menu item
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating MenuItem: {ex.Message}"); // Logs an error if the update fails
            }
            finally
            {
                CloseConnection(); // Closes the connection to the database after the operation
            }
        }

        // Method to delete a MenuItem from the database
        public void DeleteMenuItem(int menuItemID)
        {
            try
            {
                OpenConnection(); // Opens the connection to the database

                string query = "DELETE FROM MenuItems WHERE MenuItemID = @MenuItemID"; // SQL query to delete a menu item
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.Parameters.AddWithValue("@MenuItemID", menuItemID); // Adds the menu item ID parameter

                cmd.ExecuteNonQuery(); // Executes the query to delete the menu item
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting MenuItem: {ex.Message}"); // Logs an error if the deletion fails
            }
            finally
            {
                CloseConnection(); // Closes the connection to the database after the operation
            }
        }
    }

    // MenuItem class definition (with IsAvailable included)
    public class MenuItem
    {
        public int MenuItemID { get; set; } // Gets or sets the MenuItem ID
        public string MenuName { get; set; } // Gets or sets the name of the menu item
        public string Description { get; set; } // Gets or sets the description of the menu item
        public decimal Price { get; set; } // Gets or sets the price of the menu item
        public string Category { get; set; } // Gets or sets the category of the menu item
        public int Stock { get; set; } // Gets or sets the stock count of the menu item
        public bool IsAvailable { get; set; } // Gets or sets the availability of the menu item

        // Constructor with IsAvailable
        public MenuItem(int menuItemID, string menuName, string description, decimal price, string category, int stock, bool isAvailable)
        {
            MenuItemID = menuItemID; // Assigns the MenuItem ID
            MenuName = menuName; // Assigns the name of the menu item
            Description = description; // Assigns the description of the menu item
            Price = price; // Assigns the price of the menu item
            Category = category; // Assigns the category of the menu item
            Stock = stock; // Assigns the stock count of the menu item
            IsAvailable = isAvailable; // Assigns the availability of the menu item
        }
    }
}
