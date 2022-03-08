using System;

namespace ListaExercicio5.ConsoleApp
{
    internal class Exercicio1
    {
        static void Main(string[] args)
        {
            caixaRetangular calculo = new caixaRetangular();

            Console.WriteLine("Insira valor pra altura:");
            calculo.altura = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Insira valor pra comprimento:");
            calculo.comprimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira valor pra largura:");
            calculo.largura = int.Parse(Console.ReadLine());


            int resultado = calculo.calcularVolumeRetangulo();

            Console.WriteLine("O resultado do calculo do volume do retangulo é de: " + resultado + "m³");
            Console.ReadKey();  








        }
    }
}
