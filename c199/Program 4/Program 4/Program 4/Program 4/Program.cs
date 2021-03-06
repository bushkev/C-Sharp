﻿/* W8172
 * CIS-199-01
 * 24 April 2018
 * Program 4
 * Create a Console application with two classes. One class will be the test application where the Main method is located. The other public class will be named GroundPackage and will be our initial attempt at representing some of the packages delivered by Brown Parcel Service. At the moment, our ground package class will be very simple. Each GroundPackage object will keep track of some basic information: the package's origin zip code (an int), destination zip code (an int), length in inches (positive double), width in inches (positive double), height in inches (positive double), and the weight in pounds (positive double). Later, we may add more capabilities (in CIS 200) but this is a good start.

    The specific public requirements for the GroundPackage class are listed below. You may not change or add to the public interface described here.

    A 6 parameter constructor that accepts the origin zip code (a 5 digit int), destination zip code (a 5 digit int), length in inches (positive double), width in inches (positive double), height in inches (positive double), and the weight in pounds (positive double). Use the set properties for all relevant fields to establish their initial values (instead of directly changing instance variables.
    An int property named OriginZip with a get and a set. To practice validation, you must ensure that the specified zip code is between 00000 and 99999 when attempting to set; otherwise,set the zip code to 40202.
    An int property named DestinationZip with a get and a set. To practice validation, you must ensure that the specified zip code is between 00000 and 99999 when attempting to set; otherwise, set the zip code to 90210.
    double get and set properties for each of the other data fields (named Length, Width, Height, and Weight). To practice validation, you must ensure that the specified dimension is greater than zero when attempting to set; otherwise, set the property's value to 1.0.
    An int property named ZoneDistance with a get (but no set). The zone distance is the positive difference between the first digit of the origin zip code and the first digit of the destination zip code. For example, the zone distance between zip codes 50000 and 10000 is 4 (5-1). [HINT: The easiest way to get first digit from a zip code is to divide it by 10,000. 40202/10000 == 4 in C#.]
    A method named CalcCost that returns a double and accepts no parameters. Calculate the shipping cost as
    Cost (in dollars) = .20*(Length + Width + Height) + .5*(ZoneDist + 1)*(Weight)
    A method named ToString that returns a String and accepts no parameters. Remember, you must also use keyword override when defining a ToString method. This method will create a formatted string that has the package's data, each on a separate line. Precede each item with an identifying label. You may use string interpolation to create the formatted text that the method will return. Instead of concatenating the string literal "\n" to add a newline to the string, use the string constant Environment.NewLine instead. Note well, the ToString method just builds and returns a string. It does no output of its own. That is up to client classes to perform, as the output may be directed to the console or a GUI or a web page. See the PayrollSystem example from class for an example of how ToString() should be written.

    In addition to the GroundPackage class, you will need to write a simple Console application to test your packages. In your other class file (where the Main method is located), your simple test program must do the following:

    Create at least 5 GroundPackage objects (you may hard code your test data) and store them in an array.
    Using a method, print out each object's original data to the Console. Name the method DisplayPackages. It should be void and accepts one parameter, an array of GroundPackage objects. You can make the method public and static here in the test application. The method should use a for or foreach loop to call each package's ToString method, directing each string to the console. The method should also display each package's cost by calling the CalcCost() method.
    Next, for each package, use the appropriate properties to change some data for each package (like Length, Width, Height, Weight). These changes can be hard coded (not in a loop).
    Again, using the method, print out each object's new data to the console.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program_4
{
    class Program
    {
        static void Main(string[] args)
        {

            GroundPackage box1 = new GroundPackage(40021, 90254, 12.6, 15.2, 5.6, 1200);    //New GroundPackage object created
            GroundPackage box2 = new GroundPackage(-10025,122235 ,-12 ,-23 ,-52 , -120);    //New GroundPackage object created
            GroundPackage box3 = new GroundPackage(10251, 50265, 2, 3, 4, 500);             //New GroundPackage object created
            GroundPackage box4 = new GroundPackage(6201, 1, 10, 10, 10, 100);               //New GroundPackage object created
            GroundPackage box5 = new GroundPackage(1, 9000, 200, 100, 200, 2000);           //New GroundPackage object created
            GroundPackage[] storage = { box1, box2, box3, box4, box5 };                     //GroundPackage Array created to hold the objects
            DisplayPackages(storage);                                                       //method called passing the GroundPackage array

            WriteLine("-------------Changes--------------" + Environment.NewLine);          

            box1.OriginZip = 50021;                                                         //property setter used to change the OriginZip
            box2.DestinationZip = 1;                                                        //property setter used to change the DestinationZip
            box3.Length = 10;                                                               //property setter used to change the Length
            box4.Width = 20;                                                                //property setter used to change the Width
            box5.Weight = 200;                                                              //property setter used to change the Weight
            DisplayPackages(storage);                                                       //method called passing the GroundPackage array

        }

        // Precondition: Must be passed an array of objects of the class GroundPackages.
        // Postcondition: Displays the information to the console
        public static void DisplayPackages(GroundPackage[] packages)
        {
            int packageNum = 1;                                                             //variable to hold the value for the package number, always starting with 1.
            foreach ( GroundPackage package in packages)                                    //foreach loop to go through each array
            {
                WriteLine($"           Package {packageNum++}");
                WriteLine(package);
                WriteLine($"Package cost: {package.CalcCost(),20:C}");
                WriteLine();
            }
        }
    }
}
