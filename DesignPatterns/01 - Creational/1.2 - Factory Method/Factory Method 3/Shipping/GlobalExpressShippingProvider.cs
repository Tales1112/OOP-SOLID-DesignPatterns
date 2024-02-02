using DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_3.Commerce;

namespace DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_3.Shipping
{
    // Concrete Product
    public class GlobalExpressShippingProvider : ShippingProvider
    {
        public override string GenerateShippingLabelFor(Order order)
        {
            return "GLOBAL-EXPRESS";
        }
    }
}
