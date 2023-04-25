using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_9_2
{
    public class CredentialsVerifier
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public static bool VerifCredentials(string login, string password, string confirmPassword)
        {

            if(login.Length >=20)
            {
                throw new WrongLoginExceprion("Login >=20");
            }
            if (!IsMatchedThePattern(login, '@'))
            {
                throw new WrongLoginExceprion("Login no letter");
            }
            if (password.Length >= 20)
            {
                throw new WrongPasswordException("password >=20");
            }
            if (!IsMatchedThePattern(password, '_'))
            {
                throw new WrongPasswordException("bad");
            }
            
            return password==confirmPassword;


        }
        private static bool IsMatchedThePattern(string login, char symbol)
        {
            char[] loginChars = login.ToCharArray();
            bool isPatternMatched = true;
            foreach(char c in loginChars)
            {
                if(!Char.IsLetter(c) && !Char.IsDigit(c) && c != symbol)
                {
                 isPatternMatched = false;
                    return false;
                }
            }
            return true;
        }


    }
}

