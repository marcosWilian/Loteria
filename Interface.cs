using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quina
{
    class MinhaInterface
    {

        public void Apostar(Apostas[] x)
        {
            int[] RecebeAposta = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();

                Console.WriteLine("Digite "+ i + " de Número 1 - 60 ");
                RecebeAposta[i] = int.Parse(Console.ReadLine());

                if (RecebeAposta[i] >= 1 && RecebeAposta[i] <= 60)
                {
                    // CHECA SE O NUMERO ANTERIOR É IGUAL AO ULTIMO DIGITADO
                    for (int j = 0; j < i; j++)
                    {
                        if (RecebeAposta[i] == RecebeAposta[j]){
                            Console.Clear();
                            Console.WriteLine("NÃO PODE DIGITAR O MESMO NÚMERO!");
                            i--; // VOLTA UM PQ O CIDADÂO DIGITOU ERRADO
                        }
                    }
                    //  OK é está dentro do parametro, PULA O LAÇO ELSE
                }
                else
                {
                    Console.WriteLine("Digite um Número entre 1 e 60");

                    i--;
                }

            }
            Console.Clear();

            x[Apostas.NumeroApostas] = new Apostas(RecebeAposta,Cartela.NumeroCartelas);
            Apostas.NumeroApostas++;
             // Contador de Apostas

        }

        public void MostarApostas(Apostas[] x)
        {
            Console.Clear();

            int[] RecebeAposta = new int [5];

            Console.WriteLine("Quantidade de Apostas Totais "+Apostas.NumeroApostas); // imprime o numero da cartela

            for (int y = 0; y < Apostas.NumeroApostas; y++) // indice Apostas
            {
                RecebeAposta = x[y].GetApostas();
                Console.Write("Cartela N°: " + x[y].GetNumeroCartela() + "\n"); // imprime o numero da cartela

                for (int i = 0; i < 5; i++) //indice numeros
                {

                    Console.Write(RecebeAposta[i] + "  ");
                }
                Console.WriteLine("\n");
                }
        }


        public void MostrarCartelas(Cartela[] Cartelas)
        {
            int[] RecebeCartela = new int[5];
            Console.Clear();

            for (int j = 0; j < Cartela.NumeroCartelas; j++)
            {
                RecebeCartela = Cartelas[j].GetCartela();
                Console.Write("Cartela N°: " + j + "\nNúmero Sorteado: "); // imprime o numero da cartela

                for (int i = 0; i < 5; i++)
                {
                    Console.Write(RecebeCartela[i] + " ");
                }
                Console.WriteLine("Quantidade de Ganhadores: " + Cartelas[j].GetQuantidadeGanhadores());

            }

            Console.Write("\n");
        }
        public void Sortear(Apostas[] Apostar, Cartela[] Cartelas)
        {
                Cartelas[Cartela.NumeroCartelas] = new Cartela(NumerosAleatorios.Gerador()); // GERA UMA CARTELA COM NÚMEROS ALEATORIOS
                Console.Clear();

              int[] RecebeCartela = new int[5];
              Console.WriteLine("N° Cartela : " + Cartela.NumeroCartelas);

                RecebeCartela = Cartelas[Cartela.NumeroCartelas].GetCartela();
                //Mostra o Número Sorteado
                 Console.WriteLine("Numero Sorteado:");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(RecebeCartela[i] + " ");
                }

                // ESSA PARTE DO CÓDIGO COMPARA OS GANHADORES COM O NÚMERO SORTEADO
                int ganhador = 1; // variavel local para contar os ganhadores por cartela

                     for (int w = 0; w < Apostas.NumeroApostas; w++) // laço para rodar as apóstas
                     {

                         int[] RecebeApostaJogador = new int[5];
                         RecebeApostaJogador = Apostar[w].GetApostas();

                         int contador = 0; // variavel para comparar os vetores, caso maior que 5 os numeros são iguais

                         for (int r = 0; r < 5; r++)
                         {
                             for (int t = 0; t < 5; t++)
                             {
                                 if (RecebeCartela[r] == RecebeApostaJogador[t] && Apostar[w].GetNumeroCartela() == Cartela.NumeroCartelas)
                                 {

                                     contador++; // 5 = numero de verificações para validar a cartela com a aposta
                                     if (contador >= 5)
                                     {
                                         Cartelas[Cartela.NumeroCartelas].SetQuantidadeGanhadores(ganhador++);
                                         
                                     }
                                 }   
                             }
                         }
                     }
                     Console.WriteLine("\nQuantidade de Ganhadores da Cartela:" + Cartelas[Cartela.NumeroCartelas].GetQuantidadeGanhadores());

                Console.WriteLine("\n");
                Cartela.NumeroCartelas++;// CRIA UMA NOVA CARTELA JA QUE A ANTERIOR JÁ FOI SORTEADA


        }

    }
}