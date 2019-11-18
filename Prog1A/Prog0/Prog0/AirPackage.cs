// Grading ID: D9817
// Prog 1A
// Due: 09/24/2018
// Section: CIS200-01
// This class creates the AirPackage Object

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public abstract class AirPackage : Package
    {
        // Pre-condition: None
        // Post-condition: The AirPackage object is created with the specified
        //                 values OriginAddress, DestinationAddress, Length, Width,
        //                 Height, Weight
        public AirPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight) 
            : base (originAddress, destAddress, length, width, height, weight)
        {
            // Nothing here
        }
        // None
        // Returns if the Package is heavy or not
        public bool IsHeavy()
        {
            const int MAX_WEIGHT = 75; // Holds the Maximum weight for a package to be heavy

            if (Weight >= MAX_WEIGHT)
                return true;
            else
                return false;
        }
        // None
        // Returns if the package is large or not
        public bool IsLarge()
        {
            const int MAX_SIZE = 100; // Holds the Maximum size a package must be to be large

            if ((Length + Width + Height) > MAX_SIZE)
                return true;
            else
                return false;
        }
        // None
        // Returns all the information from base ToString() plus the IsHeavy() and IsLarge().
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut
            string heavy = IsHeavy() == true ? "Yes" : "No";
            string large = IsLarge() == true ? "Yes" : "No";

            return base.ToString() + NL + $"Heavy?: {heavy} {NL}Large?: {large}";
        }
    }
}
