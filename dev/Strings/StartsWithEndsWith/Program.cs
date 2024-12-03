using System;

namespace StartsWithEndsWith;

class Program
{
    static void Main(string[] args)
    {
        var texto = "Este texto é um teste";
        Console.WriteLine(texto.StartsWith("Este"));
        Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine(texto.StartsWith("texto"));
    }
}
