using System; // Importa o namespace System, que contém classes essenciais como Console

namespace Indices // Define o namespace "Indices" para organizar o código
{
    class Program // Define a classe Program
    {
        static void Main() // Método principal, ponto de entrada da aplicação
        {
            var texto = "Este texto é um teste"; // Cria uma variável "texto" com o valor "Este texto é um teste"
            
            Console.WriteLine(texto.IndexOf("é")); // Procura a primeira ocorrência da substring "é" em "texto" e exibe o índice. O resultado será 15.
            
            Console.WriteLine(texto.LastIndexOf("s")); // Procura a última ocorrência da substring "s" em "texto" e exibe o índice. O resultado será 17.
        }
    }
}
