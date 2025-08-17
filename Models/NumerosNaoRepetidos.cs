using System;
using System.Collections.Generic;

namespace teste_tecnico_even3.Models
{
    public class NumerosNaoRepetidos
    {
        public static void ExibirNumerosUnicos(int[] numeros)
        {
            var contagem = new Dictionary<int, int>();

            foreach (int chave in numeros)
            {
                if (contagem.ContainsKey(chave))
                    contagem[chave]++;
                else
                    contagem[chave] = 1;
            }

            foreach (var valor in contagem)
            {
                if (valor.Value == 1)
                {
                    Console.WriteLine(valor.Key);
                }
            }
        }
    }
}
