using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campeonatoFutebol
{
    internal class Program
    {
        public static void Campeonato()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("CAMPEONATO FUTEBOL");
            Console.WriteLine("------------------");
        }
        public static void Tabela()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine(" TABELA DE PARTIDAS");
            Console.WriteLine("-------------------");
        }
        static void Main(string[] args)
        {
            Campeonato();

            string[] times = new string[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Nome do {i + 1}o. time: ");
                times[i] = Console.ReadLine();
            }

            Console.Clear();

            Tabela();

            for (int j = 0; j < 3; j++)
            {
                for (int f = 0; f < 3; f++)
                {
                    if (times[j] != times[f])
                    {
                        Console.WriteLine(String.Format($"{times[j],-13} [] x [] {times[f],1}"));
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
