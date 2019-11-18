// Grading ID: D9817
// Prog 1A
// Due: 09/24/2018
// Section: CIS200-01
// This class creates the GroundPackage Object

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class GroundPackage : Package
    {
        // Pre-condition: None
        // Post-condition: The GroundPackage object is created with the specified
        //                 values OriginAddress, DestinationAddress, Length, Width,
        //                 Height, Weight
        public GroundPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight) 
            : base (originAddress, destAddress, length, width, height, weight)
        {
            // No body
        }
        public int ZoneDistance
        {
            // Pre-condition: None
            // Post-condition: Returns the ZoneDistance
            get
            {
                const int DENOMINATOR = 10000; // Holds the denominator by which we devide the zipcodes
                int origTemp = OriginAddress.Zip; // Holds the value of the origin zipcode
                int destTemp = DestinationAddress.Zip; //Holds the value of the destination zipcode

                destTemp = destTemp / DENOMINATOR;
                origTemp = origTemp / DENOMINATOR;

                int result = destTemp - origTemp; // Holds the result after the math is done

                return Math.Abs(result); // Turns the result to always be a positive result
            }
        }
        // Pre-condition: None
        // Post-condition: Returns the calculated cost for the GroundPackage
        public override decimal CalcCost()
        {
            decimal cost; // Holds the decimal cost to return
            const float SIZE_FACTOR = .20f; // Holds the Size factor
            const float DISTANCE_WEIGHT_FACTOR = .05f; // Holds the weight factor

            cost = (decimal)(SIZE_FACTOR * (Length + Width + Height) + DISTANCE_WEIGHT_FACTOR*(ZoneDistance + 1) * (Weight));

            return cost;
        }
        // Pre-condition: None
        // Post-condition: Returns the Origin/Destination Address with package dimensions
        //                 and the Cost
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut
            return base.ToString() + NL + $"Cost: {CalcCost():C}";
        }
    }
}
