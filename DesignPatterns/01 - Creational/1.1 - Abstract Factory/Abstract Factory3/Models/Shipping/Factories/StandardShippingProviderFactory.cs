using System;

namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Shipping.Factories
{
    public class StandardShippingProviderFactory : ShippingProviderFactory
    {
        public override ShippingProvider CreateShippingProvider(string country)
        {
            ShippingProvider shippingProvider;

            #region Create Shipping Provider

            if(country == "Australia")
            {
                #region Australia Post Shipping Provider

                var shippingCostCalculator = new ShippingCostCalculator(internationalShippingFee: 250, extraWeightFee: 500)
                {
                    ShippingType = Enums.ShippingType.Standard,
                };

                var customHandlingOptions = new CustomsHandlingOptions
                {
                    TaxOptions = Enums.TaxOptions.PrePaid
                };

                var insuranceOptions = new InsuranceOptions
                {
                    ProviderHasInsurance = false,
                    ProviderHasExtendedInsurance = false,
                    ProviderRequiresReturnOnDamange = false,
                };

                shippingProvider = new AustraliaPostShippingProvider("CLIENT_ID",
                 "SECRET",
                 shippingCostCalculator,
                 customHandlingOptions,
                 insuranceOptions);
                #endregion
            }
            else if(country == "Sweden")
            {
                #region Swedish Postal Service Shipping Provider

                var shippingCostCalculator = new ShippingCostCalculator(internationalShippingFee: 50, extraWeightFee: 500)
                {
                    ShippingType = Enums.ShippingType.Express
                };

                var customHandlingOptions = new CustomsHandlingOptions
                {
                    TaxOptions = Enums.TaxOptions.PayOnArrival
                };

                var insuranceOptions = new InsuranceOptions
                {
                    ProviderHasInsurance = true,
                    ProviderHasExtendedInsurance = false,
                    ProviderRequiresReturnOnDamange = false
                };

                shippingProvider = new SwedishPostalServiceShippingProvider("API_KEY",
                    shippingCostCalculator,
                    customHandlingOptions,
                    insuranceOptions);

                #endregion
            }
            else
            {
                throw new NotSupportedException("No shipping provider found for origin country");
            }
            #endregion

            return shippingProvider;
        }
    }
}
