using System;

namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();  
          aluno.nota1 = 10;
          aluno.nota2 = 10;

            Console.WriteLine("Media Ponderada do alunoé :" + aluno.calculoMediaPonderada());




        }
    }
}
