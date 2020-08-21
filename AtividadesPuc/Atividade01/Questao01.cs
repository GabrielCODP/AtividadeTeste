using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AtividadesPuc.Atividade01
{
    public static class Questao01
    {
        public static void Rodar()
        {
            ArrayList dados = new ArrayList();
            int soma = 0, media;

            Console.Write("Informe N números inteiros: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                dados.Add(i + 1);
            }

            Console.WriteLine();
            foreach (object item in dados)
            {
                Console.Write($"{item}|");

                soma += (int)item;

            }

            Console.WriteLine($"\nSoma: {soma}");
            Console.Write($"Média: {media = soma / n}");

        }
    }
}
