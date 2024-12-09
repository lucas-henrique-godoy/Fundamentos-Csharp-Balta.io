using System;

namespace ExemploTimespan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timesSpanNanoSegundos = new TimeSpan(1);
            Console.WriteLine(timesSpanNanoSegundos);

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
            System.Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundoMiliSegundo=  new TimeSpan(15, 12, 55, 8, 100);
            System.Console.WriteLine(timeSpanDiaHoraMinutoSegundoMiliSegundo);

            Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

        }
    }
}
