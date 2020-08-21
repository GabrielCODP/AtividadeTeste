using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace AtividadesPuc.Atividade01
{
    public static class Questao05
    {
        public static void Rodar()
        {

            ArrayList dados = new ArrayList(25);

            for (int i = 0; i < dados.Capacity; i++)
            {
                dados.Add(i + 1);
            }


            Console.WriteLine("Escolha: ");
            Console.WriteLine("1-Imprima todos os elementos\n2-Imprima todos os elementos em ordem invertida\n3-Imprima todos os elementos em posições ímpares (o elemento da posição 1, 3, 5, ...)\n4-Imprima todos os elementos ímpares\n5-Imprima apenas os elementos da primeira metade do vetor (posição 0 a 12).");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    foreach (var item in dados)
                    {
                        Console.Write($"|{item}");
                    }

                    Console.WriteLine("\n:::::::Utilizando comando For:::::::\n");

                    for (int i = 0; i < dados.Count; i++)
                    {
                        Console.Write($"|{dados}");
                    }

                    break;

                case 2:
                    dados.Reverse();
                    foreach (var item in dados)
                    {
                        Console.Write($"|{item}");
                    }

                    Console.WriteLine("\n:::::::Utilizando comando For:::::::\n");

                    for (int i = 0; i < dados.Count; i++)
                    {
                        Console.Write($"|{dados}");
                    }


                    break;


                case 3:

                    Console.WriteLine("Duvida");

                    break;

                case 4:

                    foreach (var item in dados)
                    {
                        if (((int)item % 2) != 0)
                        {
                            Console.Write($"|{item}");
                        }
                    }

                    Console.WriteLine("\n:::::::Utilizando comando For:::::::\n");

                    Console.WriteLine("Duvida");

                    break;


                case 5:

                    Console.WriteLine("\n:::::::Utilizando comando For:::::::\n");

                    for (int i = 0; i <= 12; i++)
                    {
                        Console.Write($"|{dados}");
                    }

                    break;

                default:

                    break;
            }
        }
    }
}
