using System;  // Importa o namespace System, necessário para usar classes como Console

namespace AlterandoValores  // Define o namespace 'AlterandoValores'
{
    class Program  // Declara a classe Program
    {
        static void Main(string[] args)  // Método principal, ponto de entrada do programa
        {
            Console.Clear();  // Limpa o console antes de começar a execução

            // CENÁRIO 1
            var primeiro = new int[4];  // Cria um array 'primeiro' com 4 elementos do tipo int (todos inicializados com 0)
            var segundo = new int[4];   // Cria um outro array 'segundo' com 4 elementos do tipo int (também inicializados com 0)

            segundo = primeiro;  // Faz com que 'segundo' aponte para o mesmo array que 'primeiro' aponta. 
                                  // Agora 'primeiro' e 'segundo' referenciam o **mesmo array**.

            primeiro[0] = 23;  // Altera o valor do primeiro elemento do array 'primeiro' para 23.
            Console.WriteLine(segundo[0]);  // Como 'segundo' e 'primeiro' referenciam o mesmo array, 
                                           // 'segundo[0]' será igual a 23, já que a alteração no 'primeiro' afeta 'segundo' também.

            // CENÁRIO 2
            var primeiro = new int[4];  // Cria novamente um array 'primeiro' com 4 elementos do tipo int, inicializados com 0
            var segundo = new int[4];   // Cria outro array 'segundo' com 4 elementos do tipo int, inicializados com 0

            segundo[0] = primeiro[0];  // Copia o valor de 'primeiro[0]' (que é 0) para 'segundo[0]'.
                                       // Agora, 'segundo[0]' terá o valor 0, mas 'primeiro' e 'segundo' são arrays independentes.

            //primeiro.CopyTo(segundo, 0);  // Comentado. Se fosse ativado, copiaria todo o conteúdo de 'primeiro' para 'segundo',
                                            // a partir do índice 0 (portanto, 'segundo' se tornaria igual a 'primeiro').

            primeiro[0] = 23;  // Altera o valor do primeiro elemento do array 'primeiro' para 23.

            Console.WriteLine(segundo[0]);  // 'segundo[0]' continua sendo 0, pois 'primeiro' e 'segundo' são arrays independentes.
                                           // A mudança em 'primeiro[0]' não afeta 'segundo[0]' porque não são mais referências para o mesmo array.
        }
    }
}
