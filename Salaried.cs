//CPRG 211 F Lab 2 - Inheritance
//Michael (Zi) Liang 000921925
//Jan 24, 2024

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211Lab2
{
    class Salaried : Employee
    {
        public double Salary { get; set; }

        public Salaried()
        {
            this.Salary = 0;
        }

        public Salaried(string id, string name, string address, string phone, long sin, string dob, string dept, double salary) : base(id, name, address, phone, sin, dob, dept)
        //Referenced https://www.geeksforgeeks.org/c-sharp-inheritance-in-constructors/ for syntax for this contructor
        {
            this.Salary = salary;
        }

        public override double GetPay()
        {
            return this.Salary;
        }

        public override string ToString()
        {
            return $"Data for salaried employee {this.Name}:\n" +
               $"ID: {this.Id}\n" +
               $"Address: {this.Address}\n" +
               $"Phone: {this.Phone}\n" +
               $"SIN: {this.Sin}\n" +
               $"Date of Birth: {this.Dob}\n" +
               $"Department: {this.Dept}\n" +
               $"Weekly Salary: {this.Salary}\n";
        }
    }
}
