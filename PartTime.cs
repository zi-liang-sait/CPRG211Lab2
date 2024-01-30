﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211Lab2
{
    class PartTime : Employee
    {
        public double Rate { get; set; }
        public double Hours { get; set; }

        public PartTime()
        {
            this.Rate = 0;
            this.Hours = 0;
        }

        public PartTime(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours) : base(id, name, address, phone, sin, dob, dept)
        //Referenced https://www.geeksforgeeks.org/c-sharp-inheritance-in-constructors/ for syntax for this contructor
        {
            this.Rate = rate;
            this.Hours = hours;
        }

        public override double GetPay()
        {
            return this.Hours * this.Rate;
        }

        public override string ToString()
        {
            return $"Data for part time employee {this.Name}:\n" +
               $"ID: {this.Id}\n" +
               $"Address: {this.Address}\n" +
               $"Phone: {this.Phone}\n" +
               $"SIN: {this.Sin}\n" +
               $"Date of Birth: {this.Dob}\n" +
               $"Department: {this.Dept}\n" +
               $"Hourly Rate: {this.Rate}\n" +
               $"Hours Worked: {this.Hours}\n" +
               $"Weekly Pay: {this.GetPay()}\n";
        }
    }
}
