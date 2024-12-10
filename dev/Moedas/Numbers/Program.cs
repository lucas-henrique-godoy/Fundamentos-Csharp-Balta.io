using System;
using System.Globalization;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); // Limpa a tela do console

            decimal valor = 10536.25m; // Declara uma variável do tipo decimal e a inicializa com o valor 10536.25

                                    // FORMATADORES:
                                    
            // Exibe o valor em formato geral (G) utilizando a cultura "en-US" (inglês dos Estados Unidos)
            Console.WriteLine(valor.ToString("G", CultureInfo.CreateSpecificCulture("en-US")));

            // Exibe o valor em formato de moeda (C) utilizando a cultura "en-US" (exibe como $10,536.25)
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

            // Exibe o valor em notação científica (E04) utilizando a cultura "en-US" (exibe como 1.053625E+004)
            Console.WriteLine(valor.ToString("E04", CultureInfo.CreateSpecificCulture("en-US")));

            // Exibe o valor com ponto fixo (F) utilizando a cultura "en-US" (exibe como 10,536.25)
            Console.WriteLine(valor.ToString("F", CultureInfo.CreateSpecificCulture("en-US")));

            // Exibe o valor em formato numérico (N) utilizando a cultura "en-US" (exibe como 10,536.25)
            Console.WriteLine(valor.ToString("N", CultureInfo.CreateSpecificCulture("en-US")));

            // Exibe o valor como uma porcentagem (P) utilizando a cultura "en-US" (exibe como 1,053,625.00%)
            Console.WriteLine(valor.ToString("P", CultureInfo.CreateSpecificCulture("en-US")));            
        }
    }
}
