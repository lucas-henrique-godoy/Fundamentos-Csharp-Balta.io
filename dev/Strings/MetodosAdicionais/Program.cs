namespace MetodosAdicionais; // Define o namespace "MetodosAdicionais" para organizar o código

class Program // Define a classe "Program"
{
    static void Main(string[] args) // Método principal, ponto de entrada da aplicação
    {
        var texto = "Este texto é um teste"; // Cria uma variável "texto" e atribui a string "Este texto é um teste"
        
        Console.WriteLine(texto.ToUpper()); // Converte "texto" para maiúsculas e imprime. Resultado: "ESTE TEXTO É UM TESTE"
        
        Console.WriteLine(texto.ToLower()); // Converte "texto" para minúsculas e imprime. Resultado: "este texto é um teste"
        
        Console.WriteLine(texto.Remove(5, 5)); // Remove 5 caracteres a partir do índice 5 e imprime. Resultado: "Este é um teste"
        
        Console.WriteLine(texto.Length); // Imprime o comprimento (número de caracteres) da string "texto". Resultado: 23
    }
}
