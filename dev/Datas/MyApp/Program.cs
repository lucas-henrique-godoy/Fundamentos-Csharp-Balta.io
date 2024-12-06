using System;


namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            var data = new DateTime(2024, 12, 06, 10, 17, 00);
            //var data = DateTime.Now; // Pega a data e hora atual
            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);
            Console.WriteLine(data.DayOfWeek); //Console.WriteLine((int)data.DayOfWeek) --> mostra o número correpondente ao dia da semana.
        }
    }
}


