using DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Commerce;
using DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Commerce.Invoice;
using DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Commerce.Summary;
using DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Shipping;
using DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Shipping.Factories;

namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models
{
    public class SwedenPurchaseProviderFactory : IPurchaseProviderFactory
    {
        public IInvoice CreateInvoice(Order order)
        {
            if(order.Recipient.Country != order.Sender.Country)
            {
                return new NoVATInvoice();
            }

            return new VATInvoice();    
        }

        public ShippingProvider CreateShippingProvider(Order order)
        {
            ShippingProviderFactory shippingProviderFactory;

            if(order.Sender.Country != order.Recipient.Country)
            {
                shippingProviderFactory = new GlobalExpressShippingProviderFactory();
            }
            else
            {
                shippingProviderFactory = new StandardShippingProviderFactory();
            }

            return shippingProviderFactory.CreateShippingProvider(order.Sender.Country);
        }

        public ISummary CreateSummary(Order order)
        {
            throw new System.NotImplementedException();
        }
    }
}
