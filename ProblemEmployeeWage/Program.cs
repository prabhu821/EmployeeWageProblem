namespace ProblemEmployeeWage;

public class Program
{
    static void Main(string[] args)
    {
        EmployeeWage employeeWage = new EmployeeWage();
        Console.WriteLine("Welcome to Employee Wage Computation Problem");
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\nSelect the option");
            Console.WriteLine("1.Attendance \n2.Daily Employee Wage \n3.Part Time Employee Wage \n4.Switch Case Statement " +
                "\n5.Exit");
            int check = Convert.ToInt32(Console.ReadLine());
            switch (check)
            {
                case 1:
                    employeeWage.Attendence();
                    break;
                case 2:
                    employeeWage.EmpWage();
                    break;
                case 3:
                    employeeWage.PartTime();
                    break;
                case 4:
                    employeeWage.SwitchCase();
                    break;
                default:
                    flag = false;
                    break;
            }
        }
    }
}