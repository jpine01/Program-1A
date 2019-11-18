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
    public class TwoDayAirPackage : AirPackage
    {
        public enum Delivery { Early, Saver}; // Emun list created
        private string _deliveryType; // Holds the Options for Delivery type
        private int type; // Holds the interger number for the Delivery Type

        // Pre-condition: None
        // Post-condition: The NextDayAirPackage object is created with the specified
        //                 values OriginAddress, DestinationAddress, Length, Width,
        //                 Height, Weight and Delivery Type
        public TwoDayAirPackage(Address origAddress, Address destAddress, double length, double width, double height, double weight,
            int deliveryType) 
            : base(origAddress, destAddress, length, width, height, weight)
        {
            DeliveryType = deliveryType == 0 ? "Early" : "Saver"; // Assigns the delivery type at construction
        }
        public string DeliveryType
        {
            // Pre-condition: None
            // Post-condition: Returns the Delivery type
            get
            {
                return _deliveryType;
            }
            // Pre-condition: Must be a 0 or a 1
            // Post-condition: Sets the Type to "Early" or "Saver"
            set
            {
                _deliveryType = value;
                
            }
        }
        // Pre-condition: None
        // Post-condition: Calculates the cost for Savers or Early packages
        public override decimal CalcCost()
        {
            decimal cost; // Holds the cost to be returned
            const float SIZE_AND_WEIGHT_FACTOR = .25f; // Holds the factor that goes into the equation for calc cost
            const decimal TEN_PERCENT = .9m; // Hold the number to multiply by to get a 10% off

            cost = (decimal)(SIZE_AND_WEIGHT_FACTOR * (Length + Width + Height) + SIZE_AND_WEIGHT_FACTOR * (Weight));

            if (DeliveryType == "Saver")
                cost *= TEN_PERCENT;

            return cost;
        }
        // Pre-condition: None
        // Post-condition: Returns base plus Delivery type and the Cost
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut
            return base.ToString() + NL + $"Delivery Type: {DeliveryType}{NL}Cost: {CalcCost():C}";
        }
    }
}
