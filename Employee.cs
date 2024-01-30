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
    class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public long Sin { get; set; }
        public string Dob { get; set; }
        public string Dept { get; set; }

        public Employee()
        {
            this.Id = "-------";
            this.Name = "Firstname Lastname";
            this.Address = "000 No Street, Nowhere";
            this.Phone = "(---) --------";
            this.Sin = 0;
            this.Dob = "None --, ----";
            this.Dept = "None";
        }

        public Employee(string id, string name, string address, string phone, long sin, string dob, string dept)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Sin = sin;
            this.Dob = dob;
            this.Dept = dept;
        }

        public virtual double GetPay()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"Data for employee {this.Name}:\n" +
                $"ID: {this.Id}\n" +
                $"Address: {this.Address}\n" +
                $"Phone: {this.Phone}\n" +
                $"SIN: {this.Sin}\n" +
                $"Date of Birth: {this.Dob}\n" +
                $"Department: {this.Dept}\n";
        }
    }
}
