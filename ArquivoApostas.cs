using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Quina
{
    class ArquivoApostas
    {

        static string caminho = Directory.GetCurrentDirectory()+@"/ArquivoAposta.txt"; // SALVA A APLICAÇÂO NO DIRETORIO DO ARQUIVO!

        public StreamWriter AbreArqW()
        {
            StreamWriter arc = new StreamWriter(caminho, false); // CASO ESTEJA DEFINIDO COMO TRUE O CAMINHO JÁ EXISTE!
            return arc;
        }
        public StreamReader AbreArqR()
        {
            StreamReader arc = new StreamReader(caminho, true);// CASO ESTEJA DEFINIDO COMO TRUE O CAMINHO JÁ EXISTE!
            return arc;
        }

        public void SalvaTexto(StreamWriter file, Apostas[] Aposta)
        {
            int[] RecebeApostaJogador = new int[5];

            RecebeApostaJogador = Aposta[Apostas.NumeroApostas-1].GetApostas();
            file.WriteLine(
            RecebeApostaJogador[0] + ";" +
            RecebeApostaJogador[1] + ";" +
            RecebeApostaJogador[2] + ";" + 
            RecebeApostaJogador[3] + ";" +
            RecebeApostaJogador[4] + ";" +
            Aposta[Apostas.NumeroApostas-1].GetNumeroCartela());

            file.Flush();
        }


        public void LeTexto(StreamReader re, Apostas[] Aposta)
        {
            Console.Clear();

            string input = null;
            if (re.ReadLine() != null)
            {
                            int[] RecebeDoArquivo;


                while ((input = re.ReadLine()) != null)
                {
                     RecebeDoArquivo = System.Array.ConvertAll<string, int>(input.Split(';'), i => Convert.ToInt32(i));

                     Aposta[Apostas.NumeroApostas++] = new Apostas(RecebeDoArquivo, RecebeDoArquivo[5]); // esse ultio espaço é referente a cartela
                }


            }        
        }
 

        public void FechaArq(StreamWriter arq)
        {
            arq.Close();
        }
        public void FechaArq(StreamReader arq)
        {
            arq.Close();

        }
    }
    }

