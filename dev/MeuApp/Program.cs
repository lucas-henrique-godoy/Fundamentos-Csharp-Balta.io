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
            
            // byte meuByte = 127; // tipo byte

            // var salario = 2.500; // var por padrão fica double

            // int idade = 25; //tipo int
            // var idadeLucas = 27; // usando var

            // float preco = 10.90f;// tipo float

            // double altura = 1.80; // tipo double

            // decimal salarioAnual = 25.000m; // tipo decimal

            // bool usuarioJaCadastrado = false; // tipo booleano
            // var usuarioExpirado = false; // usando var

            // char primeiraLetra = 'C'; // tipo char
            // var segundaLetra = 'D';// usando var

            // string terceiraLetra = "A"; // tipo string com apenas 1 caracterer é posisvel mas usa memória desnecessariamente
            // string testo = "Meu texto"; // tipo string
            // var dcumento = "12345.99"; // string podem ser numeros, letras, símbolos, etc

            // object quantidade; // tipo object
            // quantidade = 1; // tipo object
            // quantidade = 2.5; // tipo object
            // quantidade = "Teste"; // tipo object

            // int? idadeWendel = null; // tipo null

            // CONVERSÕES
            // int inteiro = 100;
            // float real = 25.5f;

            //inteiro = real; - Erro não é possível converter
            //real = inteiro; // 100.0f - conversão implícita
            //inteiro = (int)real; // Conversõ explícita                    
            //string valorReal= real.ToString();
            //inteiro = int.Parse("255"); // Usando Parse
            //inteiro = Convert.ToInt32(real); Usando Convert
            //Console.WriteLine(valorReal);
            // Console.WriteLine(inteiro);
            // Console.WriteLine(Convert.ToBoolean(1));  
            
            
            
            var texto = "Testando";
            Console.WriteLine(texto);                       
        }       
    }
}


