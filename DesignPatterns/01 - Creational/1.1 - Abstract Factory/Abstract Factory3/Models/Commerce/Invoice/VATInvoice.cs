using System.Text;

namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory3.Models.Commerce.Invoice
{
    public class VATInvoice : IInvoice
    {
        public byte[] GenerateInvoice()
        {
            return Encoding.Default.GetBytes("Hello world from a VAT Invoice");
        }
    }
}
