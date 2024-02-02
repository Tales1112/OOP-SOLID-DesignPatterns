using DesignPatterns._02___Structural._2._4___Decorator.Component;

namespace DesignPatterns._02___Structural._2._4___Decorator.Concrete_Decorator
{
    public class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza; 
        }

        public virtual string Opicionais()
        {
            var pizza = _pizza.Opicionais();
            return pizza; 
        }

        public virtual decimal Preco()
        {
            var preco = _pizza.Preco();
            return preco;
        }
    }
}
