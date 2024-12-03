using System;

namespace EstruturaDeDecisao
{
    class Program
    {
       static void Main(string[] args)
       {
            Console.Write("Digite um número entre 1 e 10: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            if(n<1 || n>10)
            {
                Console.WriteLine("Número errado!");

            }
            else
            {
                Console.WriteLine("Obrigado");    
            }
            
            Console.ReadLine();
       }    
    }
}
