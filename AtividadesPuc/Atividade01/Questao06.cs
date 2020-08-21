using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AtividadesPuc.Atividade01
{
    public static class Questao06
    {
        public static void Rodar()
        {
            ArrayList numeros = new ArrayList();
            Queue numeros2 = new Queue();
            Stack numeros3 = new Stack();

            Random aleatorio = new Random();

            Console.Write("Informe a quantidade de N números(Ele vai ser inserido nas 3 soluções): ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("\n:::::::::::::ArrayList:::::::::::::\n");

            for (int i = 0; i < quantidade; i++)
            {
                numeros.Add(aleatorio.Next(quantidade));
            }

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n:::::::::::::Queue:::::::::::::\n");

            for (int i = 0; i < quantidade; i++)
            {
                numeros2.Enqueue(aleatorio.Next(quantidade));
            }

            foreach (var item in numeros2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n:::::::::::::Stack:::::::::::::\n");

            for (int i = 0; i < quantidade; i++)
            {
                numeros3.Push(aleatorio.Next(quantidade));
            }

            foreach (var item in numeros3)
            {
                Console.WriteLine(item);
            }

        }
    }
}
