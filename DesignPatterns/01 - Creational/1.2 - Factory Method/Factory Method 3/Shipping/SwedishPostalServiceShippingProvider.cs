using DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_3.Commerce;
using System;

namespace DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_3.Shipping
{
    // Concrete Product
    public class SwedishPostalServiceShippingProvider : ShippingProvider
    {
        private readonly string apiKey;

        public SwedishPostalServiceShippingProvider(string apiKey,
                                                    ShippingCostCalculator shippingCostCalculator,
                                                    CustomsHandlingOptions customsHandlingOptions,
                                                    InsuranceOptions insuranceOptions)
        {
            this.apiKey = apiKey;   
            ShippingCostCalculator = shippingCostCalculator;
            CustomHandlingOptions = customsHandlingOptions;
            InsuranceOptions = insuranceOptions;    
        }
        public override string GenerateShippingLabelFor(Order order)
        {
            var shippingId = GetShippingId();

            var shippingCost = ShippingCostCalculator.CalculateFor(order.Recipient.Country, 
                                                                   order.Sender.Country,
                                                                   order.TotalWeight);
            
            return $"Shipping Id: {shippingId} {Environment.NewLine}" +
                   $"To:{order.Recipient.To} {Environment.NewLine}" +
                   $"Order total:{order.Total} {Environment.NewLine}" +
                   $"Tax:{CustomHandlingOptions.TaxOptions} {Environment.NewLine}" +
                   $"Shipping Cost: {shippingCost}";

        }
        private string GetShippingId()
        {
            // Invoke API with API key

            return Guid.NewGuid().ToString();
        }
    }
}
