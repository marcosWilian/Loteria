using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Quina
{
    class ArquivoCartela{


        static string caminho = Directory.GetCurrentDirectory()+@"/ArquivoCartela.txt"; // SALVA A APLICAÇÂO NO DIRETORIO DO ARQUIVO!

        public StreamWriter AbreArqW()
        {
            StreamWriter arc = new StreamWriter(caminho, true); // CASO ESTEJA DEFINIDO COMO TRUE O CAMINHO JÁ EXISTE!
            return arc;
        }
        public StreamReader AbreArqR()
        {
            StreamReader arc = new StreamReader(caminho, true);// CASO ESTEJA DEFINIDO COMO TRUE O CAMINHO JÁ EXISTE!
            return arc;
        }

        public void SalvaTexto(StreamWriter file, Cartela[] Cartelas)
        {
            int[] RecebeCartela = new int[5];

            RecebeCartela = Cartelas[Cartela.NumeroCartelas-1].GetCartela();
            file.WriteLine(
            RecebeCartela[0] + ";" +
            RecebeCartela[1] + ";" +
            RecebeCartela[2] + ";" +
            RecebeCartela[3] + ";" +
            RecebeCartela[4] + ";" +
            Cartelas[Cartela.NumeroCartelas-1].GetQuantidadeGanhadores());

            file.Flush();
        }


        public void LeTexto(StreamReader re, Cartela[] Cartelas)
        {
            Console.Clear();

            string input = null;
            if (re.ReadLine() != null)
            {
                            int[] RecebeDoArquivo;


                while ((input = re.ReadLine()) != null)
                {
                     RecebeDoArquivo = System.Array.ConvertAll<string, int>(input.Split(';'), i => Convert.ToInt32(i));
                     Cartelas[Cartela.NumeroCartelas++] = new Cartela(RecebeDoArquivo); // esse ultio espaço é referente a cartela
                     Cartelas[Cartela.NumeroCartelas - 1].SetQuantidadeGanhadores(RecebeDoArquivo[5]);

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
