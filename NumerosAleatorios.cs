using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quina
{
    public class NumerosAleatorios
    {

        public static int[] Gerador()
        {

            Random random = new Random();
            int[] aleatorio = new int[5];


            for (int j = 0; j < 5; j++)
            {
                aleatorio[j] = random.Next(1,60); // PREENCHE O VETOR!
            }

                for (int x = 0; x < 5; x++) // VARIAÇÂO DO PRIMEIRO VETOR
                {
                    for (int y = 0; y < 5; y++) // VARIAÇÂO DO VETOR QUE DESEJA COMPARAR
                    {
                        if (x != y) // SO IRA COMPARAR CASO A POSIÇÂO SEJA DIFERENTE, POIS SE FOR POSIÇÂO IGUAL OS NUMEROS SÂO IGUAIS ;)
                        {
                            if (aleatorio[x] == aleatorio[y]) // VERIFICA SE A POSIÇÃO È IGUAL
                            {
                                Console.WriteLine("O ALGORITMO SORTEOU O MESMO NÚMERO, IREI SORTEAR NOVAMENTE!");
                                aleatorio[y] = random.Next(1, 60); // SORTEIA NOVAMENTE OS NUMEROS
                            }
                        }

                     }
                 }

            return aleatorio;
            }
        }
    }


