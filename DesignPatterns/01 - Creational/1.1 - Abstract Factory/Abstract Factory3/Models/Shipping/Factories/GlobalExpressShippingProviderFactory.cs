namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Shipping.Factories
{
    public class GlobalExpressShippingProviderFactory : ShippingProviderFactory
    {
        public override ShippingProvider CreateShippingProvider(string country)
        {
            return new GlobalExpressShippingProvider();
        }
    }
}
