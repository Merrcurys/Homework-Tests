using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    public class Password
    {
        public int Cheking(string password)
        {
            int balls = 0;

            if (password.Any(Char.IsNumber)) // наличие цифр
            {
                balls++;
            }

            if (password.Any(Char.IsLower)) // наличие строчных букв
            {
                balls++;
            }

            if (password.Any(Char.IsUpper)) // наличие заглавных букв
            {
                balls++;
            }

            if (!password.All(Char.IsLetterOrDigit) && !password.Any(Char.IsWhiteSpace)) // наличие спецсимволов
            {
                balls++;
            }


            if (password.Length > 10) { // проверка на длину 
                balls++;
            }

            return balls;
        }
    }
}
