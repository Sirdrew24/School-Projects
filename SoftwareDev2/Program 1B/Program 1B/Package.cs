using Program_1B;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Program_1B
{
    public abstract class Package : Parcel
    {
        private double _length;
        private double _width;  // length, width, and height are all in inches
        private double _height;
        private double _weight; // weight is in pounds

        protected Package(Address originAddress, Address destinationAddress, double pLength, double pWidth, double pHeight, double pWeight)
            : base(originAddress, destinationAddress)
        {
            Length = pLength;
            Width = pWidth;
            Height = pHeight;
            Weight = pWeight;
        }

        public double Length
        {

            // Precondition:  None
            // Postcondition: The packages length has been returned
            get { return _length; }

            // Precondition:  Value > 0
            // Postcondition: The packages length has been set to the specified value
            set
            {
                if (value > 0)
                    _length = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Length)}", value, $"{nameof(Length)} must be > 0");
            }
        }

        public double Width
        {
            // Precondition:  None
            // Postcondition: The packages width has been returned
            get { return _width; }

            // Precondition:  Value > 0
            // Postcondition: The packages width has been set to the specified value
            set
            {
                if (value > 0)
                    _width = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Width)}", value, $"{nameof(Width)} must be > 0");
            }
        }

        public double Height
        {
            // Precondition:  None
            // Postcondition: The packages height has been returned
            get { return _height; }

            // Precondition:  Value > 0
            // Postcondition: The packages height has been set to the specified value
            set
            {
                if (value > 0)
                    _height = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Height)}", value, $"{nameof(Height)} must be > 0");
            }
        }

        public double Weight
        {
            // Precondition:  None
            // Postcondition: The packages weight has been returned
            get { return _weight; }

            // Precondition:  Value > 0
            // Postcondition: The packages weight has been returned
            set
            {
                if (value > 0)
                    _weight = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Weight)}", value, $"{nameof(Weight)} must be > 0");
            }
        }

        // Helper Property
        protected double TotalDimension
        {
            get { return (Length + Width + Height); }
        }

        // Precondition:  None
        // Postcondition: A string with the package's data has been returned
        public override string ToString()
        {
            string NL = Environment.NewLine;

            return $"Package{NL}{base.ToString()}{NL}Length: {Length:N1}{NL}Width: {Width:N1}{NL}" +
                $"Height: {Height:N1}{NL}Weight: {Weight:N1}";
        }
    }
}
