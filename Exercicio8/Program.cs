using System;

namespace Exercicio8
{
    internal class Program
    {        

        static void Main(string[] args)
        {
            LataOleo lata = new LataOleo();

            Console.WriteLine("Informe o valor da altura da lata de óleo:");
            lata.altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informa o valor do raio da lata de óleo:");
            lata.raio = double.Parse(Console.ReadLine());   


            Console.WriteLine(" volume da lata de óleo é de: " + lata.calculoVolumeLata() +"ml" );



        }
    }
}
