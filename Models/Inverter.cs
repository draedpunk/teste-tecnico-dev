using System;

namespace teste_tecnico_even3.Models
{
    class Inverter
    {

        public static string InverterTexto(string texto)
        {
            string vaziaString = "";

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                vaziaString += texto[i]; 
            }
            return vaziaString;
        }
    }

}