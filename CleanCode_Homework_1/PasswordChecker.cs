using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_Homework_1
{
    class PasswordChecker
    {
        private int minimalPasswordLength = 7;

        public PasswordChecker() { }


        public bool isPasswordSafeEnough(string password)
        {
            if (isPasswordLongEnough(password) && hasPasswordMoreThanOneDigit(password) && hasPasswordMoreThanOneLetter(password))
            {
                return true;
            }
            
            return false;
        }

        private bool isPasswordLongEnough(string password)
        {
            if (password.Length >= minimalPasswordLength)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private bool hasPasswordMoreThanOneLetter(string password)
        {
            return password.Any(char.IsLetter);   
        }

        private bool hasPasswordMoreThanOneDigit(string password)
        {
            return password.Any(char.IsDigit);            
        }
    }
}
