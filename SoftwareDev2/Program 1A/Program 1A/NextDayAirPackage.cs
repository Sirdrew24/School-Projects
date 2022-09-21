using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Program_1A
{
    public class NextDayAirPackage : AirPackage
    {
        private decimal _expressFee;

        public NextDayAirPackage(Address originAddress, Address destinationAddress, double pLength, double pWidth, double pHeight, double pWeight, decimal expressfee)
            : base(originAddress, destinationAddress, pLength, pWidth, pHeight, pWeight)
        {
            ExpressFee = expressfee;
        }

        public decimal ExpressFee
        {
            // Precondition:  None
            // Postcondition: The Package's express fee is returned
            get { return _expressFee; }

            // Precondition:  Value >= 0
            // Postcondition: The Package's express fee is set
            private set 
            { 
                if (value >= 0)
                    _expressFee = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(ExpressFee)}", value, $"{nameof(ExpressFee)} must be >= 0");
            }
        }

        // Precondition:  None
        // Postcondition: The next day air package's cost has been calculated and returned
        public override decimal CalcCost()
        {
            const double DIM_FACTOR = .35;
            const double WEIGHT_FACTOR = .25;
            const double HEAVY_FACTOR = .2;
            const double LARGE_FACTOR = .22;

            decimal cost;

            cost = (decimal)(DIM_FACTOR * TotalDimension + WEIGHT_FACTOR + Weight) + ExpressFee;

            if (IsHeavy())
                cost += (decimal)(HEAVY_FACTOR * Weight);

            if (IsLarge())
                cost += (decimal)(LARGE_FACTOR + TotalDimension);

            return cost;
        }

        // Precondition:  None
        // Postcondition: A string with the next day air package's data has been returned
        public override string ToString()
        {
            string NL = Environment.NewLine;

            return $"NextDay{base.ToString()}{NL}Express Fee: {ExpressFee:C}";
        }
    }
}
