using DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_3.Commerce;
using DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_3.Shipping.Factories;

namespace DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_3
{
    public class ShoppingCart
    {
        private readonly Order order;
        private readonly ShippingProviderFactory shippingProviderFactory;

        public ShoppingCart(Order order, ShippingProviderFactory shippingProviderFactory)
        {
            this.order = order;
            this.shippingProviderFactory = shippingProviderFactory;
        }

        public string Finalize()
        {
            var shippingProvider = shippingProviderFactory.CreateShippingProvider(order.Sender.Country);

            order.ShippingSttatus = Commerce.Enums.ShippingStatus.ReadyForShippment;

            return shippingProvider.GenerateShippingLabelFor(order);
        }
    }
}
