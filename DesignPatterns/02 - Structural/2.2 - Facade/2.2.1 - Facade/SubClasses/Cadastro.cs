namespace DesignPatterns._02___Structural._2._2___Facade._2._2._1___Facade.SubClasses
{
    public class Cadastro
    {
        public void CadastrarCliente(Cliente cliente)
        {
            System.Console.WriteLine($"Cadastro do cliente {cliente.Nome} concluido.");
        }
    }
}
