using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AtividadesPuc.Atividade01
{
    public static class Questao03
    {
        public static void Rodar()
        {

            Stack dados3 = new Stack();
            int soma = 0, media;

            Console.WriteLine("\n\n::::::::::::::::Stack::::::::::::::::\n");

            Console.Write("Informe N números inteiros: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                dados3.Push(i + 3);
            }


            foreach (object item in dados3)
            {
                Console.Write($"{item}|");

                soma += (int)item;

            }

            Console.WriteLine($"\nSoma: {soma}");
            Console.Write($"Média: {media = soma / n}");
        }
    }
}
