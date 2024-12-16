using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMaster.Models
{
    public class Payment
    {
        // Properties
        public int PaymentID { get; set; } // Gets or sets the unique Payment ID
        public int BillID { get; set; } // Gets or sets the Bill ID associated with the payment
        public decimal Amount { get; set; } // Gets or sets the amount of the payment
        public DateTime PaymentDate { get; set; } // Gets or sets the date and time when the payment was made
        public string PaymentMethod { get; set; } // Gets or sets the method used for the payment (e.g., Credit Card, Cash)
        public string PaymentStatus { get; set; } // Gets or sets the current status of the payment (e.g., Completed, Pending)

        // Constructor
        public Payment(int paymentID, int billID, decimal amount, DateTime paymentDate, string paymentMethod, string paymentStatus)
        {
            PaymentID = paymentID; // Assigns the unique Payment ID
            BillID = billID; // Assigns the Bill ID related to this payment
            Amount = amount; // Assigns the amount of the payment
            PaymentDate = paymentDate; // Assigns the date when the payment was made
            PaymentMethod = paymentMethod; // Assigns the payment method used
            PaymentStatus = paymentStatus; // Assigns the current status of the payment
        }

        // Method to process the payment and update the payment status
        public void ProcessPayment()
        {
            PaymentStatus = "Completed"; // Sets the payment status to Completed
            Console.WriteLine($"Payment of {Amount} processed using {PaymentMethod}."); // Logs the payment processing
        }

        // Method to refund the payment and update the payment status
        public void RefundPayment()
        {
            PaymentStatus = "Refunded"; // Sets the payment status to Refunded
            Console.WriteLine($"Payment of {Amount} refunded."); // Logs the payment refund
        }
    }
}
