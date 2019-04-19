// Program 5
// CIS 200-01
// Fall 2018
// Due: 12/04/2018
// By: D9689

// This is a simple, console application designed to test the functionality of the program.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BinaryTreeLibrary
{
    class TreeTest
    {
        static void Main(string[] args)
        {
            Tree<int> intSet = new Tree<int>();     //Generic Tree variables for the int binary tree
            Tree<double> doubleSet = new Tree<double>();     //Generic Tree variables for the double binary tree
            Tree<string> stringSet = new Tree<string>();     //Generic Tree variables for the string binary tree

            int[] insertInt = { 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, };     // array that holds the test info for int tree
            double[] insertDouble = { .6, .7, .8, .9, .95, .1, .2, .3, .4, .5 };     // array that holds the test info for double tree
            string[] insertString = { "F", "G", "H", "I", "J", "A", "B", "C", "D", "E" };     // array that holds the test info for string tree

            //loop that assigns variables from int array to tree nodes
            foreach (var i in insertInt)
            {
                intSet.InsertNode(i);
            }

            //loop that assigns variables from double array to tree nodes
            foreach (var d in insertDouble)
            {
                doubleSet.InsertNode(d);
            }

            //loop that assigns variables from string array to tree nodes
            foreach (var s in insertString)
            {
                stringSet.InsertNode(s);
            }

            //Output display for traversal information
            WriteLine("Int Traveral");
            WriteLine("---------------------------------------------");
            intSet.InorderTraversal();
            ReadLine();

            WriteLine("Double Traveral");
            WriteLine("---------------------------------------------");
            doubleSet.InorderTraversal();
            ReadLine();

            WriteLine("String Traveral");
            WriteLine("---------------------------------------------");
            stringSet.InorderTraversal();
            
        }
    }
}