using System;

namespace ExemploTimespan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();  // Limpa a tela do console antes de exibir as informações

            var timeSpan = new TimeSpan();  // Cria um objeto TimeSpan com valor inicial de 0 (sem dias, horas, minutos, segundos, nem milissegundos)
            Console.WriteLine(timeSpan);  // Exibe o valor do TimeSpan (no caso, será "00:00:00" porque não foi passado nenhum valor)

            var timesSpanNanoSegundos = new TimeSpan(1);  // Cria um TimeSpan com 1 intervalo de 100 nanosegundos
            Console.WriteLine(timesSpanNanoSegundos);  // Exibe o valor do TimeSpan (no caso, será "00:00:00.0000001", representando 1 nanosegundo)

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);  // Cria um TimeSpan com 5 horas, 12 minutos e 8 segundos
            Console.WriteLine(timeSpanHoraMinutoSegundo);  // Exibe o valor do TimeSpan (será "05:12:08")

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);  // Cria um TimeSpan com 3 dias, 5 horas, 50 minutos e 10 segundos
            System.Console.WriteLine(timeSpanDiaHoraMinutoSegundo);  // Exibe o valor do TimeSpan (será "3.05:50:10")

            var timeSpanDiaHoraMinutoSegundoMiliSegundo = new TimeSpan(15, 12, 55, 8, 100);  // Cria um TimeSpan com 15 dias, 12 horas, 55 minutos, 8 segundos e 100 milissegundos
            System.Console.WriteLine(timeSpanDiaHoraMinutoSegundoMiliSegundo);  // Exibe o valor do TimeSpan (será "15.12:55:08.100")

            Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);  // Exibe a diferença entre timeSpanHoraMinutoSegundo e timeSpanDiaHoraMinutoSegundo

            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);  // Exibe o número de dias no TimeSpan timeSpanDiaHoraMinutoSegundo (será 3)

            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));  // Adiciona 12 horas ao TimeSpan timeSpanDiaHoraMinutoSegundo e exibe o resultado

            // Exibe o número de dias no mês de fevereiro de 2020 (leap year), que será 29
            Console.WriteLine(DateTime.DaysInMonth(2020, 2));

            // Chama a função IsWeekend passando o dia atual da semana e verifica se é sábado ou domingo
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));

            // Verifica se a data e hora atual está em horário de verão e exibe o resultado (true ou false)
            System.Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
        }

        static bool IsWeekend(DayOfWeek today)  // Função que verifica se o dia atual é sábado ou domingo
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;  // Retorna true se o dia for sábado ou domingo, caso contrário, retorna false
        }
    }
}
