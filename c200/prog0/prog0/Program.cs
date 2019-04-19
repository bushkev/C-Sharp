// Program 0
// CIS 200-01
// Due: 9/10/2018
// By: D9689

// This file creates a simple test application class that tests the functionality of the address, letter, and parcel classes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace prog0
{
    public class Program
    {
        // Precondition:  None
        // Postcondition: The Address, Letter, and Parcel classes have been tested
        public static void Main(string[] args)
        {
            //create address objects here
            Address add1 = new Address("Jenny Hartford", "1002 rolling log ln", "apt. 3B", "Prospect", "KY", 40210);
            Address add2 = new Address("Tom Jones", "12345 coolguy rd", "Waco", "TX", 123);
            Address add3 = new Address("Dave murphey", "548 Twin Tree rd", "Apt 320", "Louisville", "KY", 42310);
            Address add4 = new Address("Jamie Kent", "25264 Winding way ln", "Goshen", "KY", 40025);

            //create letters here
            Letter letter1 = new Letter(add1, add2, 5.25M);
            Letter letter2 = new Letter(add2, add4, 4.50M);
            Letter letter3 = new Letter(add3, add1, 1.50M);

            //create list of parcels
            List<Parcel> parList = new List<Parcel> {letter1, letter2, letter3};

            //tests to see if the letter and address classes worked as expected
            WriteLine("Test 1:");
            WriteLine(letter1);
            WriteLine("\nTest 2:");
            WriteLine(letter2);
            WriteLine("\nTest 3:");
            WriteLine(letter3);

            WriteLine("\n---------------------------\n");

            //foreach loop to test parcel list
            foreach(Parcel parcel in parList)
            {
                WriteLine(parcel);
            }
        }
    }
}
