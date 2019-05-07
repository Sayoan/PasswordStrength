using System;

namespace PasswordStrength
{
    public class PasswordStrength
    {
        public static bool IsStrongPassword(string password)
        {
            if (password == string.Empty)
            {
                return false;
            }
            else if (password.Length < 8 || password.Length > 16)
            {
                return false;
            }
            else if (!hasNumberAndLetters(password))
            {
                return false;
            }

            return true;
        }

        private static bool hasNumberAndLetters(string password)
        {
            char[] caracteres = password.ToCharArray();
            bool contemLetraMaiuscula = false;
            bool contemNumero = false;

            foreach (var caracter in caracteres)
            {
                int car = (int)caracter;
                //Letra maiuscula
                if (car >= 65 && car <= 90)
                    contemLetraMaiuscula = true;
                //Numero
                if (car >= 48 && car <= 57)
                    contemNumero = true;
            }

            return contemLetraMaiuscula && contemNumero;

        }
    }
}
