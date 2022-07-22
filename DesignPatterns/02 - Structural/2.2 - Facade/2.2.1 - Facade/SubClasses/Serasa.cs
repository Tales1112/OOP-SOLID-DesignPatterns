namespace DesignPatterns._02___Structural._2._2___Facade._2._2._1___Facade.SubClasses
{
    public class Serasa
    {
        public bool EstaNoSerasa(Cliente cliente)
        {
            System.Console.WriteLine("Verificando SERASA do cliente " + cliente.Nome);
            return false;
        }
    }
}
