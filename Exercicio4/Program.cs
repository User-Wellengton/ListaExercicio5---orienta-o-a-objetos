using System;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            consumo consumoPorK = new consumo();

            Console.WriteLine("Informe a kilometragem inicial:");
            consumoPorK.kmInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a kilometragem final:");
            consumoPorK.kmFinal = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de gasolina utilizada:");
            consumoPorK.gasolina = double.Parse(Console.ReadLine());

            //chamar a metodo
            consumoPorK.calcularConsumo();

            double resultado = consumoPorK.calcularConsumo();

            Console.WriteLine("O consumo de combustivel por litro é de: " + resultado + "km/l");

            Console.ReadLine();

        }
    }
}
