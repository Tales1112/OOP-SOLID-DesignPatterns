namespace DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_3.Shipping.Factories
{
    //Concrete Creator
    public abstract class ShippingProviderFactory
    {
        //Factory Method
        public abstract ShippingProvider CreateShippingProvider(string country);
        public ShippingProvider GetShippingProvider(string country)
        {
            var provider = CreateShippingProvider(country);

            if(country == "Sweden" &&  provider.InsuranceOptions.ProviderHasInsurance)
            {
                provider.RequiredSignature = false;
            }
            return provider;
        }
    }
}
