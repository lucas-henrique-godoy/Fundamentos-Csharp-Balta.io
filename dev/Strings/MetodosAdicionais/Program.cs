namespace MetodosAdicionais; // Define o namespace "MetodosAdicionais" para organizar o código

class Program // Define a classe "Program"
{
    static void Main(string[] args) // Método principal, ponto de entrada da aplicação
    {
        var texto = " Este texto é um teste "; // Cria uma variável "texto" e atribui uma string com espaços no início e no final

        Console.WriteLine(texto.ToUpper()); // Converte "texto" para maiúsculas e imprime: " ESTE TEXTO É UM TESTE "
        
        Console.WriteLine(texto.ToLower()); // Converte "texto" para minúsculas e imprime: " este texto é um teste "
        
        Console.WriteLine(texto.Remove(5, 5)); // Remove 5 caracteres a partir do índice 5 e imprime: " Este é um teste "
        
        Console.WriteLine(texto.Length); // Imprime o comprimento da string "texto", que é 24
        
        Console.WriteLine(texto.Replace("Este", "isto")); // Substitui "Este" por "isto" e imprime: " isto texto é um teste "
        
        Console.WriteLine(texto.Replace("e", "X")); // Substitui todas as ocorrências de "e" por "X" e imprime: " XstX tXxto X Xum tXstX "
        
        var divisao = texto.Split(" "); // Divide a string "texto" em um array de substrings, separadas por espaços
        Console.WriteLine(divisao[0]); // Imprime o primeiro elemento do array, que é "Este"
        Console.WriteLine(divisao[1]); // Imprime o segundo elemento do array, que é "texto"
        Console.WriteLine(divisao[2]); // Imprime o terceiro elemento do array, que é "é"
        Console.WriteLine(divisao[3]); // Imprime o quarto elemento do array, que é "um"
        Console.WriteLine(divisao[4]); // Imprime o quinto elemento do array, que é "teste"
        
        var resultado = texto.Substring(5, 5); // Extrai uma substring começando do índice 5 e com 5 caracteres, e armazena em "resultado"
        Console.WriteLine(resultado); // Imprime a substring extraída, que é "texto"
        
        Console.WriteLine(texto.Trim()); // Remove os espaços em branco no início e no final da string "texto" e imprime: "Este texto é um teste"

        
    }
}
