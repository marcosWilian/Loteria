using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Quina
{
    class Program
    {
        static void Main(string[] args)
        {
            Apostas[] Apostas = new Apostas[1000];
            Cartela[] Cartelas = new Cartela[10000];
            MinhaInterface minhaInterface = new MinhaInterface();

            // LE ARQUIVO APOSTAS E PASSA PARA A MEMÓRIA
            ArquivoApostas arquivo_ap = new ArquivoApostas(); // criação de instancia para a clase Arquivo Apostas
            StreamReader recebe = arquivo_ap.AbreArqR();

            arquivo_ap.LeTexto(recebe, Apostas);
            arquivo_ap.FechaArq(recebe);


            // LE ARQUIVO CARTELA E PASSA PARA A MEMÓRIA
            ArquivoCartela arquivo_ca = new ArquivoCartela(); // criação de instancia para a clase Arquivo Apostas
            StreamReader recebe_ca = arquivo_ca.AbreArqR();

            arquivo_ca.LeTexto(recebe_ca, Cartelas);
            arquivo_ca.FechaArq(recebe_ca);



            int menu = 0;
            while (menu != 5)
            {

                Console.WriteLine("1 - Apostar na cartela atual");
                Console.WriteLine("2 - Mostrar Todas as Apostas");
                Console.WriteLine("3 - Sortear a cartela atual");
                Console.WriteLine("4 - Mostrar Lista de todas as cartelas já sorteadas e quantidade de ganhadores");

                Console.WriteLine("5- Sair");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        minhaInterface.Apostar(Apostas);
                        StreamWriter file = arquivo_ap.AbreArqW();
                        arquivo_ap.SalvaTexto(file, Apostas); // SALVA O ULTIMO CLIENTE CADASTRADO NA MEMORIA
                        arquivo_ap.FechaArq(file); // FECHA O ARQUIVO



                        break;
                    case 2:
                        minhaInterface.MostarApostas(Apostas);
                        break;
                    case 3:
                        minhaInterface.Sortear(Apostas, Cartelas);
                        StreamWriter file_cartela = arquivo_ca.AbreArqW();
                        arquivo_ca.SalvaTexto(file_cartela, Cartelas); // SALVA O ULTIMO CLIENTE CADASTRADO NA MEMORIA
                        arquivo_ca.FechaArq(file_cartela); // FECHA O ARQUIVO


                        break;

                    case 4:
                        minhaInterface.MostrarCartelas(Cartelas);
                        break;
                    case 5:
                        menu = 5;
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }
        }
    }
}
