using System;

namespace ComparacaoDeStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definindo a primeira string para comparação
            var texto = "Testando";

            // CompareTo realiza uma comparação lexicográfica:
            // Compara 'texto' com "Testando". Como as duas strings são idênticas, o retorno será 0.
            Console.WriteLine(texto.CompareTo("Testando"));  // Saída: 0

            // CompareTo compara 'texto' com "testando".
            // Como "Testando" (com 'T' maiúsculo) vem antes de "testando" (com 't' minúsculo),
            // o retorno será negativo (porque 'T' é considerado menor que 't' em uma comparação lexicográfica).
            Console.WriteLine(texto.CompareTo("testando"));  // Saída: valor negativo (< 0)

            // Agora, definindo uma nova string para demonstrar o uso do Contains
            var texto2 = "Este texto é um teste";

            // Contains verifica se a string 'texto2' contém a substring "teste".
            // Aqui, a string contém exatamente "teste", então o resultado será 'true'.
            Console.WriteLine(texto2.Contains("teste"));  // Saída: True

            // Contains verifica se a string 'texto2' contém a substring "Teste".
            // A busca é sensível a maiúsculas/minúsculas, então o "T" maiúsculo não é igual ao "t" minúsculo.
            // Portanto, o resultado será 'false'.
            Console.WriteLine(texto2.Contains("Teste"));  // Saída: False

            // Contains com a sobrecarga que permite especificar uma comparação que ignora maiúsculas/minúsculas
            // O StringComparison.CurrentCultureIgnoreCase ignora a diferenciação entre maiúsculas e minúsculas.
            // Como estamos ignorando o caso, a comparação será 'true', pois "Teste" e "teste" são considerados iguais.
            Console.WriteLine(texto2.Contains("teste", StringComparison.CurrentCultureIgnoreCase));  // Saída: True
            
            // Verificando o caso onde o parâmetro passado para Contains é null
            // Isso lançaria uma exceção se tentássemos comparar uma string com null.
            // Nesse caso, 'Contains' irá retornar 'False' porque uma string não pode conter 'null'.
            Console.WriteLine(texto2.Contains(null));  // Saída: False (não pode conter null)
        }
    }
}
