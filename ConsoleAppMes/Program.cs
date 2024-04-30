using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
              string[] meses = new string[]
                {
            "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
            "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"
                };

              
                Console.Write("Digite o número do mês (1 a 12): ");
                int numeroMes;

              
                bool sucesso = int.TryParse(Console.ReadLine(), out numeroMes);

               
                if (sucesso && numeroMes >= 1 && numeroMes <= 12)
                {
                    
                    string nomeMes = meses[numeroMes - 1];
                    Console.WriteLine($"O mês escolhido foi: {nomeMes}");
                }
                else
                {
                    Console.WriteLine("Número inválido! Por favor, digite um número entre 1 e 12.");
                }

               
                Console.WriteLine("Pressione qualquer tecla para encerrar...");
                Console.ReadKey();
            }
        }
    }
    

