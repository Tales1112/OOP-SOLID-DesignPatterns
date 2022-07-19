namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Commerce.Summary
{
    public interface ISummary
    {
        string CreaterOrderSummary(Order order);

        void Send();
    }
}
