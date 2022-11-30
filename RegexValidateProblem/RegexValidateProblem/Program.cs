using RegexValidateProblem.RegexDemo;

namespace RegexValidateProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Enter option");
                Console.WriteLine(" 1.Postal Code\n 2.Taking Alphabet At Begninning");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        PostalCode postalCode = new PostalCode();
                        Console.WriteLine("Enter Postal Code");
                        string code = Convert.ToString(Console.ReadLine());
                        postalCode.TestPinCode(code);
                        break;
                    case 2:
                        PostalCode postalCode1 = new PostalCode();
                        Console.WriteLine("Enter PostalCode");
                        string code1 = Convert.ToString(Console.ReadLine());
                        postalCode1.AlphabetAtBeginning(code1);
                        break;
                }
            }
           
        }
    }
}
