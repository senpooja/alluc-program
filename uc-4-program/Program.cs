// See https://aka.ms/new-console-template for more information
Console.WriteLine("welcome to Employee Management app");
int IsFullTime = 1;
int IsPartTime = 2;
int empHrs = 0;
int EmpWage = 0;
Random random = new Random();
int EmpWagePerHrs = 20;
int EmpCheck = random.Next(0, 3);
if (EmpCheck == IsFullTime)
    switch (EmpCheck)
    {
    empHrs = 8;
}
else if (EmpCheck == IsPartTime)
{

    empHrs = 4;
}
else
{
    empHrs = 0;
        case 2: //IsPartTime=2//
        empHrs = 4;
    break;
        case 1: //IsFullTime=1//
        empHrs = 8;
    break;
    default:
        empHrs = 0;
    break;
}
EmpWage = empHrs * EmpWagePerHrs;
Console.WriteLine("Employees wage is: " + EmpWage);