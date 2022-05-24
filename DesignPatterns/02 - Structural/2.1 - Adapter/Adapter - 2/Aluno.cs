namespace DesignPatterns._02___Structural._2._1___Adapter.Adapter___2
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Curso { get; set; }
        public decimal Mensalidade { get; set; }

        public Aluno(int id, string nome,string curso, decimal mensalidade)
        {
            Id = id;
            Nome = nome;
            Curso = curso;
            Mensalidade = mensalidade;
        }
    }
}
