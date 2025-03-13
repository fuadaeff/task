using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp_tasts_v2
{
    public class Car : Vehicle
    {
        public override void StartEngine() {
            Console.WriteLine("Car's engine starting..Woom woomm..");
        }
        public override void StopEngine()
        {
            Console.WriteLine("Car's engine stopped.");
        }
    }
}
