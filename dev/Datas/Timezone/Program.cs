using System;

namespace Timezone
{
    class Program
    {
        static void Main(string[] args)
        {
            // Limpa o console, removendo qualquer texto exibido anteriormente.
            Console.Clear();

            // Obtém a data e hora atual no formato UTC (Tempo Universal Coordenado).
            var utcDate = DateTime.UtcNow;

            // Exibe a data e hora no formato UTC no console.
            Console.WriteLine(utcDate);

            // Converte a hora UTC para o horário local da máquina onde o código está sendo executado e exibe.
            Console.WriteLine(utcDate.ToLocalTime());

            // Obtém o fuso horário de Auckland (Nova Zelândia), usando o identificador "Pacific/Auckland".
            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");

            // Exibe as informações sobre o fuso horário de Auckland.
            Console.WriteLine(timezoneAustralia);

            // Converte a hora UTC para o horário do fuso horário de Auckland e armazena em "horaAustralia".
            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);

            // Exibe o horário de Auckland convertido no console.
            Console.WriteLine(horaAustralia);



            //Obtém a lista de todos os fusos horários do sistema.
            var timezones = TimeZoneInfo.GetSystemTimeZones();

            //Itera sobre cada fuso horário na lista de fusos horários obtida.
            foreach (var timezone in timezones)
            {
                //Exibe o identificador (ID) do fuso horário no console (exemplo: "Pacific/Auckland").
                Console.WriteLine(timezone.Id);

                //Exibe todas as informações sobre o fuso horário, como nome, UTC offset, etc.
                Console.WriteLine(timezone);

                //Converte a hora UTC para o horário do fuso horário atual da iteração e exibe no console.
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));

                // Exibe uma linha de separação para facilitar a leitura das saídas no console.
                Console.WriteLine("--------------");
            }

        }
    }
}


