using System;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipos Primitivos");

            string nome = "Débora";

            short quatidade = 100;
            int numero = 20;
            long numeroGrande = 120000;
            byte item = 20;

            double comissao = 32.4578787878798;
            decimal valor = Convert.ToDecimal(1000.56);
            decimal valor1 = 1000.56m;

            DateTime data = DateTime.Now;
            DateTime dataExemplo = new DateTime(2050, 12, 31);     //Ano, Mês, Dia


            // Formatar

            Console.WriteLine("{0:d}", dataExemplo);              //data curta
            Console.WriteLine("{0:D}", dataExemplo);              //data por extenso
            Console.WriteLine("{0:ddd}", dataExemplo);            //dia da semana
            Console.WriteLine("{0:dddd}", dataExemplo);           //dia completo por extenso

            Console.WriteLine("{0:c}", valor1);           // moeda 

            Console.ReadLine();

        }
    }
}
