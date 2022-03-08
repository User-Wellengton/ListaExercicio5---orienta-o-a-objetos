using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    internal class salario
    {
        public double salarioTotal;
        public double salarioBase = 1000;
        public double totalDeVendas = 50000;
        public double comissao = 0.05 ;
        public double salarioComissao;


        public double calculoComissao()
        {
           salarioComissao = totalDeVendas * comissao;
            return salarioComissao; 
        }
        public double calculoSalario()
        {
            salarioTotal = salarioBase + salarioComissao;
            return salarioTotal;    
        }




    }
}
