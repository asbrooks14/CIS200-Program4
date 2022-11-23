// Program 4
// CIS 200-50
// Fall 2021
// Due: 12/2/2021
// By: 5129153 (from Program 1A Solution)

// File: DescendingOrderDestinationZip.cs
// Provids IComparer for Parcel class that
// sorts destination address zip codes in descending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class DescendingOrderByDestinationZipCode : Comparer<Parcel>
    {
        int zip1; // destination zip 1
        int zip2; // destination zip 2

        // precondition: none
        // postcondition: p1 < p2, returns positive
        //                p1 == p2, returns 0
        //                p1 > p2, returns negative
        //                sorts by destination zip, descending order
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

            zip1 = p1.DestinationAddress.Zip; // zip1 set to p1's destination zip
            zip2 = p2.DestinationAddress.Zip; // zip2 set to p2's destination zip

            return (-1) * zip1.CompareTo(zip2); // descending order
        }
    }
}
