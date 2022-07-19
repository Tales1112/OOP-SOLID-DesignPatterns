using DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Commerce;

namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Shipping
{
    public class GlobalExpressShippingProvider : ShippingProvider
    {
        public override string GenerateShippingLabelFor(Order order)
        {
            return "GLOBAL-EXPRESS";
        }
    }
}
