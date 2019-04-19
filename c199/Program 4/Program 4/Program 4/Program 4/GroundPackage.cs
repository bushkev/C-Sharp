using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    class GroundPackage
    {
        private int _originZip;                         // variable that holds the value for the origination zip code
        private int _destinationZip;                    // variable that holds the value for the destination zip code
        private double _length;                         // variable that holds the value for the package length
        private double _width;                          // variable that holds the value for the package width
        private double _height;                         // variable that holds the value for the package height
        private double _weight;                         // variable that holds the value for the package weight
        const int oZipDefault = 40202;                  // const variable that holds the value for the default origination zip code
        const int oZipTop = 100000;                     // const variable that holds the value for the max origination zip code number
        const int dZipDefault = 90210;                  // const variable that holds the value for the default destination zip code
        const int dZipTop = 100000;                     // const variable that holds the value for the max destination zip code number
        const double lengthDefault = 1.0;               // const variable that holds the value for the default length
        const double widthDefault = 1.0;                // const variable that holds the value for the default width
        const double heightDefault = 1.0;               // const variable that holds the value for the default height
        const double weightDefault = 1.0;               // const variable that holds the value for the default weight
        const double dimensionRate = .2;                // const variable that holds the value for the multiplicatin rate of the package dimensions
        const double zoneDistRate = .5;                 // const variable that holds the value for the multiplicatin rate of the zone distance
        const int zoneDiviser = 10000;                      // const variable that holds the value for the division rate to find the zone distance

        // Precondition: six-parameter constructor
        // Postcondition: Assigns all parameters to specified variable
        public GroundPackage(int oZip, int dZip, double length, double width, double height, double weight)
        {
            OriginZip = oZip;
            DestinationZip = dZip;
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;

        }

        // property that gets and sets Origination zip code
        public int OriginZip
        {
            // Precondition: 0 <= value <= 10000
            // Postcondition: The zip code has been set to specified value
            set
            {
                if (value >= 0 && value < oZipTop) // validation
                    _originZip = value;
                else                            // when invalid set to default zip code
                    _originZip = oZipDefault;
            }

            // Precondition: none
            // Postcondition: The zip code has been returned
            get { return _originZip; }
        }

        // property that gets and sets destination zip code
        public int DestinationZip
        {
            // Precondition: 0 <= value <= 10000
            // Postcondition: The zip code has been set to specified value
            set
            {
                if (value >= 0 && value < dZipTop) // validation
                    _destinationZip = value;
                else                                // when invalid set to default zip code
                    _destinationZip = dZipDefault; 
            }

            // Precondition: none
            // Postcondition: The zip code has been returned
            get { return _destinationZip; }
        }

        // property that gets and sets package length
        public double Length
        {
            // Precondition: 0 <= value
            // Postcondition: The length has been set to specified value
            set
            {
                if (value >= 0) // validation
                    _length = value;
                else
                    _length = lengthDefault; // when invalid set to default length
            }

            // Precondition: none
            // Postcondition: The length has been returned
            get { return _length; }
        }

        // property that gets and sets package width
        public double Width
        {
            // Precondition: 0 <= value
            // Postcondition: The width has been set to specified value
            set
            {
                if (value >= 0) // validation
                    _width = value;
                else
                    _width = widthDefault; // when invalid set to default width
            }

            // Precondition: none
            // Postcondition: The width has been returned
            get { return _width; }
        }

        // property that gets and sets package height
        public double Height
        {
            // Precondition: 0 <= value
            // Postcondition: The height has been set to specified value
            set
            {
                if (value >= 0) // validation
                    _height = value;
                else
                    _height = heightDefault; // when invalid set to default height
            }

            // Precondition: none
            // Postcondition: The height has been returned
            get { return _height; }
        }

        // property that gets and sets package weight
        public double Weight
        {
            // Precondition: 0 <= value
            // Postcondition: The weight has been set to specified value
            set
            {
                if (value >= 0) // validation
                    _weight = value;
                else
                    _weight = weightDefault; // when invalid set to default weight
            }

            // Precondition: none
            // Postcondition: The weight has been returned
            get { return _weight; }
        }

        //Read-only property that gets the zone distance
        private int ZoneDistance
        {
            // Precondition: none
            // Postcondition: The zone distance has been calculated and returned
            get
            {
                return Math.Abs((OriginZip / zoneDiviser) - (DestinationZip / zoneDiviser));
            }
        }

        // Precondition: none
        // Postcondition: The cost has been calculated and returned
        public double CalcCost()
        {
            return dimensionRate * (Length + Width + Height) + zoneDistRate * (ZoneDistance + 1) * Weight;
        }

        // Precondition: none
        // Postcondition: The string representation of GroundPackage object, using properties is returned
        public override string ToString()
        {
            return $"Origination zip code:   {OriginZip,10:d5}{Environment.NewLine}" +
                   $"Destination zip code:   {DestinationZip,10:d5}{Environment.NewLine}" +
                   $"Length:                 {Length,10}{Environment.NewLine}" +
                   $"Width:                  {Width,10}{Environment.NewLine}" +
                   $"Height:                 {Height,10}{Environment.NewLine}" +
                   $"Weight:                 {Weight,10}";
        }
    }
}
