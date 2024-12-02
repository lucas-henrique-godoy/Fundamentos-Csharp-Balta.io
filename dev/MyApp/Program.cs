using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um novo identificador único global (GUID) aleatório
            var id = Guid.NewGuid(); 
            id.ToString(); // Convertendo o GUID para string, mas sem usá-lo. Este passo pode ser omitido se não for necessário.

            // Atribuindo um GUID específico a partir de um valor hexadecimal (este é um GUID fixo)
            id = new Guid("798a3f69-9417-471f-9766-7ba247cc0a59"); 

            // A comparação de GUIDs pode ser feita, mas deve-se ter cuidado pois "Guid.NewGuid()" gera valores diferentes a cada execução
            // Exemplo de comparação (comentado porque não está em uso no código):
            // if(id == Guid.NewGuid()) // Comparando o GUID gerado com um novo GUID
            // {

            // Criando um GUID com todos os seus valores como zero (um GUID vazio)
            id = new Guid(); // "new Guid()" cria um GUID com todos os valores zerados (00000000-0000-0000-0000-000000000000)
            Console.WriteLine(id); // Exibindo o GUID na tela. A saída será: 00000000-0000-0000-0000-000000000000

            // A linha abaixo foi comentada porque não é usada no código final.
            // Ela mostraria apenas os primeiros 8 caracteres do GUID, mas está comentada.
            // Console.WriteLine(id.ToString().Substring(0, 8));
        }
    }
}
