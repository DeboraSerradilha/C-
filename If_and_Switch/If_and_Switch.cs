using System;

namespace If_And_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Formas de pagamento
            //Se o valor da compra for maios que R$1.000,00 pode parcelar em 3 vezes
            //Se não for, apenas a vista

            decimal valorCompra;
            int numeroParcelas = 3;
            decimal valorParcela;
            decimal ValorMinimoParcelar = 1000;

            Console.Write("Digite o valor da compra: ");
            valorCompra=Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Valor a vista: {0:c}", valorCompra);

            if(valorCompra>ValorMinimoParcelar)
            {
                valorParcela = valorCompra/numeroParcelas;
                Console.WriteLine("Pode ser parcelado em {0} vezes. Valor da Parcela: {1:c}", numeroParcelas, valorParcela);
            }

            Console.ReadLine();

        }    
    }
    
}
