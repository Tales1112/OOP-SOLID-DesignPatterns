namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Shipping.Factories
{
    public abstract class ShippingProviderFactory
    {
        public abstract ShippingProvider CreateShippingProvider(string country);

        public ShippingProvider GetShippingProvider(string country)
        {
            var provider = CreateShippingProvider(country);

            if (country == "Sweden" && provider.InsuranceOptions.ProviderHasInsurance)
            {
                provider.RequireSignature = false;
            }
            return provider;
        }

    }
}
