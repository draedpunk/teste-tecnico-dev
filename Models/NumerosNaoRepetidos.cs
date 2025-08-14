using System;
using System.Collections.Generic;

namespace teste_tecnico_even3.Models
{
    public class NumerosNaoRepetidos
    {
        public static void ContagemNumeros(int[] numeros)
        {
            var contagem = new Dictionary<int, int>();

            foreach (int num in numeros)
            {
                if (contagem.ContainsKey(num))
                    contagem[num]++;
                else
                    contagem[num] = 1;
            }

            foreach (var unico in contagem)
            {
                if (unico.Value == 1)
                {
                    Console.WriteLine(unico.Key);
                }
            }
        }
    }
}
