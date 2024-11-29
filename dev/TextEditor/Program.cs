﻿using System;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
           Console.Clear();
           Console.WriteLine("O que você deseja fazer?");
           Console.WriteLine("1 - Abrir arquivo");
           Console.WriteLine("2 - Criar um novo arquivo");
           Console.WriteLine("0 - Sair");
           short option = short.Parse(Console.ReadLine());

           switch(option)
           {
                case 0:
                    System.Environment.Exit(0);
                    break;
                case 1:
                    Abrir();
                    break;
                case 2:
                    Editar();
                    break;                
                default:
                    Menu();
                    break;
           }
        }

        static void Abrir()
        {
            
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("---------------------------------");
            string text = "";

            do
            {
               text += Console.ReadLine();
               text += Environment.NewLine; 
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.Write(text);
            
        }
    
        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using (var ) // Usa, cria e fecha o objeto automaticamente seja arquivos, banco de dados e é usado também para importar namespaces 
            {

            }
        }
    }
}
