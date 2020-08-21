using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AtividadesPuc.Atividade01.Questao08
{
    public static class Questao8
    {
        public static void Rodar()
        {
            ArrayList arrayList = new ArrayList();
            Queue dados2 = new Queue();
            Stack stack = new Stack();

            Console.WriteLine("\n::::::::::::::::::ArrayList::::::::::::::::::\n");

            for (int i = 0; i < 10; i++)
            {
                arrayList.Add(i + 1);
            }

            Calcular.Receber(arrayList);


            Console.WriteLine("\n::::::::::::::::::Queue::::::::::::::::::\n");

            for (int i = 0; i < 10; i++)
            {
                dados2.Enqueue(i+1);
            }
           
            Calcular.Receber(dados2);

            Console.WriteLine("\n::::::::::::::::::Stack::::::::::::::::::\n");

            for (int i = 0; i < 10; i++)
            {
                stack.Push(i + 3);
            }

            Calcular.Receber(stack);

        }
    }
}
