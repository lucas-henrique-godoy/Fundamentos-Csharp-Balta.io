namespace Structs;

class Program
{
    static void Main(string[] args)
    {
        struct Product
        {
            public int Id;
            public float Price;

            public float PriceInDolar(float dolar)
            {
                return Price * dolar;
            }


        }
    }
}
