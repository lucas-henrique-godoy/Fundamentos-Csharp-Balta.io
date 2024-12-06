using System;

namespace FormatarDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = DateTime.Now;

            
            var formatada = String.Format("{0:yyyy * MM * dd}", data); // Formatando a saida de ano, mes e dia. Existem muitas formas diferentes de formatação.
            Console.WriteLine(formatada);
        }
    }
}


