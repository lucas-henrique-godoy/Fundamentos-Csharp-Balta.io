using System;

namespace FormatarDatas2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = DateTime.Now;

            var formatada = string.Format("{0:t}", data);
            var formatada = string.Format("{0:T}", data);
            var formatada = string.Format("{0:d}", data);
            
            Console.WriteLine(formatada);
        }
    }
}




