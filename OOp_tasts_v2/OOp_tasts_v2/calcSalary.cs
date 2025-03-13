using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp_tasts_v2
{
    public class calcSalary
    {
        private string name;
        private decimal hourlyRate;
        private int hoursWorked;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }
        public int HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }
        public calcSalary(string name, decimal hourlyrate, int hoursworked)
        {
            Name = name;
            HourlyRate = hourlyrate;
            HoursWorked = hoursworked;
        }
        public void Calculate()
        {
            Console.WriteLine($"{Name}'s salary is: {hoursWorked * hourlyRate}");
        }
    }
}
