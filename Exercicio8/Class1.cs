using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    internal class LataOleo
    {
        public double raio;
        public double altura;
        

        public double calculoVolumeLata()
        {

             double volumeLata = 3.14 * (raio * raio ) * altura;

            return volumeLata;



        }



    }
}
