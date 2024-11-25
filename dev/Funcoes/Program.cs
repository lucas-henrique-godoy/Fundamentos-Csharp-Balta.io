﻿using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
           MeuMetodo();

           string nome = RetornaNome("Lucas", "Henrique", 27);
           Console.WriteLine(nome);
        }

        static void MeuMetodo()
        {
            Console.WriteLine("C# é legal!");
        }  

        static string RetornaNome(string nome, string sobrenome, int idade)
        {
            return nome + " " + sobrenome + " " + idade.ToString();
        }             
    }
}
