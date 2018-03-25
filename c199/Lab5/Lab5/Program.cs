/* W8172
 * Lab 5
 * 4 March 2018
 * Cis-199-01
 * A Windows Console application that displays 4 different triangle patterns of stars(*) separately, one after the other.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_LINE = 10;                                //constant variable that hold the max number of lines.

            WriteLine("Pattern A\n");                               //label for first triangle.
            for (int row = 1; row <= MAX_LINE; ++row)               //outer for loop that controls number of rows.
            {
                for (int star = 1; star <= row ; ++star)            //for loop that controls number of stars.
                    Write("*");
                WriteLine();
            }

            WriteLine("\nPattern B\n");                             //label for second triangle
            for (int row = MAX_LINE; row >= 1; --row)               //outer for loop that controls number of rows.
            {
                for (int star = 1; star <= row; ++star)             //inner for loop that controls number of stars.
                    Write("*");
                WriteLine();
            }

            WriteLine("\nPattern C\n");                             //label for third triangle
            for (int row = MAX_LINE; row >= 1; --row)               //outer for loop that controls number of rows.
            {
                for (int space = MAX_LINE ; space > row; --space)   //inner for loop that controls number of spaces.
                    Write(" ");
                for (int star = 1; star <= row; ++star)             //inner for loop that controls number of stars.
                    Write("*");
                
                WriteLine();
            }

            WriteLine("\nPattern D\n");                             //label for forth triangle
            for (int row = 1; row <= MAX_LINE; ++row)               //outer for loop that controls number of rows.
            {
                for (int space = MAX_LINE; space > row; --space)    //inner for loop that controls number of spaces.
                    Write(" ");
                for (int star = 1; star <= row; ++star)             //inner for loop that controls number of stars.
                    Write("*");

                WriteLine();
            }
        }
    }
}
