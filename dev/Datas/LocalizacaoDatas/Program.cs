using System;
using System.Globalization;

namespace LocalizacaoDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var enUS = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");

            Console.WriteLine(DateTime.Now.ToString("D", pt)); 
            Console.WriteLine(DateTime.Now.ToString("D", br));         
            Console.WriteLine(DateTime.Now.ToString("D", enUS));         
            Console.WriteLine(DateTime.Now.ToString("D", de));          
        }
    }
}


