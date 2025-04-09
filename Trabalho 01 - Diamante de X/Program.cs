using System.Runtime.Serialization;
using System.Threading.Tasks.Dataflow;

namespace Trabalho_01___Diamante_de_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x; 
            
            Console.Write("Informe um número impar para determinar a quantidade de X do diamante: ");
            x = Convert.ToInt32(Console.ReadLine());

            while (x % 2 == 0)
            {
                Console.WriteLine("Entrada inválida, informe um número impar");
                x = Convert.ToInt32(Console.ReadLine());
            }
            int espacos = x / 2;
            int letras = 1;
            
            //Triangulo crescente
            for(int i = 0; i <= espacos; i++)
            {
                for(int j = 0; j < espacos; j++)
                {
                    Console.Write(' ');
                }
                
                for(int k = 0; k < letras; k++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
                espacos --;
                letras += 2;
            }



            

            




            Console.ReadLine();
        }
    }
}
