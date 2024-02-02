namespace DesignPatterns._01___Creational._1._2___Factory_Method.Factory_Method_4.Factories
{
    public class TitaniumFactory : ICreditCardFactory
    {
        public IMasterCard CreateMasterCard()
        {
            return new MasterCardTitanium();
        }
        public IVisa CreateVisa()
        {
           return new VisaTitanium();
        }
    }
}
