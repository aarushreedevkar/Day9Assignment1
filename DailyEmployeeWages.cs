using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblems
{
     public class DailyEmployeeWages
    {
        public const int PRESENT = 1;
        public const int EMP_RATE_PER_HR = 20;
        public int empHrs = 0;
        public int empwage = 0;

        public void EmployeeDailyWage()
        {
            Random random = new Random();
            int employeeCheck = random.Next(0, 2);



            if (employeeCheck == PRESENT)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            //computation
            empwage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("emp wage per day " + empwage);

        }
    }
}

