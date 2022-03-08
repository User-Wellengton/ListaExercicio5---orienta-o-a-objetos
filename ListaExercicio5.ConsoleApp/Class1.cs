using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicio5.ConsoleApp
{
    internal class caixaRetangular
    {

        public int altura;
        public int largura;
        public int comprimento;


        public int calcularVolumeRetangulo()
        {
            int volume = altura * largura * comprimento;
            return volume;  

        }


    }
}
