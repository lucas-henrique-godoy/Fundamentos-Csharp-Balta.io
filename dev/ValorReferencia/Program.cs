using System;

namespace ValorReferencia;

class Program
{
    static void Main(string[] args)
    {
        /* Tipos de Valor
        int x = 25;
        int y = x;
        Console.WriteLine(x);
        Console.WriteLine(y);

        x = 32;
        Console.WriteLine(x);
        Console.WriteLine(y);
        */

        var arr = new string[2];
        arr[0] = "Item 1";

        var arr2 = arr;
    }
}
