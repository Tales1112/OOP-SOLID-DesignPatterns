namespace DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_4
{
    public class VisaPlatinum : IVisa
    {
        public string GetCardType()
        {
            return "Visa Platinium Edge";
        }
        public int GetCreditLimit()
        {
            return 60000;
        }
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }
}

