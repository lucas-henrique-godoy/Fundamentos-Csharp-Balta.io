using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
           MeuMetodo();

           string nome = RetornaNome("Lucas", "Henrique");
           Console.WriteLine(nome);
        }

        static void MeuMetodo()
        {
            Console.WriteLine("C# é legal!");
        }  

        static string RetornaNome(string nome, string sobrenome, int idade = 27)// idade como parâmetro opcional
        {
            return nome + " " + sobrenome + " tem " + idade.ToString();
        }             
    }
}
