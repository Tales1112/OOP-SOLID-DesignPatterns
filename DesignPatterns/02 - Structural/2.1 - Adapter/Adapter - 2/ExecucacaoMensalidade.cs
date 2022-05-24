namespace DesignPatterns._02___Structural._2._1___Adapter.Adapter___2
{
    public class ExecucacaoMensalidade
    {
        public static void Executar()
        {
            string[,] alunosArray = new string[5, 4]
         {
                {"101","Maria","Artes","1000"},
                {"102","Pedro","Engenharia","2000"},
                {"103","Bianca","Veterinária","3000"},
                {"104","Pamela","Moda","900"},
                {"105","Sergio","Desenho","850"}
         };
            var mensalidade = new MensalidadeService(new AlunoAdapter());
            mensalidade.ProcesarMensalidade(alunosArray);
        }
    }
}
