using System;

namespace Interpolacao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definindo uma variável chamada 'price' e atribuindo um valor decimal
            var price = 10.2;

            // Forma tradicional de concatenar strings. O operador '+' junta a string com o valor da variável 'price'
            // O código abaixo é uma forma antiga de inserir valores em uma string.
            // var texto = "O preço do produto é " + price + " apenas na promoção";

            // Usando o método string.Format para formatar a string. 
            // O {0} é um espaço reservado onde a variável 'price' será inserida.
            // var texto = string.Format("O preço do produto é {0} apenas na promoção", price);

            // Interpolação de strings: uma forma moderna e mais legível de incluir variáveis diretamente dentro de uma string.
            // O sinal de cifrão ($) indica que estamos utilizando interpolação.
            var texto = $"O preço do produto é {price} apenas na promoção";

            // Outra forma de interpolação de strings, mas com um detalhe importante:
            // O símbolo '@' permite usar quebras de linha e ignora caracteres especiais (como o \n).
            // Nesse caso, ele não seria necessário para uma string simples, mas poderia ser útil em textos maiores ou com quebras de linha.
            // var texto = $@"O preço do
            // produto é {price} apenas na promoção"; 

            // Exibindo a string formatada no console
            Console.WriteLine(texto);
        }
    }
}
