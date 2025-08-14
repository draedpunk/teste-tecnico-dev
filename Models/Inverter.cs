using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace teste_tecnico_even3.Models
{
    class Inverter
    {
        public string Texto { get; }

        public Inverter(string texto)
        {
            Texto = texto;
        }

        public string InverterTexto()
        {
            return new string(Texto.Reverse().ToArray());
        }
    }

}