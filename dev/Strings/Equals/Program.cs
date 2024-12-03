using System;  // Importa o namespace System, que contém classes essenciais como Console e String.

namespace Equals  // Define o namespace chamado "Equals" para organizar o código.
{
    class Program  // Define a classe Program, que contém o método principal (Main).
    {
        static void Main(string[] args)  // Define o ponto de entrada do programa, o método Main.
        {
            var texto = "Este texto é um teste";  // Declara uma variável chamada 'texto' e a inicializa com a string "Este texto é um teste".

            Console.WriteLine(texto.Equals("Este texto é um teste"));  // Compara 'texto' com a string "Este texto é um teste" usando o método Equals, que verifica se são iguais. Retorna true porque o conteúdo é o mesmo.
            Console.WriteLine(texto.Equals("este texto é um teste"));  // Compara 'texto' com "este texto é um teste", mas a comparação é sensível a maiúsculas e minúsculas, então retorna false, pois a primeira letra "E" é maiúscula e a segunda é minúscula.
            Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));  // Compara 'texto' com "este texto é um teste" usando uma comparação que ignora diferenças de maiúsculas/minúsculas (OrdinalIgnoreCase), então retorna true, pois considera que "E" e "e" são iguais.
        }
    }
}
