using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1A
{
    public abstract class Parcel
    {
        private Address _originAddress;
        private Address _destinationAddress;

        // Precondition:  origin address and destination address may not be null, empty nor whitespace
        // Postcondition: The Parcel is created with the specified values for origin address and destination address
        public Parcel(Address originAddress, Address destinationAddress)
        {
            OriginAddress = originAddress;
            DestinationAddress = destinationAddress;
        }

        public Address OriginAddress
        {
            // Precondition:  None
            // Postcondition: The Parcels' origin address has been returned
            get { return _originAddress; }

            // Precondition:  Value must not be null, empty nor whitespace
            // Postcondition: The Parcels' origin address has been set to the specified value
            set
            {
                if (value == null)
                    throw new ArgumentOutOfRangeException($"{nameof(OriginAddress)}", value, $"{nameof(OriginAddress)} must not be null");
                else
                    _originAddress = value;
            }
        }

        public Address DestinationAddress
        {
            // Precondition:  None
            // Postcondition: The Parcels' destination address has been returned
            get { return _destinationAddress; }

            // Precondition:  Value must not be null, empty nor whitespace
            // Postcondition: The Parcels' destination address has been set to the specified value
            set
            {
                if (value == null)
                    throw new ArgumentOutOfRangeException($"{nameof(DestinationAddress)}", value, $"{nameof(DestinationAddress)} must not be null");
                else
                    _destinationAddress = value;
            }
        }

        public abstract decimal CalcCost(); // Declares the CalcCost method to be overridden in classes that inherit this class

        public override string ToString()
        {
            string NL = Environment.NewLine;

            return $"Origin Address:{NL}{OriginAddress}{NL}{NL}Destination Address:{NL}" +
                $"{DestinationAddress}{NL}Cost: {CalcCost():C}";
        }
    }
}