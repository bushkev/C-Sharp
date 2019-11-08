using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;

/* Catching Car Mileage Numbers
 * https://www.codewars.com/kata/52c4dd683bfd3b434c000292
 */


public class Kata
{
    static void Main(string[] args)
    {
        //WriteLine(IsInteresting(3, new List<int>() { 1337, 256 }));    // 0
        //WriteLine(IsInteresting(3236, new List<int>() { 1337, 256 })); // 0

        //WriteLine(IsInteresting(11207, new List<int>() { }));   // 0
        //WriteLine(IsInteresting(11208, new List<int>() { }));   // 0
        //WriteLine(IsInteresting(11209, new List<int>() { }));   // 1
        //WriteLine(IsInteresting(11210, new List<int>() { }));   // 1
        //WriteLine(IsInteresting(11211, new List<int>() { }));   // 2

        //WriteLine(IsInteresting(1335, new List<int>() { 1337, 256 }));   // 1
        //WriteLine(IsInteresting(1336, new List<int>() { 1337, 256 }));   // 1
        //WriteLine(IsInteresting(1337, new List<int>() { 1337, 256 }));   // 2

        //WriteLine(IsInteresting(997, new List<int>() { }));   // 0
        //WriteLine(IsInteresting(998, new List<int>() { }));   // 1
        //WriteLine(IsInteresting(999, new List<int>() { }));   // 1
        //WriteLine(IsInteresting(1000, new List<int>() { }));   // 2 

        //WriteLine(IsInteresting(123453, new List<int>() { }));   // 0
        //WriteLine(IsInteresting(123454, new List<int>() { }));   // 1
        //WriteLine(IsInteresting(123455, new List<int>() { }));   // 1
        //WriteLine(IsInteresting(123456, new List<int>() { }));   // 2 
        //WriteLine(IsInteresting(123457, new List<int>() { }));   // 0 
        //WriteLine(IsInteresting(7888, new List<int>() { }));   // 1 
        //WriteLine(IsInteresting(7889, new List<int>() { }));   // 1 
        //WriteLine(IsInteresting(7890, new List<int>() { }));   // 2 
        //WriteLine(IsInteresting(79801, new List<int>() { }));   // 0 
        //WriteLine(IsInteresting(5689, new List<int>() { }));   // 0 

        //WriteLine(IsInteresting(876540, new List<int>() { }));   // 0
        //WriteLine(IsInteresting(876541, new List<int>() { }));   // 1
        //WriteLine(IsInteresting(876542, new List<int>() { }));   // 1
        //WriteLine(IsInteresting(876543, new List<int>() { }));   // 2 
        //WriteLine(IsInteresting(876544, new List<int>() { }));   // 0 
        //WriteLine(IsInteresting(43207, new List<int>() { }));   // 0
        //WriteLine(IsInteresting(43208, new List<int>() { }));   // 1
        //WriteLine(IsInteresting(43209, new List<int>() { }));   // 1 
        //WriteLine(IsInteresting(43210, new List<int>() { }));   // 2 
        //WriteLine(IsInteresting(43211, new List<int>() { }));   // 0

        //Enter methods from Kata below
    }

    public static int IsInteresting(int miles, List<int> phrase)
    {
        int answer = 0;

        if (miles >= 100)
        {
            // Check to see if matches or near awesome phrase
            foreach (var awesome in phrase)
            {
                if (miles == awesome) return 2;
                if ((miles + 1) == awesome || (miles + 2) == awesome) answer = 1;
            }

            string numAsString = miles.ToString();
            string oneMore = (miles + 1).ToString();
            string twoMore = (miles + 2).ToString();
            int length = numAsString.Length;

            // Check to see if digit followed by zeros
            if (numAsString.Substring(1).All(x => x == '0')) return 2;
            if (oneMore.Substring(1).All(x => x == '0') || twoMore.Substring(1).All(x => x == '0')) answer = 1;

            // Check to see if every digit is the same
            if (numAsString.All(x => x == numAsString[0])) return 2;
            if (oneMore.All(x => x == numAsString[0]) || twoMore.All(x => x == numAsString[0])) answer = 1;

            // Check to see if sequential, increasing
            for (int i = 1; i < numAsString.Length; i++)
            {
                if (i == length - 1)
                {
                    if (numAsString[i] == '0' && numAsString[i - 1] == '9') return 2;

                    if (numAsString[i] == numAsString[i - 1] + 1) return 2;
                    if (oneMore[i] == oneMore[i - 1] + 1 || twoMore[i] == twoMore[i - 1] + 1) answer = 1;
                }

                if (numAsString[i] != numAsString[i - 1] + 1)
                {
                    if (i == length - 2)
                    {
                        if (oneMore[i] == oneMore[i - 1] + 1 || twoMore[i] == twoMore[i - 1] + 1)
                        {
                            //if (oneMore[i + 1] == oneMore[i] + 1 || twoMore[i + 1] == twoMore[i] + 1)
                            //{
                            //    answer = 1;
                            //    break;
                            //}
                            if ((oneMore[i] == '9' && oneMore[i + 1] == '0') || (twoMore[i] == '9' && twoMore[i + 1] == '0'))
                            {
                                answer = 1;
                                break;
                            }
                        }
                    }

                    break;
                }
            }

            // Check to see if sequential, decreasing
            for (int i = 1; i < length; i++)
            {

                if (i == length - 1)
                {
                    if (numAsString[i] == numAsString[i - 1] - 1) return 2;
                    if (oneMore[i] == numAsString[i - 1] - 1 || twoMore[i] == numAsString[i - 1] - 1) answer = 1;
                }

                if (numAsString[i] != numAsString[i - 1] - 1)
                {
                    if (i == length - 2)
                    {
                        if (oneMore[i] == oneMore[i - 1] - 1 || twoMore[i] == twoMore[i - 1] - 1)
                        {
                            if (oneMore[i + 1] == oneMore[i] - 1 || twoMore[i + 1] == twoMore[i] - 1)
                            {
                                answer = 1;
                                break;
                            }
                        }
                    }

                    break;
                }
            }

            // Check to see if paladrome
            bool one = false;
            for (int i = 0; i < length / 2; i++)
            {
                if (i == (length / 2) - 1)
                {
                    if (numAsString.ElementAt(i) == numAsString.ElementAt(length - 1 - i) && !one) return 2;
                    else if (numAsString.ElementAt(i) == numAsString.ElementAt(length - 1 - i)) answer = 1;
                    else if (i == 1 && one)
                    {
                        if (numAsString.ElementAt(i) == oneMore.ElementAt(length - 1 - i)) answer = 1;

                        if (numAsString.ElementAt(i) == twoMore.ElementAt(length - 1 - i)) answer = 1;
                    }
                }
                if (numAsString.ElementAt(i) != numAsString.ElementAt(length - 1 - i))
                {
                    if (numAsString.ElementAt(i) == oneMore.ElementAt(length - 1 - i))
                    {
                        one = true;
                        if (length == 3) return 1;
                        continue;
                    }

                    if (numAsString.ElementAt(i) == twoMore.ElementAt(length - 1 - i))
                    {
                        if (length == 3) return 1;
                        one = true;
                        continue;
                    }

                    break;
                }

            }
        }

        if (miles == 99 || miles == 98) return 1;

        return answer;
    }

    //End of Kata method
}