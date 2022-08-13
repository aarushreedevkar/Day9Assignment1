using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblems
{
    public class MonthlyEmpWages
    {
        public const int Full_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int WORKING_DAYS = 20;
        //local variables
        public int empHrs = 0;
        public int empWage = 0;
        public int totalEmpWage = 0;
        public int totalWage = 0;
        public void MontlyWageComputation()
        {
            Random random = new Random();
            int employeeCheck = random.Next(0, 3);

            for (int day = 0; day < WORKING_DAYS; day++)
            {


                switch (employeeCheck)
                {
                    case Full_TIME:
                        empHrs = 8;
                        break;

                    case PART_TIME:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;

                        //computation
                        empWage = EMP_RATE_PER_HR * empHrs;
                        totalEmpWage = totalWage + empWage;

                        Console.WriteLine("Emp wage for 20 days " + totalEmpWage);
                }
            }
        }
    }
}
    

