//CPRG 211 F Lab 2 - Inheritance
//Michael (Zi) Liang 000921925
//Jan 24, 2024

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CPRG211Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert "\n" to char: referenced https://stackoverflow.com/questions/33946594/c-sharp-how-to-convert-string-to-char
            string[] employeesInfo = Properties.Resources.employees.Split(char.Parse("\n"));

            List<Employee> employees = new List<Employee>();

            //Populate list by parsing file
            //I could not find a way to write cleaner code to do this.
            foreach (string employeeInfo in employeesInfo)
            {
                //Convert ":" to char: referenced https://stackoverflow.com/questions/33946594/c-sharp-how-to-convert-string-to-char
                string[] info = employeeInfo.Split(char.Parse(":"));

                if (employeeInfo.StartsWith("0") || employeeInfo.StartsWith("1") || employeeInfo.StartsWith("2") || employeeInfo.StartsWith("3") || employeeInfo.StartsWith("4"))
                {
                    employees.Add(new Salaried(info[0], info[1], info[2], info[3], long.Parse(info[4]), info[5], info[6], double.Parse(info[7])));
                }
                else if (employeeInfo.StartsWith("5") || employeeInfo.StartsWith("6") || employeeInfo.StartsWith("7"))
                {
                    employees.Add(new Wages(info[0], info[1], info[2], info[3], long.Parse(info[4]), info[5], info[6], double.Parse(info[7]), double.Parse(info[8])));
                }
                else if (employeeInfo.StartsWith("8") || employeeInfo.StartsWith("9")) {
                    employees.Add(new PartTime(info[0], info[1], info[2], info[3], long.Parse(info[4]), info[5], info[6], double.Parse(info[7]), double.Parse(info[8])));
                }
            }

            //weekly pay
            double totalWeeklyPay = 0;
            int numEmployees = 0;
            foreach (Employee e in employees)
            {
                totalWeeklyPay += e.GetPay();
                numEmployees++;
            }
            Console.WriteLine($"The average weekly pay is ${Math.Round(totalWeeklyPay / numEmployees, 2)}.");

            //highest weekly pay
            double highestPay = 0;
            Employee highestPaid = null;
            foreach (Employee e in employees)
            {
                if (e is Wages)
                {
                    if (e.GetPay() > highestPay)
                    {
                        highestPay = e.GetPay();
                        highestPaid = e;
                    }
                }
            }
            Console.WriteLine($"The highest paid wage employee is {highestPaid.Name} who makes ${Math.Round(highestPay, 2)}.");

            //lowest salary
            double lowestPay = double.PositiveInfinity;
            Employee lowestPaid = null;
            foreach (Employee e in employees)
            {
                if (e is Salaried)
                {
                    if (e.GetPay() < lowestPay)
                    {
                        lowestPay = e.GetPay();
                        lowestPaid = e;
                    }
                }
            }
            Console.WriteLine($"The lowest paid salaried employee is {lowestPaid.Name} who makes ${Math.Round(lowestPay, 2)}.");

            //percentages of employee types
            double numEmployeesTotal = 0;
            double numSalaried = 0;
            double numWages = 0;
            double numPartTime = 0;
            foreach (Employee e in employees)
            {
                numEmployeesTotal++;
                if (e is Salaried)
                {
                    numSalaried++;
                }
                else if (e is Wages)
                {
                    numWages++;
                }
                else if (e is PartTime)
                {
                    numPartTime++;
                }
            }
            Console.WriteLine($"The company is {Math.Round(numSalaried / numEmployeesTotal * 100)}% salaried employees, {Math.Round(numWages / numEmployeesTotal * 100)}% wage employees, and {Math.Round(numPartTime / numEmployeesTotal * 100)}% part time employees.");
        }
    }
}
