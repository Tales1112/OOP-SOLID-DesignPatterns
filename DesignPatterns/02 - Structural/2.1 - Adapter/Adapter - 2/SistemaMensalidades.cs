using System;
using System.Collections.Generic;

namespace DesignPatterns._02___Structural._2._1___Adapter.Adapter___2
{
    //Adaptee Class
    public class SistemaMensalidades
    {
        public void CalculaMensalidade(List<Aluno> listaAlunos)
        {
            foreach (Aluno aluno in listaAlunos)
            {
                Console.WriteLine($"Aluno {aluno.Nome} " +
                         $"- Valor da mensalidade R$ {aluno.Mensalidade}");
            }
        }
    }
}
