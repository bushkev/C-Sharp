// Program 1
// CIS 200-01
// Fall 2018
// Due: 9/24/2017
// By: D9689

// The TwoDayAirPackage is a concrete derived class of AirPackage.
// TwoDayAirPackage has an Delivery Enum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1
{
    public class TwoDayAirPackage : AirPackage
    {
        public enum Delivery { Early, Saver };                //enum for type of delivery
        private Delivery _deliveryType;                       //varianle that holds the delivery type
        private const decimal SIZE_MULTIPLIER = .25M;         //constant variable used as multiplier for the size of the package
        private const decimal WEIGHT_MULTIPLIER = .25M;       //constant variable used as multiplier for the weight of the package
        private const decimal SAVER_DISCOUNT_FACTOR = .9M;    //constant variable used as for multiplying factor of the discount rate

        // Precondition:  delivery type can only be Saver or Early
        // Postcondition: delivery type can only be Saver or Early is set to the value
        public TwoDayAirPackage(Address origAdd, Address destAdd, double length, double width, double height, double weight, Delivery deliveryType)
            : base(origAdd, destAdd, length, width, height, weight)
        {
            DeliveryType = deliveryType;
        }

        public Delivery DeliveryType
        {
            // Precondition:  None
            // Postcondition: The delivery type has been returned
            get
            {
                return _deliveryType;
            }

            // Precondition:  delivery type can only be Saver or Early
            // Postcondition: The delivery type has been set to the specified value
            set
            {
                if (value == Delivery.Early || value == Delivery.Saver)
                    _deliveryType = value;
                else
                    throw new ArgumentOutOfRangeException("DeliveryType", value, "Delivery type must be TwoDayAirPackage.Delivery.Saver or TwoDayAirPackage.Delivery.Early");
            }

        }

        //Precondition: none
        //Postcondition:  calculated and returned the cost of the TwoDayAirPackage
        public override decimal CalcCost()
        {
            decimal cost = SIZE_MULTIPLIER * (decimal)(Length + Width + Height) + WEIGHT_MULTIPLIER * (decimal)(Weight);

            if (DeliveryType == Delivery.Saver)
                cost *= SAVER_DISCOUNT_FACTOR;

            return cost;
        }

        // Precondition:  None
        // Postcondition: A String with the parcel's data has been returned
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Two Day {base.ToString()}{NL}Delivery Type: {DeliveryType}";
        }
    }
}
