using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AtividadesPuc.Atividade01.Questao10
{
    public static class Questao10
    {
        public static void Rodar()
        {
            Stack numeros = new Stack();
            Random ale = new Random();

            for (int i = 0; i < 10; i++)
            {
                int aletorio = ale.Next();

                numeros.Push(aletorio);
            }

            
        }
    }
}
