using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class converterFParaC
    {
        
        
        // objeto *** caracteristicas 
       public double tempF;
       public double tempC;

        //metodo
         public double converterParaC()
        {           

            tempC = (tempF - 32) / 1.8 ;

            return tempC;   
            
        }

    }
}
