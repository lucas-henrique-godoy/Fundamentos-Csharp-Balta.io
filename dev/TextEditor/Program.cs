using System;  // Importa a biblioteca System, que contém classes e funcionalidades básicas, como Console e tipos de dados.
using System.IO;  // Importa a biblioteca System.IO, que fornece classes para manipulação de arquivos, como StreamReader e StreamWriter.

namespace TextEditor  // Define o namespace (espaço de nomes) que agrupa o código. Aqui, ele é chamado TextEditor.
{
    class Program  // Define a classe Program, onde o código principal será executado.
    {
        // O método Main é o ponto de entrada do programa. Toda aplicação C# começa pela execução desse método.
        static void Main(string[] args)  
        {
            Menu();  // Chama o método Menu(), que exibe as opções para o usuário.
        }

        // Método Menu exibe as opções de escolha do usuário (abrir, criar ou sair).
        static void Menu()  
        {
           Console.Clear();  // Limpa o console, removendo qualquer saída anterior para deixar a tela limpa.
           Console.WriteLine("O que você deseja fazer?");  // Exibe a mensagem perguntando o que o usuário quer fazer.
           Console.WriteLine("1 - Abrir arquivo");  // Exibe a opção 1: Abrir arquivo.
           Console.WriteLine("2 - Criar um novo arquivo");  // Exibe a opção 2: Criar um novo arquivo.
           Console.WriteLine("0 - Sair");  // Exibe a opção 0: Sair do programa.

           short option = short.Parse(Console.ReadLine());  // Lê a opção digitada pelo usuário e converte para um número inteiro curto (short).

           // A estrutura switch seleciona a ação dependendo da opção digitada.
           switch(option)
           {
                case 0:  // Caso o usuário digite 0 (sair), o programa será fechado.
                    System.Environment.Exit(0);  // Encerra a execução do programa.
                    break;  // Sai do switch.
                case 1:  // Caso o usuário escolha 1 (abrir arquivo), chama o método Abrir.
                    Abrir();
                    break;
                case 2:  // Caso o usuário escolha 2 (criar um novo arquivo), chama o método Editar.
                    Editar();
                    break;                
                default:  // Se o usuário digitar uma opção inválida, o menu será mostrado novamente.
                    Menu();
                    break;
           }
        }

        // Método Abrir solicita o caminho do arquivo e o exibe na tela.
        static void Abrir()  
        {
            Console.Clear();  // Limpa a tela antes de exibir o conteúdo.
            Console.WriteLine("Qual caminho do arquivo?");  // Pergunta ao usuário o caminho do arquivo a ser aberto.
            string path = Console.ReadLine();  // Lê o caminho do arquivo digitado pelo usuário.

            // Usa o StreamReader para abrir o arquivo e ler o conteúdo dele.
            using (var file = new StreamReader(path))  
            {
                string text = file.ReadToEnd();  // Lê todo o conteúdo do arquivo e armazena na variável 'text'.
                Console.WriteLine(text);  // Exibe o conteúdo do arquivo na tela.
            }

            Console.WriteLine("");  // Adiciona uma linha em branco para formatação.
            Console.ReadLine();  // Aguarda o usuário pressionar uma tecla antes de continuar.
            Menu();  // Chama o método Menu novamente, para que o usuário possa escolher outra ação.
        }

        // Método Editar permite ao usuário digitar um novo texto e salvar em um arquivo.
        static void Editar()  
        {
            Console.Clear();  // Limpa a tela antes de iniciar a edição.
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");  // Instrução para o usuário.
            Console.WriteLine("---------------------------------");  // Uma linha de separação para melhorar a visualização.

            string text = "";  // Inicializa a variável 'text' onde o texto digitado será armazenado.

            // O loop continua pedindo entrada do usuário até que a tecla ESC seja pressionada.
            do
            {
                text += Console.ReadLine();  // Lê uma linha digitada pelo usuário e adiciona ao texto.
                text += Environment.NewLine;  // Adiciona uma quebra de linha ao texto digitado.
            } while (Console.ReadKey().Key != ConsoleKey.Escape);  // A execução continua até o usuário pressionar ESC.

            Salvar(text);  // Após o usuário pressionar ESC, chama o método Salvar para armazenar o texto digitado.
        }

        // Método Salvar permite ao usuário salvar o texto digitado em um arquivo.
        static void Salvar(string text)  
        {
            Console.Clear();  // Limpa a tela antes de pedir o caminho do arquivo.
            Console.WriteLine("Qual caminho para salvar o arquivo?");  // Solicita o caminho onde o arquivo será salvo.
            var path = Console.ReadLine();  // Lê o caminho digitado pelo usuário.

            // Usa o StreamWriter para criar (ou sobrescrever) o arquivo e escrever o texto nele.
            using (var file = new StreamWriter(path))  
            {
                file.Write(text);  // Escreve o conteúdo da variável 'text' no arquivo especificado pelo caminho.
            }

            // Exibe uma mensagem confirmando que o arquivo foi salvo com sucesso.
            Console.WriteLine($"Arquivo {path} salvo com sucesso!");  
            Console.ReadLine();  // Aguarda o usuário pressionar uma tecla antes de continuar.
            Menu();  // Chama o método Menu novamente, para que o usuário possa escolher outra ação.
        }
    }
}
