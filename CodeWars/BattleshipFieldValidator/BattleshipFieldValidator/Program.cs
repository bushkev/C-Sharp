using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;

/* Battleship field validator
 * https://www.codewars.com/kata/52bb6539a4cf1b12d90005b7
 */


public class Kata
{
    static void Main(string[] args)
    {
        int[,] field = new int[10, 10]
                     {{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                      {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                      {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
                      {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                      {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                      {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        };// true

        int[,] field2 = new int[10, 10]
                     {  {1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                        {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                        {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
                        {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                        {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                        {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                        {0, 0, 0, 1, 0, 0, 0, 0, 1, 0},
                        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                        {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };// should be false due to touching corner



        WriteLine(ValidateBattlefield(field));

        //Enter methods from Kata below
    }

    public static bool ValidateBattlefield(int[,] field)
    {
        var indexPositions = new List<int[]>();
        int count = 0;
        int battle = 0;
        int cruiser = 0;
        int destroyers = 0;
        int subs = 0;
        bool touch = false;
        bool first;

        //Find 1s and store location in a list.
        for (int i = 0; i < field.GetLength(0); i++)
        {
            for (int j = 0; j < field.GetLength(1); j++)
                if (field[i, j] == 1)
                {
                    count++;
                    indexPositions.Add(new int[] { i, j });
                }
        }

        // Check if there are 20 1s.
        if (count != 20) return false;

        while (indexPositions.Count > 0 && !touch)
        {
            first = true;
            ShipLocator(indexPositions[0]);
        }

        if (battle == 1 && cruiser == 2 && destroyers == 3 && subs == 4 && !touch)
        {
            return true;
        }

        return false;

        //cheks to see if 1 has any other connecting 1s. Determins the type of ship based on how many connecting 1s.
        void ShipLocator(int[] ship)
        {
            int y = ship[0];
            int x = ship[1];
            indexPositions.RemoveAt(0);

            if (CheckIfRight(y, ref x))
            {
                indexPositions.RemoveAt(0);
                if (CheckIfRight(y, ref x))
                {
                    indexPositions.RemoveAt(0);
                    if (CheckIfRight(y, ref x))
                    {
                        indexPositions.RemoveAt(0);
                        battle++;
                    }
                    else cruiser++;
                }
                else destroyers++;
            }
            else if (!touch && CheckIfDown(ref y, x)) // if not any 1s connecting right
            {
                indexPositions.RemoveAt(indexPositions.FindIndex(l => (l[0] == y && l[1] == x)));
                if (CheckIfDown(ref y, x))
                {
                    indexPositions.RemoveAt(indexPositions.FindIndex(l => (l[0] == y && l[1] == x)));
                    if (CheckIfDown(ref y, x))
                    {
                        indexPositions.RemoveAt(indexPositions.FindIndex(l => (l[0] == y && l[1] == x)));
                        battle++;
                    }
                    else cruiser++;
                }
                else destroyers++;
            }
            else // if no other connecting 1s right or down.
            {
                if (SubTouching(y, x))
                {
                    touch = true;
                }
                else // if no connecting 1s.
                {
                    subs++;
                }
                
            }

            //Check to see if another 1 connects to the right.
            bool CheckIfRight(int a, ref int b)
            {
                if (b < field.GetLength(1) - 1)
                {
                    if (first)
                    {
                        if (field[a, b + 1] == 1)
                        {
                            if (HorizontalShipTouching(a, b))
                            {
                                touch = true;
                            }
                            else // if no other 1s touching
                            {
                                first = false;
                                b++;
                                return true;
                            }

                        }
                    }
                    else // if not first run
                    {
                        if (field[a, b + 1] == 1)
                        {
                            if (HorizontalShipTouching(a, b))
                            {
                                touch = true;
                            }
                            else // if no other 1s touching
                            {
                                b++;
                                return true;
                            }

                        }
                        else // if no more parts to ship
                        {
                            if (HorizontalShipTouching(a, b))
                            {
                                touch = true;
                            }
                        }
                    }
                }

                return false;
            }

            //Check to see if another 1 connects underneath.
            bool CheckIfDown(ref int a, int b)
            {
                if (a < field.GetLength(0) - 1)
                {
                    if (first)
                    {
                        if (field[a + 1, b] == 1)
                        {
                            if (VerticalShipTouching(a, b))
                            {
                                touch = true;
                            }
                            else // if no other 1s touching
                            {
                                first = false;
                                a++;
                                return true;
                            }
                            
                        }
                    }
                    else // if not first run
                    {
                        if (field[a + 1, b] == 1)
                        {
                            if (VerticalShipTouching(a, b))
                            {
                                touch = true;
                            }
                            else // if no other 1s touching
                            {
                                a++;
                                return true;
                            }

                        }
                        else // if no more parts to ship
                        {
                            if (VerticalShipTouching(a, b))
                            {
                                touch = true;
                            }
                        }
                    }
                }
                
                return false;
            }

            //Check for any connecting 1s for right facing ship.
            bool HorizontalShipTouching(int a, int b)
            {
                if (a < field.GetLength(0) - 1)
                {
                    if (first)
                    {
                        if (b != 0)
                        {
                            if (field[a + 1, b - 1] == 1 || field[a + 1, b] == 1 || field[a + 1, b + 1] == 1)
                            {
                                return true;
                            }
                        }
                        else // if b == 0
                        {
                            if (field[a + 1, b] == 1 || field[a + 1, b + 1] == 1)
                            {
                                return true;
                            }
                        }
                    }
                    else // if not first run
                    {
                        if (field[a + 1, b + 1] == 1)
                        {
                            return true;
                        }
                    }
                }

                return false;
            }

            bool VerticalShipTouching(int a, int b)
            {
                if (b < field.GetLength(0) - 1)
                {
                    if (b != 0)
                    {
                        if (field[a + 1, b + 1] == 1 || field[a + 1, b - 1] == 1)
                        {
                            return true;
                        }
                    }
                    else // if b == 0
                    {
                        if (field[a, b + 1] == 1)
                        {
                            return true;
                        }
                    }
                }
                else // if at end of X-axis.
                {
                    if (b == 0)
                    {
                        if (field[a + 1, b + 1] == 1)
                        {
                            return true;
                        }
                    }
                }

                return false;
            }

            bool SubTouching(int a, int b)
            {
                if (a < field.GetLength(0) - 1)
                {
                    if (b == 0)
                    {
                        if (field[a + 1, b + 1] == 1)
                        {
                            return true;
                        }
                    }
                    else if (b == field.GetLength(1) - 1 )
                    {
                        if (field[a + 1, b - 1] == 1)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (field[a + 1, b + 1] == 1 || field[a + 1, b - 1] == 1)
                        {
                            return true;
                        }
                    }
                }
                
                return false;
            }
        }

    }

    //End of Kata method
}