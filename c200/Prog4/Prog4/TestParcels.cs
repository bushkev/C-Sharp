// Program 4
// CIS 200-01
// Fall 2018
// Due: 11/26/2018
// By: D9689

// This is a simple, console application designed to exercise the Parcel hierarchy.
// It creates several different Parcels, then sorts, and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            Letter letter2 = new Letter(a4, a3, 1.50M);                            // Letter test object
            Letter letter3 = new Letter(a2, a3, 8.25M);                            // Letter test object
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            GroundPackage gp2 = new GroundPackage(a1, a4, 20, 20, 12, 50);         // Ground test object
            GroundPackage gp3 = new GroundPackage(a3, a2, 8, 32, 18, 32);          // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a2, a1, 5, 35, 26,    // Next Day test object
                62, 12.25M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a3, a4, 34.8, 27.9, 14.8, // Two Day test object
                37.25, TwoDayAirPackage.Delivery.Early);

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(gp1);
            parcels.Add(ndap1);
            parcels.Add(tdap1);
            parcels.Add(letter2);
            parcels.Add(gp2);
            parcels.Add(ndap2);
            parcels.Add(tdap2);
            parcels.Add(letter3);
            parcels.Add(gp3);

            Console.WriteLine("Original List:\n");
            Console.WriteLine("====================");

            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }

            Pause();

            //sorts ascending by cost
            parcels.Sort();
            Console.WriteLine("List sorted by cost:\n");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }

            Pause();

            //sorts decending by zip code
            parcels.Sort(new DecreasingZipCode());
            Console.WriteLine("List Sorted Decending by destination zip code:\n");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }

            Pause();

            //sorts by type and descending by cost
            parcels.Sort(new ParcelSort());
            Console.WriteLine("List Sorted by Parcel type, then descending by cost:\n");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
        }
        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
