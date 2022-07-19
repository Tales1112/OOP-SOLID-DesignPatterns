using DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_3.Commerce;

namespace DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_3.Shipping
{
    // Abstract Product 
    public abstract class ShippingProvider
    {
        public ShippingCostCalculator ShippingCostCalculator { get; set; }
        public CustomsHandlingOptions CustomHandlingOptions { get; set; }
        public InsuranceOptions InsuranceOptions { get; set; }

        public bool RequiredSignature { get; set; }

        public abstract string GenerateShippingLabelFor(Order order);
    }
}
