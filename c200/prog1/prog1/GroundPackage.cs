// Program 1
// CIS 200-01
// Fall 2018
// Due: 9/24/2017
// By: D9689

// The GroundPackage class is a concrete derived class of Package.
// GroundPackage has a Zonedistance.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1
{
    public class GroundPackage : Package
    {
        private const int ZONE_DIVISER = 10000;          //constant variable used to divide the zip code by
        private const decimal SIZE_MULTIPLIER = .2M;     //constant variable used as multiplier for the size of the package
        private const decimal ZONE_MULTIPLIER = .05M;    //constant variable used as multiplier for the zone distance of the package

        // Precondition:  none
        // Postcondition: none
        public GroundPackage(Address origAdd, Address destAdd, double length, double width, double height, double weight)
            : base(origAdd, destAdd, length, width, height, weight)
        { }
                
        public int ZoneDistance
        {
            //Precondition:  none
            //Postcondition:  The zone distance has been calculated and returned
            get
            {
                    return Math.Abs((OriginAddress.Zip / ZONE_DIVISER) - (DestinationAddress.Zip / ZONE_DIVISER));
            }
        }

        //Precondition: none
        //Postcondition:  calculated and returned the cost of the ground package
        public override decimal CalcCost()
        {
            return SIZE_MULTIPLIER * (decimal)(Length + Width + Height) + ZONE_MULTIPLIER * (ZoneDistance + 1) * (decimal)(Weight);
        }

        // Precondition:  None
        // Postcondition: A String with the parcel's data has been returned
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Ground {base.ToString()}{NL}Zone distance: {ZoneDistance}";
        }
    }
}
