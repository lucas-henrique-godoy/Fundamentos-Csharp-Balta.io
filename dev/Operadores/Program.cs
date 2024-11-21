namespace Operadores;

class Program
{
    static void Main(string[] args)
    {
        string jogo = "God Of War";
        switch (jogo)
        {
            case "Call Of Duty": Console.WriteLine("Não é o jogo correto!"); break;
            case "Black": Console.WriteLine("Não é o jogo correto!"); break;
            case "God Of War": Console.WriteLine("É este!"); break;
            default: Console.WriteLine("Jogo não encontrado!"); break;
        }
        
    }        
}
