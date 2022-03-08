using System;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            moldeCilindro cilindro = new moldeCilindro();


            Console.WriteLine("Insira o raio:");
            cilindro.raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a altura:");
            cilindro.altura = double.Parse(Console.ReadLine());

            // chama metodo
            cilindro.calcularVolume();

            double resultado = cilindro.calcularVolume();

            Console.WriteLine("O volume do cilindro é de: " + resultado + "m³");

            Console.ReadLine();

        }
    }
}
