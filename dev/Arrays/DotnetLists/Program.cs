using System;

namespace DotnetLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[5]{ 23, 42, 54, 67, 99 };
            meuArray[0] = 12;

            Console.WriteLine(meuArray[0]); 
            Console.WriteLine(meuArray[1]);
            Console.WriteLine(meuArray[2]);
            Console.WriteLine(meuArray[3]);           
            Console.WriteLine(meuArray[4]);
        }
    }
}


