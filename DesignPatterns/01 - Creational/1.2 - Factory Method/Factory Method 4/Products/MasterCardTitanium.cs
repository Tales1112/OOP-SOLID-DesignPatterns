namespace DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_4
{
    public class MasterCardTitanium : IMasterCard
    {
        public string GetCardType()
        {
            return "MasterCard Titanium";
        }
        public int GetCreditLimit()
        {
            return 75000;
        }
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
}

