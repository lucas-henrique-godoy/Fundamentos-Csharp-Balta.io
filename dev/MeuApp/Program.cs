using System;
using MeuApp.Teste; //Importando o novo namespace

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Testando";
            Console.WriteLine(texto);

            ClasseTeste teste = new ClasseTeste();
            teste.mensagem();
        }       
    }
}


