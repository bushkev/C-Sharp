// Program 1
// CIS 200-01
// Fall 2018
// Due: 9/24/2017
// By: D9689

// The AirPackage serves as the abstract base class of the NextDayAirPackage and TwoDayAirPackage hierachy.
// AirPackage has an IsHeavy() and IsLarge().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1
{
    public abstract class AirPackage : Package
    {
        private const double WEIGHT_MAX = 75;        //constant that holds the determining weight amount
        private const double DIMENSION_MAX = 100;    //constant that holds the determining combined dimensions amount

        // Precondition:  none
        // Postcondition: none
        public AirPackage(Address origAdd, Address destAdd, double length, double width, double height, double weight)
            : base(origAdd, destAdd, length, width, height, weight)
        { }

        // Precondition:  none
        // Postcondition: boolean for if weight is heavy or not was returned
        public bool IsHeavy()
        {
            if (Weight >= WEIGHT_MAX)
                return true;
            else
                return false;
        }

        // Precondition:  none
        // Postcondition: boolean for if dimensions are to big or not was returned
        public bool IsLarge()
        {
            if (Height + Length + Width >= DIMENSION_MAX)
                return true;
            else
                return false;
        }

        // Precondition:  None
        // Postcondition: The parcel's cost has been returned
        public abstract override decimal CalcCost();

        // Precondition:  None
        // Postcondition: A String with the parcel's data has been returned
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            string message =  $"Air {base.ToString()}";

            if (IsHeavy())
                message += $"{NL}Package is heavy.";
            else
                message += $"{NL}Package is not heavy.";

            if (IsLarge())
                message += $"{NL}Package is Large.";
            else
                message += $"{NL}Package is not Large.";

            return message;
        }
    }
}
