// Program 1B
// CIS 200-01
// Fall 2018
// Due: 10/03/2018
// By: D9689

// File: TestParcels.cs
// This program explores the use of LINQ to produce simple reports.
// It creates several different Parcels and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

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
            Address a5 = new Address("Tim Jones", "865 Good Music Drive", 
                "Nashville", "TN", 37027); // Test Address 5
            Address a6 = new Address("Jonny Banana", "942 Private Beach Drive",
                "Clearwater", "FL", 33755); // Test Address 6
            Address a7 = new Address("Juan Martinez", "15946 Big Hat Lane", "Apt. 5B",
                "Austin", "TX", 73344); // Test Address 7
            Address a8 = new Address("Frank Chowder", "321 Too Cold Way",
                "Manchester", "NH", 03107); // Test Address 8

            Letter letter1 = new Letter(a1, a2, 3.95M);                             // Letter test object
            Letter letter2 = new Letter(a4, a8, 4.55M);                             // Letter test object
            Letter letter3 = new Letter(a7, a3, 7.25M);                             // Letter test object
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);         // Ground test object
            GroundPackage gp2 = new GroundPackage(a5, a7, 25, 8, 15, 25.8);         // Ground test object
            GroundPackage gp3 = new GroundPackage(a3, a4, 5, 22, 17, 34.2);         // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,     // Next Day test object
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a7, a6, 18, 6, 5,       // Next Day test object
                45, 11.25M);
            NextDayAirPackage ndap3 = new NextDayAirPackage(a3, a8, 21, 22, 23,     // Next Day test object
                63, 9M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a2, a5, 50, 10, 5,        // Two Day test object
                60.4, TwoDayAirPackage.Delivery.Early);
            TwoDayAirPackage tdap3 = new TwoDayAirPackage(a6, a8, 18, 27, 36,       // Two Day test object
                21.25, TwoDayAirPackage.Delivery.Saver);

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(letter2);
            parcels.Add(letter3);
            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(gp3);
            parcels.Add(ndap1);
            parcels.Add(ndap2);
            parcels.Add(ndap3);
            parcels.Add(tdap1);
            parcels.Add(tdap2);
            parcels.Add(tdap3);

            //Variable to hold the first LINQ report
            var parcelsByDestination = from parcel in parcels
                                       orderby parcel.DestinationAddress.Zip descending
                                       select parcel;

            //Variable to hold the second LINQ report
            var parcelsByCost = from parcel in parcels
                                orderby parcel.CalcCost()
                                select parcel;

            //Variable to hold the third LINQ report
            var parcelsByParcelCost = from parcel in parcels
                                orderby parcel.GetType().ToString(),  parcel.CalcCost() descending
                                select parcel;

            //Variable to hold the fourth LINQ report
            var airPackageHeavyByWeight = from parcel in parcels
                                      where (parcel is AirPackage) && ((AirPackage)parcel).IsHeavy()
                                      orderby ((AirPackage)parcel).Weight descending
                                      select parcel;

            //output for first report
            WriteLine("Output for all Parcels ordered by descending destination zip.");
            foreach (var output in parcelsByDestination)
            {
                WriteLine("============================");
                WriteLine(output);
            }

            Pause();

            //output for second report
            WriteLine("Output for all Parcels ordered by cost.");
            foreach (var output in parcelsByCost)
            {
                WriteLine("============================");
                WriteLine(output);
            }

            Pause();

            //output for third report
            WriteLine("Output for all Parcels ordered by parcel type ,then descending cost.");
            foreach (var output in parcelsByParcelCost)
            {
                WriteLine("============================");
                WriteLine(output);
            }

            Pause();

            //output for fourth report
            WriteLine("Output for all AirPackages that are heavy, ordered by descending weight.");
            foreach (var output in airPackageHeavyByWeight)
            {
                WriteLine("============================");
                WriteLine(output);
            }
        }

        // Precondition:  None
        // Postcondition: Pauses program until user presses enter, then clears the screen
        public static void Pause()
        {
            WriteLine("\nPress Enter to Continue.");
            ReadLine();
            Clear();
        }

    }
}
