using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AtividadesPuc.Atividade01.Questao07
{
    class ReceberColecao
    {
        public static void Receber(params int [] numbers)// vai avisar para o compilador que posso receber qualquer quantidade
        {
            int[] invercao = new int[numbers.Length];

            Console.WriteLine("\n:::::::Números:::::::\n");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
                invercao[i] = numbers[numbers.Length - 1 - i];
            }

            Console.WriteLine("\nNúmero invertido\n");
            for (int i = 0; i < invercao.Length; i++)
            {
                Console.WriteLine(invercao[i]);
            }
        }

        //public static void ReceberArray(ArrayList dados)// Nem sei se isso da certo, só testando coisas aletoria.
        //{
            

        //}
    }
}
