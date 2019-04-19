// Program 1
// CIS 200-01
// Fall 2018
// Due: 9/24/2017
// By: D9689

// The NextDayAirPackage is a concrete derived class of AirPackage.
// NextDayAirPackage has an ExpressFee.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1
{
    public class NextDayAirPackage : AirPackage
    {
        private decimal _expressFee;                        //variable to hold the express fee of the package
        private const decimal MIN_FEE = 0M;                  //constant to hold the minimum accepted fee of the package
        private const decimal SIZE_MULTIPLIER = .4M;         //constant variable used as multiplier for the size of the package
        private const decimal WEIGHT_MULTIPLIER = .3M;       //constant variable used as multiplier for the weight of the package
        private const decimal IS_HEAVY_CHARGE = .25M;         //constant variable used as multiplier if the package is heavy
        private const decimal IS_LARGE_CHARGE = .25M;         //constant variable used as multiplier if the package is large

        // Precondition:  expressfee >= 0
        // Postcondition: express fee is set to the value
        public NextDayAirPackage(Address origAdd, Address destAdd, double length, double width, double height, double weight, decimal expressFee)
            : base(origAdd, destAdd, length, width, height, weight)
        {
            ExpressFee = expressFee;
        }

        public decimal ExpressFee
        {
            // Precondition:  None
            // Postcondition: The fee has been returned
            get
            {
                return _expressFee;
            }

            // Precondition:  value >= 0
            // Postcondition: The fee has been set to the specified value
            private set
            {
                if(value < MIN_FEE)
                {
                    throw new ArgumentOutOfRangeException("ExpressFee", value, "Express Fee must be a number greater than zero.");
                }
                else
                    _expressFee = value;
            }
        }

        //Precondition: none
        //Postcondition:  calculated and returned the cost of the NextDayAirPackage
        public override decimal CalcCost()
        {
            decimal cost = SIZE_MULTIPLIER * (decimal)(Length + Width + Height) + WEIGHT_MULTIPLIER * (decimal)(Weight) + ExpressFee;

            if (IsHeavy())
                cost += (decimal)(Weight) * IS_HEAVY_CHARGE;
            if (IsLarge())
                cost += (decimal)(Length + Width + Height) * IS_LARGE_CHARGE;

            return cost;
        }

        // Precondition:  None
        // Postcondition: A String with the parcel's data has been returned
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Next Day {base.ToString()}{NL}Express Fee: {ExpressFee}";
        }
    }
}
