using System.Collections;

namespace ClassPractise
{
    public class CompanyWage : IMonthlyWage
    {
        public Dictionary<string, ArrayList> Companies = new Dictionary<string, ArrayList>();

        public void AddCompany()
        {
            Console.Write("Enter company name : "); var cname = Console.ReadLine();

            if (Companies.ContainsKey(cname.ToUpper()))
            {
                Console.WriteLine("Company already exists ! TRY AGAIN ");
            }    

            Console.Write("Enter Full time Hours : "); var fullHours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Part time Hours : "); var partHours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Maximum Monthly Hours : "); var monthlyHours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Working Days in a month : "); var monthlyDays = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Wage per Hour : "); var wagePerHour = Convert.ToInt32(Console.ReadLine());

            var CompanyDetails = new ArrayList { fullHours, partHours, monthlyHours, monthlyDays, wagePerHour };
            Companies.Add(cname.ToUpper(), CompanyDetails);
        }

        private int Attendance()
        {
            var chkAttendance = new Random();
            var status = chkAttendance.Next(0,3);
            return status;
        }

        public void GetWage(string companyName)
        {
            if (!Companies.ContainsKey(companyName))
            {
                Console.WriteLine("Company Does Not Exists. Please add the company firts");
                AddCompany();
            }

            var workingDays = 0;
            var workingHours = 0;
            var dailyWage = 0;
            var monthlyWage = 0;

            while (workingHours < (int)Companies[companyName][2] && workingDays < (int)Companies[companyName][3])
            {
                var attendance = Attendance();
                if (attendance == 2)
                {
                    dailyWage = (int)Companies[companyName][0] * (int)Companies[companyName][4];
                    workingHours += (int)Companies[companyName][0];
                    workingDays++;
                }
                else if (attendance == 1)
                {
                    dailyWage = (int)Companies[companyName][1] * (int)Companies[companyName][4];
                    workingHours += (int)Companies[companyName][1];
                    workingDays++;
                }
                else
                    dailyWage = 0;
                
                monthlyWage += dailyWage;
            }
            Console.WriteLine("\n >>>> Monthly Wage of {0} is ${1}",companyName,monthlyWage);
        }
    }
}