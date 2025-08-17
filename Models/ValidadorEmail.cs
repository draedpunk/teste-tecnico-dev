using System;

namespace teste_tecnico_even3.Models
{
    public class ValidadorEmail
    {
        public static string VerificarEmail(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                return "Email invalido";
            }
            return "Email valido";
        }


    }
}