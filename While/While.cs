using System;

namespace EstruturaDeDecisaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            //while(condicao)

            string senha ="123";
            string senhaInformada = string.Empty;

            while(senha != senhaInformada)
            {
                Console.Write("Digite a senha: ");
                senhaInformada = Console.ReadLine();
            }
            Console.WriteLine("Fim");
        }
    }   
}