using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Program 4
// CIS 200-01
// Fall 2018
// Due: 11/26/2018
// By: D9689

// This is a class that compares 2 parcels by type, then decreasing cost

namespace Prog1
{
    class ParcelSort: Comparer<Parcel>
    {
        // Precondition:  None
        // Postcondition: A -1,0, or 1 is returned depending on comparision
        public override int Compare (Parcel t1, Parcel t2)
        {
            if (t1 == null && t2 == null)
                return 0;
            else if (t1 == null)
                return -1;
            else if (t2 == null)
                return 1;

            if (t1.GetType().ToString().CompareTo(t2.GetType().ToString()) != 0)
                return t1.GetType().ToString().CompareTo(t2.GetType().ToString());
            else
                return -1 * t1.CalcCost().CompareTo(t2.CalcCost());
        }
    }
}
