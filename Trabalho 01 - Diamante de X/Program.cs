using System.Runtime.Serialization;
using System.Threading.Tasks.Dataflow;

namespace Trabalho_01___Diamante_de_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = entradaDeDados();

            

            int espacos = n / 2;
            int letras = 1;
            int meio = n / 2;

            for (int i = 0; i <= meio; i++)
            {
                for (int j = 0; j < espacos; j++)
                {
                    Console.Write(' ');
                }

                for (int k = 0; k < letras; k++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
                espacos--;
                letras += 2;
            }

            espacos = 1;
            letras = n - 2;

            for (int i = 0; i < meio; i++)
            {
                for (int j = 0; j < espacos; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < letras; k++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
                espacos++;
                letras -= 2;
            }

            Console.ReadLine();
        }
        static int entradaDeDados()
        {
            int x;

            Console.Write("Informe um número impar para determinar a quantidade de X do diamante: ");
            x = Convert.ToInt32(Console.ReadLine());
            verificacao(x);
            return x;
        }
        static void verificacao(int x)
        {
            while (x % 2 == 0 || x < 1)
            {
                Console.WriteLine("Entrada inválida, informe um número impar positivo");
                x = Convert.ToInt32(Console.ReadLine());

            }
        }
        


    }
}
