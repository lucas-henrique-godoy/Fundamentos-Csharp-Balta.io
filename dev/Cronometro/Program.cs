using System;
using System.Threading;

namespace Cronomettro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string dados = Console.ReadLine().ToLower();
            char tipo = char.Parse(dados.Substring(dados.Length -1));
            short tempo = short.Parse(dados.Substring(0, dados.Length - 1));

           
        }

        static void Start(int time)
        {
            int tempoAtual = 0;

            while (tempoAtual != time)
            {
                Console.Clear();                
                tempoAtual++; 
                Console.WriteLine(tempoAtual); 
                Thread.Sleep(1000);                             
            }

            Console.Clear();
            Console.WriteLine("Cronômetro finalizado");
            Thread.Sleep(2500);
        }
    }
}

