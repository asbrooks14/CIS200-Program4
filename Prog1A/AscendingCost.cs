// Program 4
// CIS 200-50
// Fall 2021
// Due: 12/2/2021
// By: 5129153 (from Program 1A Solution)

// File: DescendingOrderDestinationZip.cs
// Provids IComparer for Parcel class that
// sorts parcels in ascending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class AscendingCost : Comparer<Parcel>
    {
        // precondition: none
        // postcondition: p1 < p2, returns positive
        //                p1 == p2, returns 0
        //                p1 > p2, returns negative
        //                sorts by ascending cost
        public override int Compare(Parcel p1, Parcel p2)
        {
            // return 0
            if (p1 == null && p2 == null)
            {
                return 0;
            }
                
            // return negative
            if (p1 == null)
            {
                return -1;
            }

            // return positive
            if (p2 == null)
            {
                return 1;
            }

            return (1) * p1.CompareTo(p2); // ascending order
        }
    }
}
