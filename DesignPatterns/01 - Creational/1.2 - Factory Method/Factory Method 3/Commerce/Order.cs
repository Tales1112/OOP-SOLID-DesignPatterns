using DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_3.Commerce.Enums;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_3.Commerce
{
    public class Order
    {
        public Dictionary<Item, int> LineItems { get; } = new Dictionary<Item, int>();
        public IList<Payment> SelectedPayments { get; } = new List<Payment>();  
        public IList<Payment> FinalizedPayments { get; } = new List<Payment>();
        public decimal AmountDue => LineItems.Sum(item => item.Key.Price * item.Value) - FinalizedPayments.Sum(payment => payment.Amount);
        public decimal Total => LineItems.Sum(item => item.Key.Price * item.Value);
        public ShippingStatus ShippingSttatus { get; set; } = ShippingStatus.WaitingForPayment;
        public Address Recipient { get; set; }
        public Address Sender { get; set; }
        public decimal TotalWeight { get; set; }
    }
    public class Address
    {
        public string To { get; set; }
        public string AdressLine1 { get; set; }
        public string AdressLine2 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
