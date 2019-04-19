// Program 1
// CIS 200-01
// Fall 2018
// Due: 9/24/2017
// By: D9689

// Package serves as the abstract base class of the GroundPackage and AirPackage hierachy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1
{
    public abstract class Package : Parcel
    {
        private double _length;         
        private double _width;      //variable to hold the width of the package
        private double _height;     //variable to hold the height of the package
        private double _weight;     //variable to hold the weight of the package
        private const double MIN_LENGTH = 0;     //constant to hold the minimum length of the package
        private const double MIN_WIDTH = 0;      //constant to hold the minimum width of the package
        private const double MIN_HEIGHT = 0;     //constant to hold the minimum height of the package
        private const double MIN_WEIGHT = 0;     //constant to hold the minimum weight of the package

        // Precondition:  length > 0; width > 0; height > 0; weight > 0
        // Postcondition: The package is created with the specified values for
        //                origin address, destination address, length, width, height, and weight
        public Package (Address origAdd, Address destAdd, double length, double width, double height, double weight) 
            :base(origAdd, destAdd)
        {
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }

        public double Length
        {
            // Precondition:  None
            // Postcondition: The length has been returned
            get => _length;

            // Precondition:  value > 0
            // Postcondition: The length has been set to the specified value
            set
            {
                if (value <= MIN_LENGTH)
                {
                    throw new ArgumentOutOfRangeException("Length", value, "Length must be a number greater than zero.");
                }
                else
                    _length = value;
            }
        }

        public double Width
        {
            // Precondition:  None
            // Postcondition: The width has been returned
            get => _width;

            // Precondition:  value > 0
            // Postcondition: The width has been set to the specified value
            set
            {
                if (value <= MIN_WIDTH)
                {
                    throw new ArgumentOutOfRangeException("Width", value, "Width must be a number greater than zero.");
                }
                else
                    _width = value;
            }
        }

        public double Height
        {
            // Precondition:  None
            // Postcondition: The height has been returned
            get => _height;

            // Precondition:  value > 0
            // Postcondition: The height has been set to the specified value
            set
            {
                if (value <= MIN_HEIGHT)
                {
                    throw new ArgumentOutOfRangeException("Height", value, "Height must be a number greater than zero.");
                }
                else
                    _height = value;
            }
        }

        public double Weight
        {
            // Precondition:  None
            // Postcondition: The weight has been returned
            get => _weight;

            // Precondition:  value > 0
            // Postcondition: The weight has been set to the specified value
            set
            {
                if (value <= MIN_WEIGHT)
                {
                    throw new ArgumentOutOfRangeException("Weight", value, "Weight must be a number greater than zero.");
                }
                else
                    _weight = value;
            }
        }

        // Precondition:  None
        // Postcondition: The parcel's cost has been returned
        public override abstract decimal CalcCost();

        // Precondition:  None
        // Postcondition: A String with the parcel's data has been returned
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Package{NL}{NL}{base.ToString()}{NL}Length: {Length}{NL}Width: {Width}{NL}Height: {Height}{NL}Weight: {Weight}";
        }
    }
}
