using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    internal class converterCparaF
    {

        // objeto *** caracteristicas 
        public double tempF;
        public double tempC;

        //metodo
        public double converterParaF()
        {

            tempF = (tempC * 1.8)  + 32;

            return tempF;

        }
    }
}