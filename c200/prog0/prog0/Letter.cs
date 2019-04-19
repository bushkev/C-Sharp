// Program 0
// CIS 200-01
// Due: 9/10/2018
// By: D9689

// This file sets a origin address, destination address, and a fix cost to a letter

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog0
{
    class Letter : Parcel
    {
        private decimal _fixCost;  //cost of shipping letter

        //Precondition:  None
        //Postcondition:  The OriginAddress, DestinationAddress, and fixCost are set to the appropriate values.
        public Letter(Address originAdd, Address destinationAdd, decimal fixCost):base(originAdd, destinationAdd)
        {
            FixCost = fixCost;
        }

        private decimal FixCost
        {
            //Precondition: None
            //Postcondition: The _fixCost value is returned
            get
            {
                return _fixCost;
            }

            //Precondition: value >= 0
            //Postcondition: The _fixCost value is set
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(FixCost)} must be a non-negative number.");
                else
                    _fixCost = value;
            }
        }

        // Precondition:  None
        // Postcondition: The ground package's cost has been returned
        public override decimal CalcCost()
        {
            return FixCost;
        }

        // Precondition:  None
        // Postcondition: a string of the letters data is returned
        public override string ToString() => $"{base.ToString()}\n\nCost: {CalcCost():C}"; 
    }
}
