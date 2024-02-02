using DesignPatterns._02___Structural._2._4___Decorator.Component;
using DesignPatterns._02___Structural._2._4___Decorator.Concrete_Decorator;

namespace DesignPatterns._02___Structural._2._4___Decorator.Concrete_Component
{
    public class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza) : base(pizza)
        {
        }
        public override string Opicionais()
        {
            var pizza = base.Opicionais();
            pizza += "\r\n com porcao extra de bacon";
            return pizza;   
        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 4.00M;
            return preco;
        }
    }
}
