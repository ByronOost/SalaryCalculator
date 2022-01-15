/*
 Byron Oosthuizen 
 19002371
 ICE TASK 2
 */

using System;
using static System.Console;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string strEmpType;
            string strID;
            string strName;
            double FedTax = 0, Retire = 0, SocialSecurity = 0;
            double Salary, Hours;

            WriteLine("Please input Employees full name:");
            strName = ReadLine();

            WriteLine("Please input your ID:");
            strID = ReadLine();

            WriteLine("Please enter the Employee Type: (Salaried/Hourly)");
            strEmpType = ReadLine();

            if (strEmpType == "Salaried")
            {
                WriteLine("What is Federal Tax Percentage  e.g.(12)");
                FedTax = double.Parse(ReadLine());

                WriteLine("What is Your Retirement Percentage  e.g.(10)");
                Retire = double.Parse(ReadLine());

                WriteLine("What is Your Social Security Percentage  e.g.(6)");
                SocialSecurity = double.Parse(ReadLine());

                WriteLine("Enter your Monthly Salary: ");
                double.TryParse(ReadLine(), out Salary);
            }
            else
            {
                WriteLine("Enter your Hourly pay: ");
                double.TryParse(ReadLine(), out Salary);
                WriteLine("Enter your Hours worked: ");
                double.TryParse(ReadLine(), out Hours);

                if (Hours > 40)
                {
                    Salary = Salary * 40;
                    Salary += Salary * ((Hours - 40) * 1.5);
                }
                else
                {
                    Salary = Salary * Hours;
                }
            }
            FedTax = FedTax / 100;
            Retire = Retire / 100;
            SocialSecurity = SocialSecurity / 100;
            Salary -= Salary * (FedTax + Retire + SocialSecurity);

            WriteLine("\n***************************************\n" +
                "FullName: " + strName + "\n" +
                "Employee ID: " + strID + "\n" +
                "Employee Type: " + strEmpType + "\n" +
                "Salary: R" + Salary);
            ReadKey();

        }
    }
}