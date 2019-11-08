using System;
using System.Collections.Generic;
using static System.Console;

/* Directions Reduction
 * https://www.codewars.com/kata/550f22f4d758534c1100025a
 */

public class Kata
{
    static void Main(string[] args)
    {
        //Enter test code here

        var test = dirReduc(new string[] { "NORTH", "EAST", "WEST", "SOUTH", "WEST", "WEST" });

        foreach (var temp in test)
        {
            WriteLine(temp);
        }
        ReadLine();

        //Enter methods from Kata below
    }

    public static string[] dirReduc(String[] arr)
    {
        var answer = new List<string>(arr);
        bool stopper = true;
        int index = 0;

        while (stopper)
        {
            int length = answer.Count;

            if (index >= length - 1)
                stopper = false;

            else if (answer[index] == "NORTH" && answer[index + 1] == "SOUTH")
            {
                answer.RemoveAt(index + 1);
                answer.RemoveAt(index);
                if (index != 0) index--;
            }

            else if (answer[index] == "SOUTH" && answer[index + 1] == "NORTH")
            {
                answer.RemoveAt(index + 1);
                answer.RemoveAt(index);
                if (index != 0) index--;
            }

            else if (answer[index] == "EAST" && answer[index + 1] == "WEST")
            {
                answer.RemoveAt(index + 1);
                answer.RemoveAt(index);
                if (index != 0) index--;
            }

            else if (answer[index] == "WEST" && answer[index + 1] == "EAST")
            {
                answer.RemoveAt(index + 1);
                answer.RemoveAt(index);
                if (index != 0) index--;
            }
            else
            {
                index++;
            }
        }

        return answer.ToArray();
    }

    //End of Kata method

}