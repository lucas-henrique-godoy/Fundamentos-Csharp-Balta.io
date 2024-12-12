using System;

namespace TratamentoDeErros
{
    class Program
    {
        // Função principal que executa o programa
        static void Main(string[] args)
        {
            // Criando um array de inteiros com 3 elementos
            var arr = new int[3];

            try
            {
                // Código comentado que tentaria acessar um índice fora dos limites do array
                // Isso geraria uma exceção do tipo IndexOutOfRangeException
                // for (var index = 0; index < 10; index++)
                // {
                //     Console.WriteLine(arr[index]);
                // }

                // Chamando a função Cadastrar passando uma string vazia,
                // o que provocará uma exceção do tipo MinhaException
                Cadastrar("");
            }
            catch (IndexOutOfRangeException ex) // Captura erros de índice fora do alcance do array
            {
                // Exibe as informações sobre a exceção
                Console.WriteLine(ex.InnerException); // Exibe informações adicionais da exceção, se houver
                Console.WriteLine(ex.Message); // Exibe a mensagem de erro padrão
                Console.WriteLine("Não encontrei o índice na lista!"); // Mensagem personalizada
            }
            catch (MinhaException ex) // Captura uma exceção personalizada (MinhaException)
            {
                // Exibe as informações sobre a exceção personalizada
                Console.WriteLine(ex.InnerException); // Exibe informações adicionais da exceção
                Console.WriteLine(ex.Message); // Exibe a mensagem de erro da exceção
                Console.WriteLine(ex.QuandoAconteceu); // Exibe o momento em que a exceção foi gerada
                Console.WriteLine("Exceção customizada"); // Mensagem personalizada para a exceção personalizada
            }
            catch (ArgumentNullException ex) // Captura erros de argumento nulo
            {
                // Exibe as informações sobre a exceção ArgumentNullException
                Console.WriteLine(ex.InnerException); // Exibe informações adicionais da exceção
                Console.WriteLine(ex.Message); // Exibe a mensagem de erro
                Console.WriteLine("Falha ao cadastrar texto"); // Mensagem personalizada
            }
            catch (Exception ex) // Captura qualquer outro tipo de exceção genérica
            {
                // Exibe as informações sobre a exceção genérica
                Console.WriteLine(ex.InnerException); // Exibe informações adicionais da exceção
                Console.WriteLine(ex.Message); // Exibe a mensagem de erro
                Console.WriteLine("Ops, algo deu errado!"); // Mensagem genérica
            }
            finally 
            {
                // Este bloco sempre será executado, independentemente de uma exceção ter ocorrido ou não
                Console.WriteLine("Chegou ao fim!"); // Mensagem final que será exibida após o bloco try-catch
            }
        }

        // Função que simula um cadastro e lança uma exceção customizada caso o texto seja nulo ou vazio
        private static void Cadastrar(string texto)
        {
            // Verifica se o texto é nulo ou vazio
            if(string.IsNullOrEmpty(texto))
            {
                // Lança a exceção customizada MinhaException
                throw new MinhaException(DateTime.Now);
            }
        }

        // Classe que define uma exceção personalizada (MinhaException)
        public class MinhaException : Exception
        {
            // Construtor que recebe a data e hora de quando a exceção foi criada
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date; // Armazena a data no atributo QuandoAconteceu
            }
            
            // Propriedade que armazena a data e hora de quando a exceção ocorreu
            public DateTime QuandoAconteceu { get; set; }
        }
    }
}
