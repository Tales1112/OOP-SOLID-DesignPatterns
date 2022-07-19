using DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models;
using DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Commerce;
using DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Shipping.Enums;
using System;

namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3
{
    public class ShoppingCart
    {
        private readonly Order order;
        private readonly IPurchaseProviderFactory purchaseProviderFactory;

        public ShoppingCart(Order order, IPurchaseProviderFactory purchaseProviderFactory)
        {
            this.order = order;
            this.purchaseProviderFactory = purchaseProviderFactory; 
        }

        public string Finalize()
        {
            if(order.ShippingStatus == ShippingStatus.ReadyForShippment)
            {
                throw new InvalidOperationException();
            }

            var shippingProvider = purchaseProviderFactory.CreateShippingProvider(order);

            var invoice = purchaseProviderFactory.CreateInvoice(order);

            // Send Invoice

            invoice.GenerateInvoice();


            var summary = purchaseProviderFactory.CreateSummary(order);

            summary.Send();

            // Send Summary

            order.ShippingStatus = ShippingStatus.ReadyForShippment;

            return shippingProvider.GenerateShippingLabelFor(order);
        }
    }
}
