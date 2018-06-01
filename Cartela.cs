using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quina
{
    class Cartela
    {
        public static int NumeroCartelas = 0;
        int QuantidadeGanhadores;
        int QuantidadeApostas;

        int[] VetorNumeros = new int[5];

        public Cartela(int[] VetorNumeros)
        {
            this.VetorNumeros = VetorNumeros;
        }


        public int[] GetCartela()
        {
            return VetorNumeros;
        }
        public void SetQuantidadeGanhadores(int QuantidadeGanhadores)
        {
            this.QuantidadeGanhadores = QuantidadeGanhadores;
        }
        public int GetQuantidadeGanhadores()
        {
            return QuantidadeGanhadores;
        }
        public void SetQuantidadeApostas(int QuantidadeApostas)
        {
            this.QuantidadeApostas = QuantidadeApostas;
        }
        public int GetQuantidadeApostas()
        {
            return QuantidadeApostas;
        }

    }
}
