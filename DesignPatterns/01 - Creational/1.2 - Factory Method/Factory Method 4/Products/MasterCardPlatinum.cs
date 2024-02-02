namespace DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_4
{
    public class MasterCardPlatinum : IMasterCard
    {
        public string GetCardType()
        {
            return "MasterCard Platinum";
        }
        public int GetCreditLimit()
        {
            return 55000;
        }
        public int GetAnnualCharge()
        {
            return 1000;
        }
    }
}

