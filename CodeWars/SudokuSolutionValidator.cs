using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;

/* Sudoku Solution Validator
 * https://www.codewars.com/kata/529bf0e9bdf7657179000008
 */


public class Kata
{
    static void Main(string[] args)
    {
        var test = new int[][]
        {
            new int[] { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
            new int[] { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
            new int[] { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
            new int[] { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
            new int[] { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
            new int[] { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
            new int[] { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
            new int[] { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
            new int[] { 3, 4, 5, 2, 8, 6, 1, 7, 9 }
        }; // true

        var test2 = new int[][]
        {
            new int[] { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
            new int[] { 6, 7, 2, 1, 9, 0, 3, 4, 8 },
            new int[] { 1, 0, 0, 3, 4, 2, 5, 6, 0 },
            new int[] { 8, 5, 9, 7, 6, 1, 0, 2, 0 },
            new int[] { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
            new int[] { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
            new int[] { 9, 0, 1, 5, 3, 7, 2, 1, 4 },
            new int[] { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
            new int[] { 3, 0, 0, 4, 8, 1, 1, 7, 9 }
        }; // false 

        WriteLine(ValidateSolution(test));

        //Enter methods from Kata below
    }
    public static bool ValidateSolution(int[][] board)
    {
        // Check for any zero, and return false if any are found.
        if (board.SelectMany(x => x).Contains(0))
        {
            return false;
        }

        // Check for horizontal duplicates, and return false if any are found.
        foreach (var temp in board.Select(x => x).Distinct())
        {
            if (temp.Count() != 9)
            {
                return false;
            }
        }

        // Check for vertical duplicates, and return false if any are found.
        for (int i = 0; i < board.Length; i++)
        {
            if (board.Select(x => x.ElementAt(i)).Distinct().Count() != 9)
            {
                return false;
            }
        }

        // Check for 3x3 duplicates, and return false if any are found.
        for (int i = 0; i < board.Length; i += 3)
        {
            var tempList1 = new List<int>();
            var tempList2 = new List<int>();
            var tempList3 = new List<int>();

            for (int j = 0; j < board.Length / 3; j++)
            {
                for (int k = 0; k < board.Length; k++)
                {
                    if (k < 3) tempList1.Add(board[j + i][k]);
                    else if (k < 6) tempList2.Add(board[j + i][k]);
                    else tempList3.Add(board[j + i][k]);
                }
            }

            if (tempList1.Distinct().Count() != 9)
            {
                return false;
            }

            if (tempList2.Distinct().Count() != 9)
            {
                return false;
            }

            if (tempList3.Distinct().Count() != 9)
            {
                return false;
            }
        }

        return true;
    }

    //End of Kata method
}