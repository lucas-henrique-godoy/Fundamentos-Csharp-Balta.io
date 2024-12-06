using System;

namespace FormatarDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = DateTime.Now;

            var formatada = String.Format("{0:M}", data);
            Console.WriteLine(formatada);
        }
    }
}


