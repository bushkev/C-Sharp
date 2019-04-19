// Program 0
// CIS 200-01
// Due: 9/10/2018
// By: D9689

// This file recieves and sets the information of addresses.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog0
{
    class Address
    {
        private string _name;       // Name of address
        private string _address1;   // 1st address line of address
        private string _address2;   // 2nd address line of address
        private string _city;       // city of address
        private string _state;      // state of address
        private int _zip;           // zip code of address

        // Validation values
        public const int MIN_ZIP = 00000; // Minimum zip code value
        public const int MAX_ZIP = 99999; // Maximum zip code value
        public const int STATE_ABBREVIATION_LENGTH = 2; // State abbreviation length

        // Precondition:  MIN_ZIP <= Zip <= MAX_ZIP,
        //                name, add1, add2, city, state, and zip must not be null or only white space
        //                state must be a 2 letters in length
        // Postcondition: The address is created with the specified values for
        //                name, address1, address2, city, state, zip.
        public Address(string name, string add1, string add2, string city, string state, int zip)
        {
            Name = name;
            Address1 = add1;
            Address2 = add2;
            City = city;
            State = state;
            Zip = zip;
        }

        // Precondition:  MIN_ZIP <= zip <= MAX_ZIP,
        //                name, add1, city, state, and zip must not be null or only white space
        //                state must be a 2 letters in length
        // Postcondition: The address is created with the specified values for
        //                name, address1, city, state, zip.
        //                address2 is set to ""
        public Address(string name, string add1, string city, string state, int zip)
        {
            Name = name;
            Address1 = add1;
            _address2 = "";
            City = city;
            State = state;
            Zip = zip;
        }

        public string Name
        {
            // Precondition:  None
            // Postcondition: The name has been returned
            get => _name;

            // Precondition:  must not be null or white space
            // Postcondition: The Name has been set to the specified value
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Name)} cannot be empty.");
                }

                _name = value;
            }
        }

        public string Address1
        {
            // Precondition:  None
            // Postcondition: The address1 has been returned
            get => _address1;

            // Precondition:  must not be null or white space
            // Postcondition: The address1 has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Address1)} cannot be empty.");
                }

                _address1 = value;
            }
        }

        public string Address2
        {
            // Precondition:  None
            // Postcondition: The address2 has been returned
            get => _address2;

            // Precondition:  must not be null or white space
            // Postcondition: The Address2 has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Address2)} cannot be empty.");
                }

                _address2 = value;
            }
        }

        public string City
        {
            // Precondition:  None
            // Postcondition: The city has been returned
            get => _city;

            // Precondition:  must not be null or white space
            // Postcondition: The city has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(City)} cannot be empty.");
                }

                _city = value;
            }
        }

        public string State
        {
            // Precondition:  None
            // Postcondition: The state has been returned
            get => _state;

            // Precondition:  must not be null or white space
            //                Must be 2 letters in length
            // Postcondition: The State has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(State)} cannot be empty.");
                }
                if (value.Length != STATE_ABBREVIATION_LENGTH)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(State)} must be a 2 letter abreviation.");
                }

                _state = value;
            }
        }

        public int Zip
        {
            // Precondition:  None
            // Postcondition: The zip has been returned
            get => _zip;

            // Precondition:  0 <= value <= 99999
            // Postcondition: The zip code has been set to the specified value
            set
            {
                if (value < MIN_ZIP || value > MAX_ZIP)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Zip)} must be in the value 0 - 99999.");
                }

                _zip = value;
            }
        }


        // Precondition:  None
        // Postcondition: A String with the Address's data has been returned
        public override string ToString()
        {
            if(Address2 == "")
                return $"\n{Name}" +
                       $"\n{Address1}" +
                       $"\n{City}, {State} {Zip:D5}";
            else
                return $"\n{Name}" +
                   $"\n{Address1}" +
                   $"\n{Address2}" +
                   $"\n{City}, {State} {Zip:D5}";
        }
    }
}
