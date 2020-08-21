using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AtividadesPuc.Atividade01.Questao08
{
    class Calcular
    {
        public static void Receber(Queue dados)
        {
            int soma = 0;

            Console.WriteLine("Elementos: ");
            foreach (var item in dados)
            {
                Console.Write("|"+item);
             
                soma += (int)item;
            }

            Console.WriteLine($"\nSoma: {soma}");
        }

        public static void Receber(Stack dados)
        {
            int soma = 0;

            Console.WriteLine("Elementos: ");
            foreach (var item in dados)
            {
                Console.Write("|" + item);

                soma += (int)item;
            }

            Console.WriteLine($"\nSoma: {soma}");
        }

        public static void Receber(ArrayList dados)
        {
            int soma = 0;

            Console.WriteLine("Elementos: ");
            foreach (var item in dados)
            {
                Console.Write("|" + item);

                soma += (int)item;
            }

            Console.WriteLine($"\nSoma: {soma}");
        }
    }
}
