using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1A
{
    abstract class Package : Parcel
    {
        private double _length;
        private string _width;  // length, width, and height are all in inches
        private string _height;
        private string _weight; // weight is in pounds
        protected Package(Address originAddress, Address destinationAddress, double pLength, double pWidth, double pHeight, double pWeight) : base(originAddress, destinationAddress)
        {

        }




        public override decimal CalcCost()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string NL = Environment.NewLine;

            return NL;
        }
    }
}
