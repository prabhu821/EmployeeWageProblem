using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemEmployeeWage;

public class EmployeeWage
{
    const int WAGE_PER_HR = 20, FULL_DAY_HR = 8, HALF_DAY_HR = 4, IS_PRESENT = 0, IS_FULL_TIME = 1, MONTH_WORK_DAY = 20;
    Random random = new Random();

    //UC1
    public void Attendence()
    {
        int empCheck = random.Next(0, 2);
        if (empCheck == 0)
            Console.WriteLine("Employee is Present");
        else
            Console.WriteLine("Employee is Absent");
    }

    //UC2
    public void EmpWage()
    {
        int dailyEmpWage = 0, empHrs = 0;
        int empCheck = random.Next(0, 2);
        if (empCheck == IS_FULL_TIME)
            empHrs = FULL_DAY_HR;
        else
            empHrs = 0;
        dailyEmpWage = WAGE_PER_HR * empHrs;
        Console.WriteLine("Daily Emp Wage Full Day :" + dailyEmpWage);
    }
}
