using System;  // Importa o namespace necessário para operações básicas do console e manipulação de dados.
using System.Globalization;  // Importa o namespace para controle de culturas (não utilizado diretamente aqui).
using System.Threading;  // Importa o namespace que permite usar a função de "sleep" para pausar a execução.

namespace Stopwatch  // Declaração do namespace "Stopwatch", que é o nome do programa.
{
    class Program  // Definição da classe principal do programa.
    {
        static void Main(string[] args)  // Método principal onde o programa começa a execução.
        {
            Menu();  // Chama o método Menu para exibir as opções para o usuário.
        }

        // Método para exibir o menu e capturar a entrada do usuário.
        static void Menu()
        {
            Console.Clear();  // Limpa o console a cada novo ciclo.
            Console.WriteLine("S = Segundo => 10s = 10 segundos");  // Explica que o 's' representa segundos.
            Console.WriteLine("M = Minuto => 1m = 1 minuto");  // Explica que o 'm' representa minutos.
            Console.WriteLine("0 = Sair");  // Informa que o '0' é para sair do programa.
            Console.WriteLine("Quanto tempo deseja contar?");  // Solicita que o usuário insira o tempo desejado.

            string data = Console.ReadLine().ToLower();  // Lê a entrada do usuário, convertendo para minúsculas.
            char type = char.Parse(data.Substring(data.Length - 1, 1));  // Extrai o último caractere (tipo de unidade: 's' ou 'm').
            int time = int.Parse(data.Substring(0, data.Length - 1));  // Extrai a parte numérica do tempo.
            int multiplier = 1;  // Inicializa o multiplicador como 1 (para segundos).

            // Verifica se a unidade é 'm' (minutos) e ajusta o multiplicador para 60.
            if (type == 'm')
            {
                multiplier = 60;  // 1 minuto = 60 segundos.
            } 
            
            // Se o tempo for 0, o programa sai imediatamente.
            if (time == 0)
            {
                System.Environment.Exit(0);  // Encerra a execução do programa.
            }
            PreStart(time * multiplier);  // Chama o método PreStart para dar o tempo de contagem, multiplicado pela unidade.
        }

        // Método que exibe a contagem regressiva para o início da cronometragem.
        static void PreStart(int time)
        {
            Console.Clear();  // Limpa o console antes de iniciar a contagem regressiva.
            Console.WriteLine("Ready...");  // Exibe "Ready..." para o usuário.
            Thread.Sleep(1000);  // Aguarda 1 segundo.
            Console.WriteLine("Set...");  // Exibe "Set..." para o usuário.
            Thread.Sleep(1000);  // Aguarda 1 segundo.
            Console.WriteLine("Go...");  // Exibe "Go..." para o usuário.
            Thread.Sleep(2500);  // Aguarda 2,5 segundos antes de iniciar a contagem.

            Start(time);  // Chama o método Start para iniciar a contagem do tempo.
        }

        // Método responsável por realizar a contagem do tempo.
        static void Start(int time)
        {
            int currentTime = 0;  // Inicializa o tempo atual como 0.

            // Loop enquanto o tempo atual não atingir o tempo total desejado.
            while (currentTime != time)
            {
                Console.Clear();  // Limpa o console a cada novo segundo.
                currentTime++;  // Incrementa o tempo atual a cada iteração.
                Console.WriteLine(currentTime);  // Exibe o tempo atual na tela.
                Thread.Sleep(1000);  // Aguarda 1 segundo antes de continuar.
            }

            Console.Clear();  // Limpa o console quando a contagem chegar ao fim.
            Console.WriteLine("Stopwatch finalizado");  // Informa que a contagem foi finalizada.
            Thread.Sleep(2500);  // Aguarda 2,5 segundos para o usuário ver a mensagem.

            Menu();  // Chama o método Menu novamente para permitir ao usuário definir outro tempo.
        }
    }
}
/*Este código implementa um cronômetro simples que permite ao usuário contar o tempo em segundos ou minutos. O usuário define o tempo no formato "10s" ou "1m", e o programa começa a contagem até o tempo especificado.*/