using System;
using System.Threading;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product(1, "Mouse Gamer", 299.97, EProductType.Product); // Instanciando um objeto da struct Product
            var ManutencaoEletrica = new Product(2, "Manutenção elétrica residencial", 500, EProductType.Service); 
            mouse.Id = 55; // Atribuindo um novo valor de id.

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type); 
            Console.WriteLine((int)mouse.Type);           
        }
    }

    struct Product
    {
        public Product(int id, string name, double price, EProductType type) // Método Construtor
        {
            Id = id;          // Propriedade(maiúsculo) recebe parâmetro(minúsculo)
            Name = name;     // Propriedade(maiúsculo) recebe parâmetro(minúsculo)
            Price = price;  // Propriedade(maiúsculo) recebe parâmetro(minúsculo)
            Type = type;
        }
        
        public int Id; // Propriedade
        public string Name; // Propriedade
        public double Price; // Propriedade
        public EProductType Type;

        public double PriceInDolar(double dolar) // Parâmetro
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}
