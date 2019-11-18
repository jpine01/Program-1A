// Grading ID: D9817
// Prog 1A
// Due: 09/24/2018
// Section: CIS200-01
// This class creates the NextDayAirPackage Object

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public class NextDayAirPackage : AirPackage
    {
        private decimal _expressFee; // Holds the Express fee
        // Pre-condition: ExpressFee >= 0
        // Post-condition: The NextDayAirPackage object is created with the specified
        //                 values OriginAddress, DestinationAddress, Length, Width,
        //                 Height, Weight and ExpressFee
        public NextDayAirPackage(Address origAddress, Address destAddress, double length, double width, double height, 
            double weight, decimal expressFee) : base(origAddress, destAddress, length, width, height, weight)
        {
            _expressFee = expressFee; // Assigned the fee
        }
        public decimal ExpressFee
        {
            // Pre-condition: None
            // Post-condition: Returns the Express Fee
            get
            {
                return _expressFee;
            }
        }
        // Pre-condition: None
        // Post-condition: Calculates the cost depending on weight and size of the package
        public override decimal CalcCost()
        {
            decimal cost; // Holds the cost to be returned
            const float SIZE_FACTOR = .40f; // Holds the factor for calculating size
            const float WEIGHT_FACTOR = .30f; // Holds the factor for calculating weight
            const float HEAVY_OR_LARGE_FACTOR = .25f; // Holds the factor for calculating packages that are heavy or large

            cost = (decimal)(SIZE_FACTOR * (Length + Width + Height) + WEIGHT_FACTOR * (Weight) + (double)ExpressFee);

            if (IsHeavy())
                cost += (decimal)(HEAVY_OR_LARGE_FACTOR * (Weight));

            if (IsLarge())
                cost += (decimal)(HEAVY_OR_LARGE_FACTOR * (Length + Width + Height));

            return cost;
        }
        // None
        // Returns everything from base class plus the Express fee and the Cost
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return base.ToString() + NL + "Express Fee: " + $" {ExpressFee:C} {NL} Cost: { CalcCost():C}";
        }
    }
}
