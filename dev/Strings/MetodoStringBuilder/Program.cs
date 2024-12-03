using System; // Importa o namespace System, que contém classes fundamentais, como Console e StringBuilder.
using System.Text; // Importa o namespace System.Text, que contém a classe StringBuilder, usada para manipulação eficiente de strings.

namespace MetodoStringBuilder // Define um namespace chamado MetodoStringBuilder. Isso organiza o código em uma estrutura hierárquica.
{
    class Program // Define a classe Program, que contém o ponto de entrada do aplicativo.
    {
        static void Main(string[] args) // Define o método Main, que é o ponto de entrada do programa, onde a execução começa.
        {
            var texto = new StringBuilder(); // Cria uma nova instância de StringBuilder chamada 'texto'. StringBuilder é usado para construir strings de forma eficiente.
            texto.Append("Este texto é um teste"); // Adiciona a string "Este texto é um teste" ao final de 'texto'.
            texto.Append("é um teste"); // Adiciona a string "é um teste" ao final de 'texto'.
            texto.Append("Este texto"); // Adiciona a string "Este texto" ao final de 'texto'.
            texto.Append("Este um teste"); // Adiciona a string "Este um teste" ao final de 'texto'.

            // texto.ToString(); Nesse caso não precisou converter, mas com outros objetos talvez necessite
            // A conversão para string (ToString()) não é necessária aqui, pois o Console.WriteLine já pode trabalhar diretamente com o StringBuilder.

            Console.WriteLine(texto); // Imprime o conteúdo acumulado em 'texto' no console. O método WriteLine converte automaticamente o StringBuilder em uma string.
        }
    }
}
