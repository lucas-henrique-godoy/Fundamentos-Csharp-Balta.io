using System;

namespace FormatarDatas2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); // Limpa o console para exibir uma saída limpa.

var data = DateTime.Now; // Obtém a data e hora atual do sistema e armazena na variável 'data'.

// Formata a hora atual no formato de 24 horas (ex: 15:30)
var formatada = string.Format("{0:t}", data); // Formato de hora curta

// Formata a hora atual no formato completo (ex: 15:30:45)
var formatada = string.Format("{0:T}", data); // Formato de hora longa

// Formata a data no formato curto (ex: 07/12/2024)
var formatada = string.Format("{0:d}", data); // Formato de data curta

// Formata a data no formato longo (ex: sábado, 7 de dezembro de 2024)
var formatada = string.Format("{0:D}", data); // Formato de data longa

// Formata a data e hora no formato completo (ex: sábado, 7 de dezembro de 2024 15:30)
var formatada = string.Format("{0:f}", data); // Formato de data e hora completa

// Formata a data e hora no formato genérico (ex: 07/12/2024 15:30)
var formatada = string.Format("{0:g}", data); // Formato genérico

// Formata a data e hora no formato de RFC1123 (ex: Sat, 07 Dec 2024 15:30:00 GMT)
var formatada = string.Format("{0:r}", data); // Formato de RFC1123

// Formata a data e hora no formato de RFC1123 (sem diferenças em relação ao anterior)
var formatada = string.Format("{0:R}", data); // Formato de RFC1123 (idêntico ao anterior)

// Formata a data e hora no formato de 24 horas para armazenar de forma compacta (ex: 2024-12-07T15:30:00)
var formatada = string.Format("{0:s}", data); // Formato de data e hora de forma compacta (ISO 8601)

// Formata a data e hora no formato universal (ex: 2024-12-07 15:30:00Z)
var formatada = string.Format("{0:u}", data); // Formato de data e hora universal (UTC)

Console.WriteLine(formatada); // Exibe a data e hora formatada no console.

        }
    }
}




