using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;

/*Sum of Intervals
 * https://www.codewars.com/kata/52b7ed099cdc285c300001cd
 */

public class Kata
{
    static void Main(string[] args)
    {
        //var test = SumIntervals(new[] {
        //            (1, 4),
        //            (7, 10),
        //            (3, 5)
        //            }); // answer 7

        //var test2 = SumIntervals(new[] {
        //            (1, 2),
        //            (6, 10),
        //            (11, 15)
        //            }); // answer 9

        //var test3 = SumIntervals(new[] {
        //            (1, 5),
        //            (10, 20),
        //            (1, 6),
        //            (16, 19),
        //            (5, 11)
        //            }); // answer 19

        //var test4 = SumIntervals(new[]
        //            {
        //             (4841, 6848),
        //             (-5086, 658),
        //             (-45, 5277),
        //             (-3548, 1537),
        //             (-3399, 1692),
        //             (-8688, -4776),
        //             (-1747, -1384),
        //             (-5759, 5911),
        //             (-119, 409),
        //             (-3204, 3457),
        //             (-2898, -1098),
        //             (7383, 8421),
        //             (1162, 4141),
        //             (-7848, -3383),
        //             (8726, 9680),
        //             (-6225, 3050),
        //             (-8022, 8877),
        //             (-7674, -4101),
        //             (-3783, 1815)
        //            });//answer 18368

        //var test5 = SumIntervals(new[]
        //            {
        //                (2658, 9408),
        //                (-6311, 9934),
        //                (-2644, 163),
        //                (6070, 6930),
        //                (2703, 8925),
        //                (-1934, 12),
        //                (-9364, -7560),
        //                (-2213, 4601),
        //                (-1169, 2443),
        //                (-3337, -2784),
        //                (-5114, 7307),
        //                (-8965, -7652),
        //                (-6294, -5907),
        //                (-3056, 3790),
        //                (-5066, 290),
        //                (-4648, -3074),
        //                (-5876, 8683),
        //                (5126, 9436)
        //            }); //answer 18049

        //var test6 = SumIntervals(new[]
        //            {
        //                (2139, 5078),
        //                (-9237, -6170),
        //                (-3458, 9756),
        //                (-2340, 2252),
        //                (2186, 5292),
        //                (-6218, -4591),
        //                (-9777, -5651),
        //                (-1740, 603),
        //                (-1825, 1698),
        //                (2126, 7562)
        //            }); // answer18400

        var test7 = SumIntervals(new[]
                    {
                        (7382, 7848),
                        (3191, 3845),
                        (4147, 4747),
                        (-730, 1708),
                        (-8919, 2016),
                        (-3919, -27),
                        (-9850, 5396),
                        (-7004, 1420),
                        (-248, 6665),
                        (-3551, -1907)
                    }); // answer 16981

        //WriteLine(test);
        //WriteLine(test2);
        //WriteLine(test3);
        //WriteLine(test4);
        //WriteLine("Should be 18368");
        //WriteLine(test5);
        //WriteLine("Should be 18049");
        //WriteLine(test6);
        //WriteLine("Should be 18400");
        WriteLine(test7);
        WriteLine("Should be 16981");

        ReadLine();

        //Enter methods from Kata below
    }

    // Answer from someone else
    //public static int SumIntervals2((int, int)[] intervals)
    //{
    //    return intervals.SelectMany(i => Enumerable.Range(i.Item1, i.Item2 - i.Item1))
    //    .Distinct()
    //    .Count();
    //}

    public static int SumIntervals((int x, int y)[] intervals)
    {
        var inListForm = ConvertToList(intervals);

        int answer = 0;

        var sorted = ArrayCombine(inListForm);

        //Get sum of the differences of all the arrays.
        foreach (var elem in sorted)
        {
            answer += elem[1] - elem[0];
        }

        return answer;
    }

    public static List<int[]> ArrayCombine(List<int[]> arr)
    {
        bool redo = false;                  // Bool to kick off recursion.
        var tempList = new List<int[]>();   // List to hold Array values.

        for (int i = 0; i < arr.Count; i++)
        {
            bool noChanges = true; // keeps track of it any elements where changed.

            // iterate through the tempList to compare if new elements fall in the existing element ranges.
            for (int j = 0; j < tempList.Count && (i != j); j++)
            {
                // Check if the new element 1 is between an existing element 1 and 2.
                if (arr[i][0] >= tempList[j][0] && arr[i][0] <= tempList[j][1])
                {
                    // Check if he new element 2 is greater than the existing element 2.
                    // If so, swap the existing element 2 with the new element 2.
                    if (arr[i][1] > tempList[j][1])
                    {
                        tempList[j][1] = arr[i][1];
                        noChanges = false;
                        redo = true;
                        continue;
                    }
                }

                // Check if the new element 2 is between an existing element 1 and 2.
                if (arr[i][1] >= tempList[j][0] && arr[i][1] <= tempList[j][1])
                {
                    // Check if the new element 1 is less than the existing element 1.
                    // If so, swap the existing element 1 with the new element 1.
                    if (arr[i][0] < tempList[j][0])
                    {
                        tempList[j][0] = arr[i][0];
                        noChanges = false;
                        redo = true;
                    }
                    // elements lie within elements range.
                    noChanges = false;
                }

                // Check if any existing items fall in between new items
                if (tempList[j][0] > arr[i][0] && tempList[j][1] < arr[i][1])
                {
                    tempList.Insert(j, arr[i]);
                    noChanges = false;
                    redo = true;
                }
            }

            // If the new elements 1 and 2 are both outside any existing element 1 and 2 ranges then add them to the list.
            if (noChanges)
            {
                tempList.Add(arr[i]);
            }
        }

        // If Changes where made to the list and there is more than 1 element use recursion to make sure all elements get checked for possible combinations.
        if (redo && tempList.Count > 1)
        {
            tempList = ArrayCombine(tempList);
        }

        return tempList;
    }
    public static List<int[]> ConvertToList((int x, int y)[] tempTup)
    {
        var tempList = new List<int[]>();

        foreach (var line in tempTup)
        {
            tempList.Add(new int[] { line.x, line.y });
        }
        return tempList;
    }

    //End of Kata method
}