using DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Commerce;
using DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Commerce.Invoice;
using DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Commerce.Summary;
using DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Shipping;
using DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Shipping.Factories;

namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models
{
    public class AustraliaPurchaseProviderFactory : IPurchaseProviderFactory
    {
        public IInvoice CreateInvoice(Order order)
        {
            return new GSTInvoice();
        }

        public ShippingProvider CreateShippingProvider(Order order)
        {
            var shippingProviderFactory = new StandardShippingProviderFactory();

            return shippingProviderFactory.CreateShippingProvider(order.Sender.Country);
        }

        public ISummary CreateSummary(Order order)
        {
            return new CsvSummary();
        }
    }
}
