using DesignPatterns._02___Structural._2._2___Facade._2._2._1___Facade.SubClasses;

namespace DesignPatterns._02___Structural._2._2___Facade._2._2._1___Facade.Facade
{
    public class MeuFacade
    {
        private LimiteCredito limite;
        private Serasa serasa;
        private Cadin cadin;
        private Cadastro cadastro;

        public MeuFacade()
        {
            limite = new LimiteCredito();
            serasa = new Serasa();
            cadin = new Cadin();
            cadastro = new Cadastro();
        }

    }
}
