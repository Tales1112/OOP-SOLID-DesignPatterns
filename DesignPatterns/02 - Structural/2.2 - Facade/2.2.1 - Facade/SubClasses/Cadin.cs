namespace DesignPatterns._02___Structural._2._2___Facade._2._2._1___Facade.SubClasses
{
    public class Cadin
    {
        public bool EstaNoCadin(Cliente cliente)
        {
            System.Console.WriteLine("Verificando o CADIN para o cliente " + cliente.Nome);
            return false;
        }
    }
}
