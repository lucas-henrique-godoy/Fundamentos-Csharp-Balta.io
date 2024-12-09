using System;

namespace ComparacaoDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var data = DateTime.Now;

            if (data == DateTime.Now)
            {
                Console.WriteLine("É igual");
            }

            Console.WriteLine(data);
        }
    }
}


