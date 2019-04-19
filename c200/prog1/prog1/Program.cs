// Program 1
// CIS 200-01
// Fall 2018
// Due: 9/24/2017
// By: D9689

// Simple test program for initial Parcel classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1
{
    class Program
    {
        // Precondition:  None
        // Postcondition: Small list of Parcels is created and displayed
        static void Main(string[] args)
        {
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            Letter l1 = new Letter(a1, a3, 0.50M); // Test Letter 1
            Letter l2 = new Letter(a2, a4, 1.20M); // Test Letter 2
            Letter l3 = new Letter(a4, a1, 1.70M); // Test Letter 3

            List<Parcel> parcels = new List<Parcel>(); // Test list of parcels

            // Add test data to list
            parcels.Add(l1);
            parcels.Add(l2);
            parcels.Add(l3);

            // Display data
            Console.WriteLine("Program 0 - List of Parcels\n");

            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("--------------------");
            }

            //test for GroundPackage class
            GroundPackage test1 = new GroundPackage(a1, a2, 12, 10, 1,10);
            Console.WriteLine(test1);
            Console.WriteLine("--------------------");

            //tests for AirPackage and NextDayAirPackage
            NextDayAirPackage test2 = new NextDayAirPackage(a1, a2, 12, 10, 1,10 , 10);
            Console.WriteLine(test2);
            Console.WriteLine("--------------------");

            NextDayAirPackage testheavy = new NextDayAirPackage(a1, a2, 12, 10, 1, 80, 10);
            Console.WriteLine(testheavy);
            Console.WriteLine("--------------------");

            NextDayAirPackage testlarge = new NextDayAirPackage(a1, a2, 30, 40, 50, 10, 10);
            Console.WriteLine(testlarge);
            Console.WriteLine("--------------------");

            NextDayAirPackage testboth = new NextDayAirPackage(a1, a2, 30, 40, 50, 80, 10);
            Console.WriteLine(testboth);
            Console.WriteLine("--------------------");

            //tests for AirPackage and TwoDayAirPackage
            TwoDayAirPackage test3 = new TwoDayAirPackage(a1, a2, 30, 40, 50, 80, TwoDayAirPackage.Delivery.Early);
            Console.WriteLine(test3);
            Console.WriteLine("--------------------");

            TwoDayAirPackage test4 = new TwoDayAirPackage(a1, a2, 30, 40, 50, 80, TwoDayAirPackage.Delivery.Saver);
            Console.WriteLine(test4);
            Console.WriteLine("--------------------");
        }
    }
}
