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
                Console.WriteLine("1.Postal Code");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        PostalCode postalCode = new PostalCode();
                        Console.WriteLine("Enter PostalCode");
                        string code = Convert.ToString(Console.ReadLine());
                        postalCode.TestPinCode(code);
                        break;
                }
            }
           
        }
    }
}
