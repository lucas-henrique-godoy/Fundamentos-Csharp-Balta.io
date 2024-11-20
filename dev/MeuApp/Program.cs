using System;
using MeuApp.Teste; //Importando o novo namespace

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIÁVEIS:
            // int idade; // Correto inicia com ZERO
            // int idade = 25; // Correto inicia com 25
            // var idade = 25; // Correto inicia com 25
            // var idade; // Errado
            //----------------------------------------------------------

            /* CONSTANTES:
               const int IDADE_MINIMA; // Correto inicia com ZERO
               const int IDADE_MINIMA = 25; // Correto inicia com 25   
            */         
            
            byte meuByte = 127; // tipo byte

            int idade = 25; //tipo int

            float preco = 10.90f;

            double altura = 1.80;
            
            var texto = "Testando";
            Console.WriteLine(texto); 
            
                       
        }       
    }
}


