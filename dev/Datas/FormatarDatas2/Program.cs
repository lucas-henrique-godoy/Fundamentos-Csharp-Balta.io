using System;
using System.Datetime;

namespace FormatarDatas2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = Datetime.Now;

            var formatada = string.Format("{0:t}", data)
            Console.WriteLine(formatada);
        }
    }
}




