using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class moldeCilindro
    {
        // objeto *** caracteristicas 

        public double raio;
        public double altura;
        

        //  metodo 

        public double calcularVolume()
        {

            double volume = 3.14 * (raio * raio) * altura;

            return volume;
        } 
    }
}
