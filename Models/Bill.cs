using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMaster.Models
{
    public class Bill
    {
        // Properties
        public int BillID { get; set; } // Gets or sets the unique Bill ID
        public int OrderID { get; set; } // Gets or sets the associated Order ID
        public decimal TotalAmount { get; set; } // Gets or sets the total amount before discount
        public decimal Discount { get; set; } // Gets or sets the discount applied to the bill
        public decimal FinalAmount { get; set; } // Gets or sets the final amount after discount
        public string PaymentStatus { get; set; } // Gets or sets the payment status of the bill

        // Constructor
        public Bill(int billID, int orderID, decimal totalAmount, decimal discount, decimal finalAmount, string paymentStatus)
        {
            BillID = billID; // Assigns unique Bill ID
            OrderID = orderID; // Assigns Order ID linked to the bill
            TotalAmount = totalAmount; // Assigns the total amount of the bill
            Discount = discount; // Assigns discount value
            FinalAmount = finalAmount; // Assigns the final amount after discount
            PaymentStatus = paymentStatus; // Assigns payment status of the bill
        }

        // Methods
        // Method to generate the bill with details
        public void GenerateBill()
        {
            Console.WriteLine($"Bill generated: Total Amount: {TotalAmount}, Discount: {Discount}, Final Amount: {FinalAmount}"); // Logs the bill generation with details
        }

        // Method to apply a discount to the bill and update the final amount
        public void ApplyDiscount(decimal discount)
        {
            Discount = discount; // Sets the discount on the bill
            FinalAmount = TotalAmount - Discount;
            Console.WriteLine($"Discount applied. Final Amount: {FinalAmount}"); // Logs the final amount after discount
        }

        // Method to generate and print the receipt for the bill
        public void GenerateReceipt()
        {
            Console.WriteLine($"Receipt for Bill {BillID}: Total: {TotalAmount}, Discount: {Discount}, Final: {FinalAmount}"); // Logs the receipt generation
        }
    }
}
