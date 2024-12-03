using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para saber a tabuada: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<=10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", numero, i, numero*i);
            }
            Console.ReadLine();
        }
    }
}
