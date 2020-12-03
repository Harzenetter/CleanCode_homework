using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_Homework_1
{
    class Password
    {
        public int _minimalPasswordLength { get; private set; } = 7;
        public bool _hasPasswordMinimalLength { get; private set; } = false;
        public bool _hasPasswordMoreThanOneLetter { get; private set; } = false;
        public bool _hasPasswordMoreThanOneDigit { get; private set; } = false;
        public bool _hasPasswordSpecialChar { get; private set; } = false;
        public bool _isPasswordSafeEnough { get; private set; } = false;

        private bool _isAdminPassword = false;           
        private string _password;

        public Password(string password, bool isAdminPassword)
        {
            this._password = password;
            this._isAdminPassword = isAdminPassword;
            CheckPassword();
        }


        private void CheckPassword()
        {
            CheckIfPasswordHasNoSpecialChar();
            CheckIfPasswordLongEnough();
            CheckIfPasswordHasMoreThanOneDigit();
            CheckIfPasswordHasMoreThanOneLetter();

            _isPasswordSafeEnough = _hasPasswordMinimalLength && _hasPasswordMoreThanOneLetter &&
                                    _hasPasswordMoreThanOneDigit && _hasPasswordSpecialChar;
        }

        private void CheckIfPasswordLongEnough()
        {
            if (_isAdminPassword)
            {
                this._minimalPasswordLength = 10;
            }

            if (_password.Length >= this._minimalPasswordLength)
            {
                _hasPasswordMinimalLength = true;
            }           

        }

        private void CheckIfPasswordHasMoreThanOneLetter()
        {
            _hasPasswordMoreThanOneLetter =  _password.Any(char.IsLetter);
        }

        private void CheckIfPasswordHasMoreThanOneDigit()
        {
            _hasPasswordMoreThanOneDigit = _password.Any(char.IsDigit);
        }

        private void CheckIfPasswordHasNoSpecialChar()
        {
            if (_isAdminPassword) { 
                _hasPasswordSpecialChar = ! _password.All(char.IsLetterOrDigit);
            }
            else
            {
                _hasPasswordSpecialChar = true;
            }
        }


    }
}
