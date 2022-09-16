using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    public class Letter : Parcel
    {
        private decimal _fixedCost;

        // Precondition:  Calccost, origin address, and destination address must not be null and
        // Postcondition: The Letter is created with the specified values for origin address, destination address, and cost
        public Letter(Address originAddress, Address destinationAddress, decimal cost) : base(originAddress, destinationAddress)
        {
            _fixedCost = cost;
        }
        public decimal FixedCost 
        {
            // Precondition:  None
            // Postcondition: The Letters fixed cost has been returned 
            get { return _fixedCost; }
            
            // Precondition:  Value >= 0
            // Postcondition: The Letter's fixed cost has been set to the specified values
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException($"{nameof(FixedCost)}", value, $"{nameof(FixedCost)} must be >= 0");
                else
                    _fixedCost = value;
            }
        }

        public override decimal CalcCost()
        {
            return FixedCost;
        }

        public override string ToString()
        {
            string NL = Environment.NewLine;

            return $"Letter{NL}{base.ToString()}";
        }
    }
}