using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace teste_tecnico_even3.Models
{
    public class ValidadorEmail
    {
        public string Email { get; }
        public static string VerificarEmail(string Email)
        {
            if (!Email.Contains("@") && !Email.Contains("."))
            {
                return "Email inválido";
            }
            return "Email válido";
        }


    }
}