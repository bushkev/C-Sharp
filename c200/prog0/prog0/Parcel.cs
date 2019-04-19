// Program 0
// CIS 200-01
// Due: 9/10/2018
// By: D9689

// This file is an abstract class that recieves and sets the information of origin and destination addresses.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace prog0
{
    abstract class Parcel
    {
        // Precondition:  None
        // Postcondition: The origin address has been returned or set
        Address OriginAddress { get; set; }
        // Precondition:  None
        // Postcondition: The destination address has been returned or set
        Address DestinationAddress { get; set; }

        //Precondition:  None
        //Postcondition:  The OriginAddress and DestinationAddress are set to the appropriate values.
        public Parcel(Address originAdd, Address destinationAdd)
        {
            OriginAddress = originAdd;
            DestinationAddress  = destinationAdd;
        }

        //Precondition:  None
        //Postcondition:  None
        public abstract decimal CalcCost();

        //Precondition:  None
        //Postcondition:  A string with the origin and destination data is returned
        public override string ToString() => $"Origin Address : \n{OriginAddress}\n\nDestination Address:\n{DestinationAddress}";
    }
}
