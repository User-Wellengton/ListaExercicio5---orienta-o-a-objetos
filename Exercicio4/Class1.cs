using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class consumo
    {
        // objeto *** caracteristicas 

        public double kmInicial;
        public double kmFinal;
        public double kmTotal;
        public double gasolina;



        //  metodo 
        public double calcularConsumo()
        {
            kmTotal = kmFinal - kmInicial;

          double consumoKm = kmTotal / gasolina;

            return consumoKm;
        }





    }
}
