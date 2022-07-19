namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Commerce
{
    public class Payment
    {
        public decimal Amount { get; set; }
        public PaymentProvider PaymentProvider { get; set; }
    }
}
