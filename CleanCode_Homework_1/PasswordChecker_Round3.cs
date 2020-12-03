using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_Homework_1
{
    class PasswordChecker_Round3
    {
        private int minimalPasswordLength = 7;

        public PasswordChecker_Round3() { }


        public List<string> GetMissingSafetyConditions(string password, bool isAdminPassword)
        {

            var myPassword = new Password(password, isAdminPassword);

            var missingCoditions = new List<string>();
            if (!myPassword._isPasswordSafeEnough)
            {
                if (!myPassword._hasPasswordMoreThanOneDigit)
                {
                    missingCoditions.Add("You must use at least one digit!");
                }
                if (!myPassword._hasPasswordMoreThanOneLetter)
                {
                    missingCoditions.Add("You must use at least one letter!");
                }
                if (!myPassword._hasPasswordSpecialChar)
                {
                    missingCoditions.Add("You must use at least one special char!");
                }
                if (!myPassword._hasPasswordMinimalLength)
                {
                    missingCoditions.Add(
                        $"Your password should exists at least of {myPassword._minimalPasswordLength} chars");
                }
            }

            return missingCoditions;
        }
    }
}
