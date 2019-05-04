using System;

namespace PasswordStrength
{
    public class PasswordStrength
    {
        public static bool IsStrongPassword(string password)
        {
            return password != string.Empty;
        }
    }
}
