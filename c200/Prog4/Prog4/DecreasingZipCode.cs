// Program 4
// CIS 200-01
// Fall 2018
// Due: 11/26/2018
// By: D9689

// This is a class that compares 2 parcels by decreasing destination zip code

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class DecreasingZipCode : Comparer <Parcel>
    {
        // Precondition:  None
        // Postcondition: A -1,0, or 1 is returned depending on comparision
        public override int Compare(Parcel temp1, Parcel temp2)
        {
            if (temp1 == null && temp2 == null)
                return 0;
            else if (temp2 == null)
                return 1;
            else if(temp1 == null)
                return -1;
            
            return -1 * temp1.DestinationAddress.Zip.CompareTo(temp2.DestinationAddress.Zip);
        }
    }
}
