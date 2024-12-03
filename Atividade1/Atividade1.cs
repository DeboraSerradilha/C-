using System;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do produto: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a quantidade de produto: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            //Calcular

            decimal resultado = quantidade * valor;

            //Exibir

            Console.Write("Total da Compra:{0:c}", resultado);
            Console.ReadLine();

        }
    }
}
