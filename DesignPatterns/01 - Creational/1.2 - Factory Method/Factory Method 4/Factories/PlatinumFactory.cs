namespace DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_4.Factories
{
    public class PlatinumFactory : ICreditCardFactory
    {
        public IMasterCard CreateMasterCard()
        {
            return new MasterCardPlatinum();
        }
        public IVisa CreateVisa()
        {
            return new VisaPlatinum();
        }
    }
}
