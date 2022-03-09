using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    internal class Aluno
    {
        public double[] nota;
        public double notaTotal;
         public double mediaHarmonica;


        public double calculoMediaHarmonica()
        {
            for (int i = 0; i < nota.Length; i++)
            {
                notaTotal = 1/nota[i] + notaTotal;
            }

            mediaHarmonica = n /notaTotal;

            return mediaHarmonica;
        }

    }
}
