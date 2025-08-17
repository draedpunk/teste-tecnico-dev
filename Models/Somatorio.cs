using System;

namespace teste_tecnico_even3.Models
{
    class Somatorio
    {
        public static int SomarTodosOsNumeros(int num)
        {
            int total = 0;
            
            for (int i = 1; i <= num; i++)
            {
                total += i;
            }
            
            return total;
        }
    }
}