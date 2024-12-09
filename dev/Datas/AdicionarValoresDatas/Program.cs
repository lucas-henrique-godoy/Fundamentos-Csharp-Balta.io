using System;

namespace AdicionarValoresDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();  // Limpa a tela do console

            var data = DateTime.Now;  // Obtém a data e hora atuais e a armazena na variável 'data'
            Console.WriteLine(data.AddDays(-12));  // Exibe a data atual, subtraindo 12 dias (data 12 dias atrás)
            Console.WriteLine(data.AddMonths(1));  // Exibe a data atual, adicionando 1 mês
            Console.WriteLine(data.AddYears(1));  // Exibe a data atual, adicionando 1 ano
            Console.WriteLine(data.AddHours(1));  // Exibe a data e hora atuais, adicionando 1 hora

        }
    }
}


