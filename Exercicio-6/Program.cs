﻿using System;

namespace Exercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // (classe/ molde ) (objeto)
            converterCparaF converter = new converterCparaF();


            Console.WriteLine("Insira a temperatura desejada em Celsius:");
            converter.tempC = double.Parse(Console.ReadLine());


            // chamando a classe 
            converter.converterParaF();


            // chamar RESULTADO esta recebendo 
            double resultado = converter.converterParaF();


            Console.WriteLine(" A temperatura apresentada em Celsius é de :" + converter.tempC + " °C");
            Console.WriteLine("A temperatuda convertida para Fahrenheit é de: " + resultado + " °F");

            Console.ReadLine();




        }
    }
}
