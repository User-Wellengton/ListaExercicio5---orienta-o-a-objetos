using System;

namespace Exercicio9
{
    internal class Program
    {


        //Crie um programa para calcular a média harmônica das notas de um aluno

        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.WriteLine("Quantas notas deja informar:");
            int n = int.Parse(Console.ReadLine());

            aluno.nota = new double [n];

            for (int i = 0; i < n;i++) { 

            Console.WriteLine("Informe sua nota:");
            aluno.nota[i] = double.Parse(Console.ReadLine());
                                      
            
            }

            double resultado = aluno.calculoMediaHarmonica();
            Console.WriteLine(resultado);

        }
    }
}
