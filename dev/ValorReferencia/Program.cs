using System;

namespace ValorReferencia;

class Program
{
    static void Main(string[] args)
    {
        // Tipos de Valor
// 'int' é um tipo por valor, o que significa que quando atribuirmos um valor a outra variável,
// uma cópia do valor será criada.
int x = 25; // x armazena o valor 25
int y = x;  // y recebe uma cópia do valor de x, ou seja, y também armazena 25

// Exibindo os valores de x e y
Console.WriteLine(x);  // Saída: 25 (o valor original de x)
Console.WriteLine(y);  // Saída: 25 (y recebeu uma cópia de x)

// Alterando o valor de x
x = 32; // x agora tem o valor 32, mas isso não afeta o valor de y, pois y é uma cópia do valor original de x

// Exibindo os novos valores de x e y
Console.WriteLine(x);  // Saída: 32 (o novo valor de x)
Console.WriteLine(y);  // Saída: 25 (y ainda mantém o valor original que foi copiado de x)

        
// Tipos por Referência
// 'arr' é uma variável que referencia um array, que é um tipo por referência.
// Ou seja, quando atribuirmos 'arr' a outra variável, ambas irão se referir ao mesmo objeto na memória.

var arr = new string[2];   // Cria um array de strings com 2 elementos
arr[0] = "Item 1";         // Atribui "Item 1" à primeira posição do array 'arr'

// A variável 'arr2' agora referencia o mesmo array que 'arr'.
// Ambas as variáveis (arr e arr2) apontam para o mesmo objeto na memória.
var arr2 = arr;           // 'arr2' referencia o mesmo array que 'arr'

// Exibindo o valor armazenado na primeira posição do array
Console.WriteLine(arr[0]);  // Saída: "Item 1" (valor atual na posição 0 do array)
Console.WriteLine(arr2[0]); // Saída: "Item 1" (já que arr2 referencia o mesmo array)

// Alterando o valor da primeira posição do array através de 'arr'
arr[0] = "Item 2";         // Agora arr[0] contém "Item 2", mas como arr2 aponta para o mesmo array,
// arr2[0] também será alterado.

Console.WriteLine(arr[0]);  // Saída: "Item 2" (valor alterado de arr[0])
Console.WriteLine(arr2[0]); // Saída: "Item 2" (arr2 também aponta para o mesmo array, então a alteração afeta ambos)


    }
}
