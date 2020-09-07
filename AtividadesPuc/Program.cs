using AtividadesPuc.Atividade01;
using AtividadesPuc.Atividade01.Questao07;
using AtividadesPuc.Atividade01.Questao08;
using AtividadesPuc.Atividade01.Questao09;
using System;
using System.Globalization;

namespace AtividadesPuc
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual questão de 1 a 9: ");
            char escolha = char.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (escolha)
            {
                case '1':
                    Questao01.Rodar();
                    break;
                case '2':
                    Questao02.Rodar();
                    break;
                case '3':
                    Questao03.Rodar();
                    break;
                case '4':
                    Questao4.Rodar();
                    break;
                case '5':
                    Questao05.Rodar();
                    break;
                case '6':
                    Questao06.Rodar();
                    break;
                case '7':
                    Questao7.Rodar();
                    break;
                case '8':
                    Questao8.Rodar();
                    break;
                case '9':
                    Questao9.Rodar();
                    break;

                default:
                    Console.WriteLine("ERRO");
                    break;
            }


        }
    }
}
