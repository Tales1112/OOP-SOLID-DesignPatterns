namespace DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_4
{
    public class VisaTitanium : IVisa
    {
        public string GetCardType()
        {
            return "Visa Titanium Edge";
        }
        public int GetCreditLimit()
        {
            return 45000;
        }
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
}

