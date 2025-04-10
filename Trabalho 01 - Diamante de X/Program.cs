using System.Runtime.Serialization;
using System.Threading.Tasks.Dataflow;

namespace Trabalho_01___Diamante_de_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = EntradaDeDados();

            int espacos = n / 2;
            int letras = 1;
            int meio = n / 2;
            
            ParteSuperior(espacos, letras, meio);

            espacos = 1;
            letras = n - 2;

            ParteInferior(espacos, letras, meio);

            Console.ReadLine();
        }
        static int EntradaDeDados()
        {
            int x;

            Console.Write("Informe um número impar para determinar o tamanho do diamante: ");
            x = Convert.ToInt32(Console.ReadLine());
            Verificacao(x);
            return x;
        }
        static void Verificacao(int x)
        {
            while (x % 2 == 0 || x <= 1)
            {
                Console.WriteLine("Entrada inválida, informe um número impar positivo");
                x = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void ParteSuperior(int espacos, int letras, int meio)
        {
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
        }
        static void ParteInferior(int espacos, int letras, int meio)
        {
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
        }
    }
}
