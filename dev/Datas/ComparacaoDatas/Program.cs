using System;

namespace ComparacaoDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXEMPLO 1:
            
            Console.Clear();  // Limpa a tela do console

            var data = DateTime.Now;  // Obtém a data e hora atuais e armazena na variável 'data'

            if (data.Date == DateTime.Now.Date)  // Compara apenas as datas (sem hora) de 'data' e da data atual
            {
                Console.WriteLine("É igual");  // Se as datas forem iguais, exibe "É igual"
            }

            Console.WriteLine(data);  // Exibe o valor de 'data' (data e hora atuais)

        ///////////////////////////////////////////////////////////////////////////////////////

            // EXEMPLO 2:
            var data = DateTime.Now;  // Obtém a data e hora atuais, incluindo frações de segundo

            if (data == DateTime.Now)  // Comparar data e hora exatas pode falhar devido às frações de segundo serem diferentes
            {
                Console.WriteLine("É igual");
            }

            // Para comparar apenas a data (sem considerar a hora), use a propriedade .Date:
            var data = DateTime.Now.Date;  // Armazena apenas a parte da data (sem hora)
            if (data == DateTime.Now.Date)  // Compara apenas a data, ignorando horas e frações de segundo
            {
                Console.WriteLine("É igual");
            }

        }
    }
}


