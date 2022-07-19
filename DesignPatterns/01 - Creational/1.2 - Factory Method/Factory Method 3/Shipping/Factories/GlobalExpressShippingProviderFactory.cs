namespace DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_3.Shipping.Factories
{
    public class GlobalExpressShippingProviderFactory : ShippingProviderFactory
    {
        public override ShippingProvider CreateShippingProvider(string country)
        {
            return new GlobalExpressShippingProvider();
        }
    }
}
