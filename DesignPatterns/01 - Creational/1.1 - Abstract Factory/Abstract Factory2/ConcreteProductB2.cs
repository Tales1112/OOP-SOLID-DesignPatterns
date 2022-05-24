namespace DesignPatterns._01___Creational._1._1___Abstract_Factory.Abstract_Factory2
{
    public class ConcreteProductB2 : IAbstractProductB
    {
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B2 collaborating with the ({result})";
        }

        public string UsefulFunctionB()
        {
            return "The result of the product B2.";
        }
    }
}
