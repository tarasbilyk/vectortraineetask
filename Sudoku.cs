using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[,]
            {
                { 1,2,3,4 },
                { 2,3,4,1 },
                { 3,4,1,2 },
                { 4,1,2,3 }
            };


            //var arr = new int[,]
            //{
            //    { 7, 8, 4, 1, 5, 9, 3, 2, 6 },
            //    { 5, 3, 9, 6, 7, 2, 8, 4, 1 },
            //    { 6, 1, 2, 4, 3, 8, 7, 5, 9 },
            //    { 9, 2, 8, 7, 1, 5, 4, 6, 3 },
            //    { 3, 5, 7, 8, 4, 6, 1, 9, 2 },
            //    { 4, 6, 1, 9, 2, 3, 5, 8, 7 },
            //    { 8, 7, 6, 3, 9, 4, 2, 1, 5 },
            //    { 2, 4, 3, 5, 6, 1, 9, 7, 8 },
            //    { 1, 9, 5, 2, 8, 7, 6, 3, 4 }
            //};

            Console.WriteLine(ValidateSudoku(arr));
        }

        static bool ValidateSudoku(int[,] arr)
        {
            if (arr.GetLength(0) != arr.GetLength(1) ||
                arr.GetLength(0) <= 1 ||
                Math.Sqrt(arr.GetLength(0)) % 1 != 0)
            {
                return false;
            }

            int n = arr.GetLength(0);

            //Check each row and column
            for (int i = 0; i < n; i++)
            {
                var row = new int[n];
                var column = new int[n];
                for (int j = 0; j < n; j++)
                {
                    row[j] = arr[i, j];
                    column[j] = arr[j, i];
                }

                if (!ValidArray(row) ||
                    !ValidArray(column))
                {
                    Console.WriteLine("Invalid column or row");
                    return false;
                }
            }

            int m = Convert.ToInt32(Math.Sqrt(n));
            //Check each small square
            for (int rowCounter = 0; rowCounter < n; rowCounter += m)
                for (int colCounter = 0; colCounter < n; colCounter += m)
                {
                    var square = new int[n];
                    int k = 0;
                    for (int i = rowCounter; i < rowCounter + m; i++)
                    {
                        for (int j = colCounter; j < colCounter + m; j++)
                        {
                            square[k] = arr[i, j];
                            k++;
                        }
                    }
                    if (!ValidArray(square))
                    {
                        Console.WriteLine("Invalid square");
                        return false;
                    }
                }



            return true;
        }

        static bool ValidArray(int[] arr)
        {
            for (int i = 1; i <= arr.Length; i++)
            {
                if (!arr.Contains(i))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

