using System;
using System.Threading;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product(1, "Mouse Gamer", 299.97); // Instanciando um objeto da struct Product
           
            mouse.Id = 55; // Atribuindo um novo valor de id.

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);            
        }
   }

   struct Product
   {
        public Product(int id, string name, double price) // Método Construtor
        {
            Id = id;          // Propriedade(maiúsculo) recebe parâmetro(minúsculo)
            Name = name;     // Propriedade(maiúsculo) recebe parâmetro(minúsculo)
            Price = price;  // Propriedade(maiúsculo) recebe parâmetro(minúsculo)
        }
        
        public int Id; // Propriedade
        public string Name; // Propriedade
        public double Price; // Propriedade

        public double PriceInDolar(double dolar) // Parâmetro
        {
            return Price * dolar;
        }
   }

   
}



