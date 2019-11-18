// Grading ID: D9817
// Prog 1A
// Due: 09/24/2018
// Section: CIS200-01
// This class creates the Package Object

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public abstract class Package : Parcel
    {
        private double _length; // This variable holds the Length for the package
        private double _width; // This variable holds the Width for the package
        private double _height; // This variable holds the Height for the package
        private double _weight; // This variable holds the Weight for the package

        // Pre-condition: None
        // Post-condition: The Package object is created with the specified
        //                 values OriginAddress, DestinationAddress, Length, Width,
        //                 Height, Weight
        public Package(Address originAddress, Address destAddress, double length, double width, double height, double weight) 
            : base (originAddress, destAddress)
        {
            Length = length; // This initiates the Length property
            Width = width; // This initiates the Width property
            Height = height; // This initiates the Height property
            Weight = weight; // This initiates the Weight property
        }
        public double Length
        {
            // Pre-condition: None
            // Post-condition: It returns the Length
            get
            {
                return _length;
            }
            // Pre-condition: Length > 0
            // Post-condition: If the value is valid it is set, else exception is thrown
            set
            {
                if (value <= 0)
                    throw new IndexOutOfRangeException($"{nameof(value)} Can not be less than 0");

                _length = value;
            }
        }
        public double Width
        {
            // Pre-condition: None
            // Post-condition: The Width is retuned
            get
            {
                return _width;
            }
            // Pre-condition: Width > 0
            // Post-condition: If the value is valid it is set, else exception is thrown
            set
            {
                if (value <= 0)
                    throw new IndexOutOfRangeException($"{nameof(value)} Can not be less than 0");

                _width = value;
            }
        }
        public double Height
        {
            // Pre-condition: None
            // Post-condition: Returns the Height
            get
            {
                return _height;
            }
            // Pre-condition: Height > 0
            // Post-condition: If the value is valid it is set, else exception is thrown
            set
            {
                if (value <= 0)
                    throw new IndexOutOfRangeException($"{nameof(value)} Can not be less than 0");

                _height = value;
            }
        }
        public double Weight
        {
            // Pre-condition: None
            // Post-condition: Returns the Weight
            get
            {
                return _weight;
            }
            // Pre-condition: Weight > 0
            // Post-condition: If the value is valid, it is set, else exception is thrown
            set
            {
                // do this
                _weight = value;
            }
        }
        // Precondition:  None
        // Postcondition: A String with the Package's data has been returned
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut
            return base.ToString() + NL + "Length: " + Length + NL + "Width: " + 
                Width + NL + "Height: " + Height + NL + "Weight: " + Weight;
        }
    }
}
