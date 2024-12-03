﻿using System;

namespace EstruturaDeDecisao
{
    class Program
    {
       static void Main(string[] args)
       {
            int hora = DateTime.Now.Hour;
            string mensagem = string.Empty;
            switch(hora)
            {
                case 10:
                case 15:
                    mensagem = "Hora do Intervalo";
                    break;
                case 12:
                    mensagem = "Almoço";
                    break;
                default:
                    mensagem = string.Empty;
                    break;
            }
            

            Console.ReadLine();
       }    
    }
}