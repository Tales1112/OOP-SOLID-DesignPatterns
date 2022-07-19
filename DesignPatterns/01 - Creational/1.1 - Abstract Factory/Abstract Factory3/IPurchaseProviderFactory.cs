using DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Commerce;
using DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Commerce.Invoice;
using DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Commerce.Summary;
using DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Shipping;

namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models
{
    public interface IPurchaseProviderFactory
    {
        ShippingProvider CreateShippingProvider(Order order);
        IInvoice CreateInvoice(Order order);
        ISummary CreateSummary(Order order);
    }
}
