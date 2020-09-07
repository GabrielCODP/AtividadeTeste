using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AtividadesPuc.Atividade01
{
    public static class Questao02
    {
        public static void Rodar()
        {
            Queue dados2 = new Queue();
            int soma = 0;
            double media;

            Console.WriteLine("\n\n::::::::::::::::Queue::::::::::::::::\n");

            Console.Write("Informe N números inteiros: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                dados2.Enqueue(i + 2);
            }


            foreach (object item in dados2)
            {
                Console.Write($"{item}|");

                soma += (int)item;

            }

            Console.WriteLine($"\nSoma: {soma}");
            Console.Write($"Média: {media = soma / n}");
        }

    }
}
