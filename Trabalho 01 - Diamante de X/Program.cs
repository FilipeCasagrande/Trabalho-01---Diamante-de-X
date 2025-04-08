namespace Trabalho_01___Diamante_de_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Informe um número impar para determinar a quantidade de X do diamante");
            x = Convert.ToInt32(Console.ReadLine());

            while (x % 2 == 0)
            {
                Console.WriteLine("informe um número impar");
                x = Convert.ToInt32(Console.ReadLine());

            }


            Console.ReadLine();
        }
    }
}
