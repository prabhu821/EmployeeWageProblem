using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemEmployeeWage;

//UC9
public class EmpWageBuilder
{
    //Declaring Constant Variable
    public const int FULL_TIME = 1;
    public const int PART_TIME = 2;
    public string company;
    public int maxHoursPerMonth, max_working_days,wage_per_hour;

    public void EmployeeWage(string company, int wage_per_hour, int max_working_days, int maxHoursPerMonth)
    {
        this.company = company;
        this.wage_per_hour = wage_per_hour;
        this.max_working_days = max_working_days;
        this.maxHoursPerMonth = maxHoursPerMonth;
    }
    public void ComputeWage()
    {
        //Creating a Random Function
        int empHours = 0;
        int empDailyWage = 0;
        int workingDays = 1;
        int workingHrs = 0;
        int totalWage = 0;

        Random r = new Random();

        while (workingDays <= max_working_days && workingHrs <= maxHoursPerMonth)
        {
            //Calling the next method in Random Class
            int empAttendance = r.Next(0, 3);
            switch (empAttendance)
            {
                case FULL_TIME:
                    empHours = 8;
                    break;
                case PART_TIME:
                    empHours = 4;
                    break;
                default:
                    empHours = 0;
                    break;

            }
            empDailyWage = empHours * wage_per_hour;
            totalWage += empDailyWage;
            workingHrs += empHours;
            if (empAttendance != 0)
            {
                workingDays++;
            }
        }
        Console.WriteLine("Company Name:" + company);
        Console.WriteLine("Working Hours :" + workingHrs);
        Console.WriteLine("Employee Wage Per day :" + empDailyWage);
        Console.WriteLine("Employee Wage for 20 working days :" + totalWage);
    }
}
