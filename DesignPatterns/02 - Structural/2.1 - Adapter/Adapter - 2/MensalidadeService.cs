namespace DesignPatterns._02___Structural._2._1___Adapter.Adapter___2
{
    //Client
    public class MensalidadeService
    {
        private readonly ITarget _target;

        public MensalidadeService(ITarget target)
        {
            _target = target;
        }

        public void ProcesarMensalidade(string[,] alunosArray)
        {
            _target.ProcessaCalculoMensalidade(alunosArray);
        }
    }
}
