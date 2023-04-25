using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool areCredentialsValid= false;

            try
            {
                areCredentialsValid = CredentialsVerifier.VerifCredentials("4325", "1235", "1235");
            }
            catch (WrongLoginExceprion ex)
            {
                 Console.WriteLine(ex.Message);
            }
            catch (WrongPasswordException ex)
            {
                 Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                  Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }
}
