﻿using System;

namespace _7._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            MatrixInitilization(num);

        }

        private static void MatrixInitilization(int num)
        {
            for (int i = 0; i < num; i++)
            {
                
                for (int j = 0; j < num; j++)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}