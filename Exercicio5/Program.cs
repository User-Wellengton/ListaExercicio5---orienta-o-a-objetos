using System;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            moldeEsfera esfera = new moldeEsfera();


            Console.WriteLine("Informe o valor do raio da esfera do dração:");
            esfera.raio = double.Parse(Console.ReadLine());


            esfera.calculoVolumeEsfera();

            double resultado = esfera.volume;
            Console.WriteLine("O volume da esfera do dração é de: " + resultado + "m³");

            Console.ReadLine();


        }
    }
}
