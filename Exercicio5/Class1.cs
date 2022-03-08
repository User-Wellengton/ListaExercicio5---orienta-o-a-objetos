using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class moldeEsfera
    {
        public double raio;
        public double volume;

        public double  calculoVolumeEsfera()
        {

             volume = 3.14 * Math.Pow( raio, 3) *4 / 3 ;

            return volume;
        }




    }
}
