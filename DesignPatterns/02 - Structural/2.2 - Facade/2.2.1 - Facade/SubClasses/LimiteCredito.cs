namespace DesignPatterns._02___Structural._2._2___Facade._2._2._1___Facade.SubClasses
{
    public class LimiteCredito
    {
        public bool PossuiLimiteCredito(Cliente cliente, double valor)
        {
            System.Console.WriteLine("Verificando o limite do credito do cliente "  + cliente.Nome);

            if (valor > 200000.0)
                return false;
            else
                return true;
        }
    }
}
