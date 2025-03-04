using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace tasks
{
    public class Engine {
        private int horsePower;
        private string fuelType;
        public int HorsePower {
            get { return horsePower; }
            set { horsePower = value; }
        }
        public string FuelType {
            get { return fuelType; }
            set { fuelType = value; }
        }
        public Engine(int horsePower, string fuelType) {
            HorsePower = horsePower;
            FuelType = fuelType;
        }

    }
}
