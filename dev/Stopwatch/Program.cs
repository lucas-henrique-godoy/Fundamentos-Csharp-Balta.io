using System;  // Importa a biblioteca System para uso de funcionalidades básicas, como Console.
using System.Threading;  // Importa a biblioteca para controlar threads e usar o método Thread.Sleep.

namespace Stopwatch  // Define o namespace para o programa.
{
    class Program  // Define a classe Program, que contém o código principal do programa.
    {
        static void Main(string[] args)  // Método principal de execução do programa.
        {
            Start();  // Chama o método Start, que inicia o cronômetro.
        }

        static void Start()  // Método responsável por simular o funcionamento de um cronômetro.
        {
            int time = 10;  // Define o tempo total que o cronômetro irá contar (10 segundos).
            int currentTime = 0;  // Variável que mantém o tempo atual do cronômetro, começando de 0.

            // Enquanto o tempo atual não for igual ao tempo total (10 segundos).
            while (currentTime != time)
            {
                Console.Clear();  // Limpa o console para que o valor atualizado seja mostrado na tela.
                currentTime++;  // Incrementa o valor de currentTime em 1 a cada iteração.
                Console.WriteLine(currentTime);  // Exibe o valor de currentTime no console.
                Thread.Sleep(1000);  // Faz o programa "dormir" por 1000 milissegundos (1 segundo).
            }
        }
    }
}
