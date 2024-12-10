using System;

namespace MathEstudo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10536.25m;
            Console.WriteLine(Math.Round(valor)); // Método que arredonda
            Console.WriteLine(Math.Ceiling(valor)); // Método que arredonda para cima
            Console.WriteLine(Math.Floor(valor)); // Método que arredonda para baixo
        }
    }   
        
}

