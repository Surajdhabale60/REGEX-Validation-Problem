using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexValidateProblem
{
    namespace RegexDemo
    {
        public class PostalCode
        {
            const string PIN_CODE_PATTERN = "^[0-9]{6}$";
            const string PIN_CODE_ATBEGINNING = "^[0-9]{7}$";
            public void TestPinCode(string input)
            {
                if (Regex.IsMatch(input, PIN_CODE_PATTERN))
                {
                    Console.WriteLine("Pin code matches");
                }
                else
                {
                    Console.WriteLine("Pin code failed");
                }
            }
            public void AlphabetAtBeginning(string input)
            {
                if (Regex.IsMatch(input, PIN_CODE_ATBEGINNING))
                {
                    Console.WriteLine("Pin code matches");
                }
                else
                {
                    Console.WriteLine("Pin code failed");
                }
            }
        }
    }
}
