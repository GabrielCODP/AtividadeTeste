using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AtividadesPuc.Atividade01.Questao09
{
    class CalcularPosit
    {
        public static void Receber(ArrayList dados)
        {
            int soma = 0;

            Console.WriteLine("Elementos ArrayList: ");
            foreach (int item in dados)
            {
                Console.Write("|" + item);
                if (item >= 0) 
                {
                    soma += item;
                }
            }

            Console.WriteLine($"\nSoma: {soma}");
        }
        public static void Receber(Queue dados)
        {
            int soma = 0;

            Console.WriteLine("Elementos Queue: ");

            foreach (int item in dados)
            {
                Console.Write("|" + item);
                if (item >= 0)
                {
                    soma += item;
                }
            }

            Console.WriteLine($"\nSoma: {soma}");
        }
        public static void Receber(Stack dados)
        {
            int soma = 0;

            Console.WriteLine("Elementos stack: ");
            foreach (int item in dados)
            {
                Console.Write("|" + item);
                if (item >= 0)
                {
                    soma += item;
                }
            }

            Console.WriteLine($"\nSoma: {soma}");
        }
    }
}
