using System;


namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();  // Limpa o console para que a saída seja exibida de forma limpa

            // Cria um objeto DateTime com a data e hora especificadas (6 de dezembro de 2024, às 10:17:00)
            var data = new DateTime(2024, 12, 06, 10, 17, 00);  

            // A linha abaixo está comentada. Se ativada, ela irá pegar a data e hora atual do sistema
            // var data = DateTime.Now; // Pega a data e hora atual

            Console.WriteLine(data);  // Exibe a data e hora completa (2024-12-06 10:17:00)

            Console.WriteLine(data.Year);  // Exibe o ano da data (2024)

            Console.WriteLine(data.Month);  // Exibe o mês da data (12)

            Console.WriteLine(data.Hour);  // Exibe a hora da data (10)

            Console.WriteLine(data.Minute);  // Exibe o minuto da data (17)

            Console.WriteLine(data.Second);  // Exibe o segundo da data (00)

            Console.WriteLine(data.DayOfWeek);  // Exibe o nome do dia da semana (por exemplo, "Friday" se for sexta-feira)
            // A linha abaixo (comentada) exibe o número correspondente ao dia da semana
            // Console.WriteLine((int)data.DayOfWeek); // Exibe o número do dia da semana (0 para domingo, 1 para segunda-feira, etc.)

            Console.WriteLine(data.DayOfYear);  // Exibe o número do dia do ano (341 no caso de 6 de dezembro)

        }
    }
}


