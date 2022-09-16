using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1A
{
    internal class TwoDayAirPackage : AirPackage
    {
        public TwoDayAirPackage(Address originAddress, Address destinationAddress) : base(originAddress, destinationAddress)
        {
        }

        public override decimal CalcCost()
        {
            return base.CalcCost();
        }
    }
}
