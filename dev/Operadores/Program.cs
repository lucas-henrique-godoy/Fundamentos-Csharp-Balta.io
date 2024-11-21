namespace Operadores;

class Program
{
    static void Main(string[] args)
    {
        /*string jogo = "God Of War";
        switch (jogo)
        {
            case "Call Of Duty": Console.WriteLine("Não é o jogo correto!"); break;
            case "Black": Console.WriteLine("Não é o jogo correto!"); break;
            case "God Of War": Console.WriteLine("É este!"); break;
            default: Console.WriteLine("Jogo não encontrado!"); break;
        }
       */


        /*for (int i = 5; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
        */

        /*int valor =  0;
        while (true)
        {
            
            Console.WriteLine(valor);   
            valor++;            

            if (valor == 101)
            {
                break;
            }        
        } 
        */

        int valor = 0;
        do
        {
           Console.WriteLine(valor);
           valor++;
        } while (valor <= 5);       
    }        
}
