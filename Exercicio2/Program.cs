using System;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {// (classe/ molde ) (objeto)
            converterFParaC converter = new converterFParaC();


            Console.WriteLine("Insira a temperatura desejada em Fahrenheit:");
            converter.tempF = double.Parse(Console.ReadLine());


            // chamando a classe 
            converter.converterParaC();


            // chamar RESULTADO esta recebendo 
            double resultado = converter.converterParaC(); 


            Console.WriteLine(" A temperatura apresentada em Fahrenheit é de :" + converter.tempF + " °F");
            Console.WriteLine("A temperatuda convertida para Celsius é de: " + resultado + " °C");

            Console.ReadLine(); 
        }

        

    }
}
