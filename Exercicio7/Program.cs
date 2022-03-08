using System;


namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            salario vendedor = new salario();

            
            Console.WriteLine("Salario base:" + vendedor.salarioBase);
            Console.WriteLine("Total de vendas:" + vendedor.totalDeVendas);
            Console.WriteLine("Comissão:" + vendedor.calculoComissao());
            Console.WriteLine("O salatio total do vendedor é de:  R$" + vendedor.calculoSalario());



        }
    }
}
