using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexValidateProblem
{
    public class EmailValidator
    {
        const string email1 = "^[a-z]";
        const string email2 = "^[a-zA-Z]+[@][a-zA-Z]{2,}$";
        const string email3 = "^[a-zA-Z]+[@]([a-zA-Z]{2,})+[.]([a-z]{2,})$";
        const string emailAll = "^[a-zA-Z]+[.+-_]{0-1}[a-z]+[@]+[a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
        public void VerifyEmail(string input)
        {
            if (Regex.IsMatch(input, email1))
            {
                Console.WriteLine("Email matches");
            }
            else
            {
                Console.WriteLine("Email failed");
            }
        }
        public void VerifyEmail2(string input)
        {
            if (Regex.IsMatch(input, email2))
            {
                Console.WriteLine("Email matches");
            }
            else
            {
                Console.WriteLine("Email failed");
            }
        }
        public void VerifyEmail3(string input)
        {
            if (Regex.IsMatch(input, email3))
            {
                Console.WriteLine("Email matches");
            }
            else
            {
                Console.WriteLine("Email failed");
            }
        }
        public void VerifyEmail4(string input)
        {
            if (Regex.IsMatch(input, emailAll))
            {
                Console.WriteLine("Email matches");
            }
            else
            {
                Console.WriteLine("Email failed");
            }
        }
    }
}
