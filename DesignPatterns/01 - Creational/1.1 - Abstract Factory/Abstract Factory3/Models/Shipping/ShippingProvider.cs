using DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Commerce;

namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Shipping
{
    public abstract class ShippingProvider
    {
        public ShippingCostCalculator ShippingCostCalculator { get; set; }
        public CustomsHandlingOptions CustomHandlingOptions { get; set; }
        public InsuranceOptions InsuranceOptions { get; set; }

        public bool RequireSignature { get; set; }

        public abstract string GenerateShippingLabelFor(Order order);
    }
}
