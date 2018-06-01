using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quina
{
    class Apostas
    {

        public static int NumeroApostas = 0;
        int[] VetorNumeros = new int[5];
        int NumeroCartela;

        public Apostas(int[] VetorNumeros, int NumeroCartela)
        {
            this.VetorNumeros = VetorNumeros;
            this.NumeroCartela = NumeroCartela;
        }


        public int[] GetApostas()
        {
            return VetorNumeros;
        }

        public int GetNumeroCartela()
        {
            return NumeroCartela;
        }
    }
}
