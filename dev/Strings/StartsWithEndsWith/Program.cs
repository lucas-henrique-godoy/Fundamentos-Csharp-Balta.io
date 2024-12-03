using System;

namespace StartsWithEndsWith // Definindo o namespace para o programa
{
    class Program // Definindo a classe principal do programa
    {
        static void Main(string[] args) // Método principal, ponto de entrada do programa
        {
            var texto = "Este texto é um teste"; // Definindo uma variável 'texto' com uma string específica

            Console.WriteLine("StartsWith: \n"); // Exibindo um título indicando que vamos verificar o método StartsWith

            Console.WriteLine(texto.StartsWith("Este")); // Verificando se a string 'texto' começa com "Este" (case-sensitive)
            Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase)); // Ignorando maiúsculas/minúsculas, verificando se começa com "este"
            Console.WriteLine(texto.StartsWith("texto")); // Verificando se a string 'texto' começa com "texto" (case-sensitive)

            Console.WriteLine("-------------------------------------------------"); // Exibindo uma linha separadora para clareza visual

            Console.WriteLine("EndsWith: \n"); // Exibindo um título indicando que vamos verificar o método EndsWith

            Console.WriteLine(texto.EndsWith("teste")); // Verificando se a string 'texto' termina com "teste" (case-sensitive)
            Console.WriteLine(texto.EndsWith("Teste")); // Verificando se a string 'texto' termina com "Teste", com distinção de maiúsculas/minúsculas
            Console.WriteLine(texto.EndsWith("xpto")); // Verificando se a string 'texto' termina com "xpto" (não existe, então será falso)
        }
    }
}
