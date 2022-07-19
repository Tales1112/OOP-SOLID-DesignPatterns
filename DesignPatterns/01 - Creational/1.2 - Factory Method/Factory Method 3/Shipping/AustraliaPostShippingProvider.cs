using DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_3.Commerce;
using System;

namespace DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_3.Shipping
{
    public class AustraliaPostShippingProvider : ShippingProvider
    {
        private readonly string ClientId;
        private readonly string Secret;

        public AustraliaPostShippingProvider(string clientId, string secret, ShippingCostCalculator shippingCostCalculator,
                                             CustomsHandlingOptions customsHandlingOptions, InsuranceOptions insuranceOptions)
        {
            this.ClientId = clientId;
            this.Secret = secret;
            ShippingCostCalculator = shippingCostCalculator;
            CustomHandlingOptions = customsHandlingOptions;
            InsuranceOptions = insuranceOptions;
        }

        public override string GenerateShippingLabelFor(Order order)
        {
            var shippingId = GetShippingId();

            if (order.Recipient.Country != order.Sender.Country)
            {
                throw new NotSupportedException("International shipping not supported");
            }

            var shippingcost = ShippingCostCalculator.CalculateFor(order.Recipient.Country,
                                                                   order.Sender.Country,
                                                                   order.TotalWeight);

            return $"Shipping Id: {shippingId} {Environment.NewLine}" +
                   $"To: {order.Recipient.To} {Environment.NewLine}" +
                   $"Order total:{order.Total}{Environment.NewLine}" +
                   $"Tax: {CustomHandlingOptions.TaxOptions}{Environment.NewLine}" +
                   $"Shipping Cost: {shippingcost}";
        }
        private string GetShippingId()
        {
            //Call Api
            return $"AUS-{Guid.NewGuid()}";
        }
    }
}
