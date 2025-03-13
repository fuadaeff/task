using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp_tasts_v2
{
    public class tempConverter
    {
        private double farenheit;
        public double Farenheit
        {
            get { return farenheit; }
            set 
            {
                farenheit = value;
                celcius = (farenheit - 32) * 5 / 9;
            }
        }
        private double celcius;
        public double Celcius
        {
            get { return celcius; }
            set 
            { 
                celcius = value;
                farenheit = (celcius * 9 / 5) + 32;
            }
        }
        public tempConverter(double temp)
        {
            Celcius = temp;
        }
        public void GetTemp()
        {
            Console.WriteLine($"Celcius: {Celcius},Farenheit: {Farenheit}");
        }
    }
}
