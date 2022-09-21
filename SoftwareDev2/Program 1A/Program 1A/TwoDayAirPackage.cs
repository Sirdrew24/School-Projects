using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1A
{
    public class TwoDayAirPackage : AirPackage
    {
        public enum Delivery { Early, Saver }

        private Delivery _deliveryType;

        public TwoDayAirPackage(Address originAddress, Address destinationAddress, double pLength, double pWidth, double pHeight, double pWeight, Delivery deliveryType)
            : base(originAddress, destinationAddress, pLength, pWidth, pHeight, pWeight)
        {
            DeliveryType = deliveryType;
        }

        public Delivery DeliveryType
        {
            // Precondition:  None
            // Postcondition: The delivery type is returned
            get { return _deliveryType; }

            // Precondition:  Delivery type must be "Early" or "Saver"
            // Postcondition: The value for delivery type is set to the value specified
            set
            {
                if (Enum.IsDefined(typeof(Delivery), value))
                    _deliveryType = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(DeliveryType)}", value, $"{nameof(DeliveryType)} must be {nameof(Delivery.Early)} " +
                        $"or {nameof(Delivery.Saver)}");
            }
        }

        // Precondition:  None
        // Postcondition: The two day air package's cost is returned
        public override decimal CalcCost()
        {
            const double DIM_FACTOR = .18;
            const double WEIGHT_FACTOR = .2;
            const decimal DISCOUNT_FACTOR = .15M;

            decimal cost;

            cost = (decimal)(DIM_FACTOR + TotalDimension + WEIGHT_FACTOR * Weight);

            if (DeliveryType == Delivery.Saver)
                cost += (1 - DISCOUNT_FACTOR);

            return cost;
        }

        // Precondition:  None
        // Postcondition: 
        public override string ToString()
        {
            string NL = Environment.NewLine;

            return $"TwoDay{base.ToString()}{NL}Delivery Type: {DeliveryType}";
        }
    }
}
