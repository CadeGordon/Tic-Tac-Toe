﻿using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2DInitExample = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


            int[,] array2DInitExample2 = { { 1, 2, 3 }, 
                                           { 4, 5, 6 },
                                           { 7, 8, 9 },
                                           { 10, 11, 12 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(array2DInitExample[i, j]);
                }
            }

            void PrintSumOf2DArray(int [,] array)
            {

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    int sum = 0;

                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        sum += array[i, j];
                    }
                    Console.WriteLine(sum);
                }

                
            }

            PrintSumOf2DArray(array2DInitExample);
            
        }
    }
}
