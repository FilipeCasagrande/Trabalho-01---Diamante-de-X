using System.Runtime.Serialization;
using System.Threading.Tasks.Dataflow;

namespace Trabalho_01___Diamante_de_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, linhas, colunas;
            
            Console.Write("Informe um número impar para determinar a quantidade de X do diamante: ");
            x = Convert.ToInt32(Console.ReadLine());

            while (x % 2 == 0)
            {
                Console.WriteLine("Entrada inválida, informe um número impar");
                x = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 1; i <= x; i++)
            {
                Console.Write("x ");
            }

            for (int i = 1; i < x; i++)
            {
                Console.WriteLine(" ");
                for (int j = i; j < x; j++)
               {
                   Console.Write("x ");
                    
               }
            }

            Console.ReadLine();
        }
    }
}
