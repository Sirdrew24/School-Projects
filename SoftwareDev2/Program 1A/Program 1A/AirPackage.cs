using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Program_1A
{
    abstract class AirPackage : Package
    {
        public const double HEAVY_THRESHOLD = 75; // Min weight of a heavy package
        public const double LARGE_THRESHOLD = 100; // Min dimensions of a large package

        // Precondition:  pLength > 0, pWidth > 0, pHeight > 0, pWeight > 0
        // Postcondition: The air package is created with the specified values for origin address, destination address,
        //                length. width, height, and weight
        public AirPackage(Address originAddress, Address destinationAddress, double pLength, double pWidth, double pHeight, double pWeight)
            : base(originAddress, destinationAddress, pLength, pWidth, pHeight, pWeight)
        {
            // All work done in base class constructor
        }

        // Precondition:  None
        // Postcondition: Returns true if air package is considered heavy else returns false
        public bool IsHeavy()
        {
            return (Weight >= HEAVY_THRESHOLD);
        }

        // Precondition:  None
        // Postcondition: Returns true if air package is considered large else returns false
        public bool IsLarge()
        {
            return (TotalDimension >= LARGE_THRESHOLD);
        }

        // Precondition:  None
        // Postcondition: A string with air package's data has been returned
        public override string ToString()
        {
            string NL = Environment.NewLine;

            return $"Air{base.ToString()}{NL}Heavy: {IsHeavy()}{NL}Large: {IsLarge()}";
        }
    }
}
