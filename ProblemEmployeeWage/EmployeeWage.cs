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

    //UC3
    public void PartTime()
    {
        int dailyEmpWage = 0, empHrs = 0;
        int empCheck = random.Next(0, 2);
        if (empCheck == IS_PRESENT)
            empHrs = HALF_DAY_HR;
        else
            empHrs = 0;
        dailyEmpWage = WAGE_PER_HR * empHrs;
        Console.WriteLine("Daily Emp Wage Half Day :" + dailyEmpWage);
    }

    //UC4
    public void SwitchCase()
    {
        int dailyEmpWage = 0;
        int empCheck = random.Next(0, 2);
        switch (empCheck)
        {
            case 0:
                dailyEmpWage = WAGE_PER_HR * FULL_DAY_HR;
                Console.WriteLine("Daily Emp Wage Full Day :" + dailyEmpWage);
                break;
            case 1:
                dailyEmpWage = WAGE_PER_HR * HALF_DAY_HR;
                Console.WriteLine("Daily Emp Wage Half Day :" + dailyEmpWage);
                break;
            default:
                Console.WriteLine("Employee is absent");
                break;
        }
    }

    //UC5
    public void MonthlyWage()
    {
        int FullWage = 0, HalfWage = 0;
        int check = random.Next(0, 2);
        if (check == IS_PRESENT)
        {
            FullWage = MONTH_WORK_DAY * WAGE_PER_HR * FULL_DAY_HR;
            HalfWage = MONTH_WORK_DAY * WAGE_PER_HR * HALF_DAY_HR;
            Console.WriteLine("Monthly Employee Full Day :" + FullWage);
            Console.WriteLine("Monthly Employee Half Day :" + HalfWage);
        }
        else
        {
            Console.WriteLine("Monthly Employee is Absent");
        }
    }

    //UC6
    public void TotalMonthlyWages()
    {
        int day = 0, hours = 0, DailyEmpWage = 0, EmpWage = 0;
        while (day < 20 & hours < 100)
        {
            day++;
            hours += 8;
        }
        EmpWage = day * hours;
        DailyEmpWage = WAGE_PER_HR * EmpWage;
        Console.WriteLine("Employee Total Monthly Wage :" + DailyEmpWage);
    }

    //UC7
    public void RefactorEmployeeWageClass()
    {
        const int ABSENT = 0, IS_PART_TIME = 1, IS_FULL_TIME = 2, EMP_RATE_PER_HOUR = 20, NUMBER_OF_WORKING_DAYS = 20,
            MAX_HOURS_IN_MONTH = 100;

        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
        while (totalEmpHrs <= MAX_HOURS_IN_MONTH && totalWorkingDays < NUMBER_OF_WORKING_DAYS)
        {
            totalWorkingDays++;
            Console.WriteLine("Select the option");
            Console.WriteLine("\n1.Part Time" + "\n2.Full Time" + "\n3.Absent");

            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            totalEmpHrs += empHrs;
            Console.WriteLine("Day#" + totalWorkingDays + " Emp Hrs  :" + empHrs);
        }
        int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
        Console.WriteLine("Total Emp Wage :" + totalEmpWage);
    }

    //UC8
    public void EmpWagesForMultipleCompany(string company)
    {
        const int ABSENT = 0, IS_PART_TIME = 1, IS_FULL_TIME = 2, EMP_RATE_PER_HOUR = 20, NUMBER_OF_WORKING_DAYS = 20,
            MAX_HOURS_IN_MONTH = 100;

        int empHours = 0, empWage = 0, workingHrs = 0, totalWage = 0, Working_Days = 0;
        Random random = new Random();
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

        while (totalEmpHrs <= MAX_HOURS_IN_MONTH && totalWorkingDays < NUMBER_OF_WORKING_DAYS)
        {
            int empInput = random.Next(0, 4);
            switch (empInput)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            totalEmpHrs += empHrs;
        }
        int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
        Console.WriteLine("Employee is of {0} and monthly salary is : " + totalEmpWage, company);
    }
}
