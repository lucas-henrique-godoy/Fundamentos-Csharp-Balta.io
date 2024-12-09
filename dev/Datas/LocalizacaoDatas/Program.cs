using System;
using System.Globalization;

namespace LocalizacaoDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Limpa a tela do console para um novo início.
            Console.Clear();

            // Criação de objetos 'CultureInfo' que representam diferentes culturas.
            var pt = new CultureInfo("pt-PT");  // Cultura de Portugal.
            var br = new CultureInfo("pt-BR");  // Cultura do Brasil.
            var enUS = new CultureInfo("en-US"); // Cultura dos Estados Unidos.
            var de = new CultureInfo("de-DE");  // Cultura da Alemanha.

            // Obtém a cultura atual do sistema ou ambiente de execução.
            var atual = CultureInfo.CurrentCulture;

            // Exibe a data atual no formato "D" (data por extenso) usando a cultura de Portugal.
            Console.WriteLine(DateTime.Now.ToString("D", pt)); 

            // Exibe a data atual no formato "D" (data por extenso) usando a cultura do Brasil.
            Console.WriteLine(DateTime.Now.ToString("D", br));         

            // Exibe a data atual no formato "D" (data por extenso) usando a cultura dos Estados Unidos.
            Console.WriteLine(DateTime.Now.ToString("D", enUS));        

            // Exibe a data atual no formato "D" (data por extenso) usando a cultura da Alemanha.
            Console.WriteLine(DateTime.Now.ToString("D", de));          

            // Exibe a data atual no formato "D" (data por extenso) usando a cultura atual do sistema.
            Console.WriteLine(DateTime.Now.ToString("D", atual));

        }
    }
}


