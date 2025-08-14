using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace teste_tecnico_even3.Models
{
    class Somatorio
    {
        public int Numero { get; }

        public Somatorio(int numero)
        {
            Numero = numero;
        }

        public int SomarTodosOsNumeros()
        {
            int total = 0;
            
            for (int i = 1; i <= Numero; i++)
            {
                total += i;
            }
            
            return total;
        }
    }
}