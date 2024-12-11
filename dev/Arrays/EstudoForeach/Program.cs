using System;

namespace EstudoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); // Limpa a tela do console para melhorar a visualização

            // -------------------- Iterando sobre arrays com foreach --------------------

            // Criação de um array de inteiros com 5 elementos e inicialização dos valores.
            var meuArray = new int[5] { 1, 2, 3, 4, 5 };
            meuArray[0] = 12; // Alterando o primeiro elemento do array (de 1 para 12).

            // Utilizando o 'foreach' para iterar sobre cada elemento do array 'meuArray'.
            // O 'foreach' é uma forma simplificada de percorrer todos os itens de uma coleção.
            foreach (var item in meuArray)  // Para cada 'item' dentro do array 'meuArray'
            {
                Console.WriteLine(item);  // Imprime o valor atual do item no console.
            }  

            // --------------- Iterando sobre structs -------------------

            // Criação de um array de objetos do tipo 'Funcionario', com 5 posições.
            var funcionarios = new Funcionario[5];

            // Inicializando o primeiro funcionário no array, com 'Id' e 'Nome'.
            funcionarios[0] = new Funcionario() { Id = 2579, Nome = "Lucas" };

            // Utilizando 'foreach' novamente para percorrer o array 'funcionarios'.
            // Mesmo que o array tenha 5 posições, apenas o primeiro item foi inicializado,
            // o restante estará com os valores padrão (Id = 0 e Nome = null).
            foreach (var funcionario in funcionarios) // Para cada 'funcionario' no array 'funcionarios'
            {
                Console.WriteLine(funcionario.Id);    // Imprime o 'Id' do funcionário no console.
                Console.WriteLine(funcionario.Nome);  // Imprime o 'Nome' do funcionário no console.
            }            
        }        
    }

    // Definição de uma struct chamada 'Funcionario', que possui duas propriedades: 'Id' e 'Nome'.
    // Structs são tipos de valor em C#, que armazenam dados diretamente.
    public struct Funcionario
    {
        public int Id { get; set; }     // Propriedade 'Id' do tipo inteiro.
        public string Nome { get; set; } // Propriedade 'Nome' do tipo string.
    }
}
