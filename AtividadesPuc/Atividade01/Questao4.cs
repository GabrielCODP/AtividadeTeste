using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AtividadesPuc.Atividade01
{
    public static class Questao4
    {
        public static void Rodar()
        {
            ArrayList dadosAleatorio = new ArrayList() { "Pipoca", 46, 4.6, 'C', -0.5 };
            int soma = 0;
            try
            {
                foreach (var item in dadosAleatorio)
                {
                    Console.WriteLine(item);
                }

                foreach (var item in dadosAleatorio)
                {
                    Console.WriteLine(item);

                    soma += (int)item;
                }


            }
            catch (Exception e)
            {
                Console.WriteLine($"A mensagem de erro é: {e}");
            }

            
        }
    }
}
