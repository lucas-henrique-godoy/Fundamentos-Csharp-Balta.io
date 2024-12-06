using System;

namespace FormatarDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = DateTime.Now;

            
            var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss ff z}", data); // Formatando a saida . Existem muitas formas diferentes de formatação.
            Console.WriteLine(formatada);
        }
    }
}


