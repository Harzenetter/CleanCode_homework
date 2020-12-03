using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_Homework_1
{
    class PasswordChecker_Round2
    {
        private int minimalPasswordLength = 7;

        public PasswordChecker_Round2() { }


        public bool isPasswordSafeEnough(string password, bool isAdminPassword)
        {
            if (isAdminPassword)
            {
                minimalPasswordLength = 10;
                if (hasPasswordNoSpecialChar(password))
                {
                    return false;
                } 
            }

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

        private bool hasPasswordNoSpecialChar(string password)
        {
            return  password.All(char.IsLetterOrDigit);
        }
    }
}
