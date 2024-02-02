using System;

namespace DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_3.Shipping.Factories
{
    // Concrete Creator
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
                    ShippingType = Commerce.Enums.ShippingType.Standard
                };

                var customHandlingOptions = new CustomsHandlingOptions()
                {
                    TaxOptions = Commerce.Enums.TaxOptions.Prepaid
                };

                var insuranceOptions = new InsuranceOptions
                {
                    ProviderHasInsurance = false,
                    ProviderHasExtendedInsurance = false,
                    ProviderRequiresReturnOnDamage = false,
                };

                shippingProvider = new AustraliaPostShippingProvider("CLIENT_ID", "SECRET",
                                                                      shippingCostCalculator,
                                                                      customHandlingOptions,
                                                                      insuranceOptions);
                #endregion
            }
            else if(country == "Sweden")
            {
                #region Swedish Postal Service Shipping Provider

                var shippingCostCalculator = new ShippingCostCalculator(internationalShippingFee: 50, extraWeightFee: 100)
                {
                    ShippingType = Commerce.Enums.ShippingType.Express
                };

                var customHandlingOptions = new CustomsHandlingOptions
                {
                    TaxOptions = Commerce.Enums.TaxOptions.PayOnArrival
                };

                var insuranceOptions = new InsuranceOptions
                {
                    ProviderHasInsurance = true,
                    ProviderHasExtendedInsurance = false,
                    ProviderRequiresReturnOnDamage = false,
                };

                shippingProvider = new SwedishPostalServiceShippingProvider("API_KEY", shippingCostCalculator,
                                                                            customHandlingOptions, insuranceOptions);

                #endregion
            }
            else
            {
                throw new NotSupportedException("No Shipping provider found for origin country");
            }
            #endregion

            return shippingProvider;
        }
    }
}
