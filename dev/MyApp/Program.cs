using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            id.ToString();

            id = new Guid("798a3f69-9417-471f-9766-7ba247cc0a59");
            id.ToString().Substring(0,8);
            Console.WriteLine(id);
        }
    }
}

