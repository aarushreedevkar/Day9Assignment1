namespace EmployeeWageProblems{

    class Program {

        public static void Main(string[] args)
        {
            EmployeePresentAbsent employeePresentAbsent = new EmployeePresentAbsent();
            employeePresentAbsent.EmployeePresentOrAbsent();

            DailyEmployeewages dailyEmpwage = new DailyEmployeewages();
            dailyEmpwage.EmployeeDailyWage()

            PartTimeEmployeeWages partTimeEmployeeWage = new PartTimeEmployeeWages();
            partTimeEmployeeWage.PartTimeWage();

            CalculateWages calculateWages = new CalculateWages();
            calculateWages.calculateHrswages();

            SwitchCaseStatement switchCaseStatement = new SwitchCaseStatement();
            switchCaseStatement.CaseStatement();

            MonthlyEmpWages monthlyEmpWage = new MonthlyEmpWages();
            monthlyEmpWage.MontlyWageComputation();

            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.ComputeWage();

            MultipleCompanies multipleCompanies = new MultipleCompanies();
            multipleCompanies.ComputeWage();

        }


    }

}
