using System.Collections;

namespace ClassPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var company = new CompanyWage();
            Console.Write(" ----------- Practise Problems --------- \n 1. Swap Numbers \n 2. Check Case \n 3. Check Palindrome \n 4. Check Armstrong Number \n 5. Company Wise Wages \n 6. Exit \n Enter the number corresponding to required program : "); var input = Console.ReadLine();

            switch (input)
            {
                case "1": Swap.GetSwapedNumber(); Program.Main(args); break;
                case "2": Case.CheckCase(); Program.Main(args); break;
                case "3": PalindromeNumber.CheckNumber(); Program.Main(args); break;
                case "4": ArmstrongNumber.CheckNumber(); Program.Main(args); break;
                case "5":
                    {
                        company.AddCompany();
                        Console.WriteLine("Company Added !!");
                        Console.Write("Enter Company Name : "); var cname = Console.ReadLine();
                        company.GetWage(cname.ToUpper());
                        Program.Main(args);
                        break;
                    }
                case "6": break;
                default: Console.WriteLine("\n Try Again !!\n"); Program.Main(args); break;
            }
        }
    }
}