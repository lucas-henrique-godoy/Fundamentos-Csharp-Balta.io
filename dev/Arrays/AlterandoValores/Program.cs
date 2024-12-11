using System;

namespace AlterandoValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var arr = new int[4];
            var arrb = arr;

            arr[0] = 23;
            Console.WriteLine(arrb[0]);
        }
    }
}


