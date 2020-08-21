using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AtividadesPuc.Atividade01.Questao09
{
    public static class Questao9
    {
        public static void Rodar()
        {
            ArrayList numeros = new ArrayList { 1, 2, 3, 4, 5, 6, -10, -20 };
            Queue queue = new Queue();
            Stack stack = new Stack();

            for (int i = -10; i < 10; i++)
            {
                queue.Enqueue(i);
                stack.Push(i);
            }

            CalcularPosit.Receber(numeros);
            CalcularPosit.Receber(queue);
            CalcularPosit.Receber(stack);
        }
    }
}
