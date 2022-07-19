namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Commerce.Summary
{
    public class EmailSummary : ISummary
    {
        public string CreaterOrderSummary(Order order)
        {
            return $"This is an email summary";
        }

        public void Send() { }
    }
}
