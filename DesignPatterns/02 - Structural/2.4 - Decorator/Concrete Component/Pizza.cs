using DesignPatterns._02___Structural._2._4___Decorator.Component;

namespace DesignPatterns._02___Structural._2._4___Decorator.Concrete_Component
{
    public class Pizza : IPizza
    {
        public string Opicionais()
        {
            var pizza = "Pizza padrao ou normal";
            return pizza;
        }

        public decimal Preco()
        {
            var preco = 10.00M;
            return preco;
        }
    }
}
