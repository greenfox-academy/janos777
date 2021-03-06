﻿// Create a function that prints the multiplication table of a given base number.
// It should take the base number as a parameter, and prints the output to the
// console.

// The output should look like this for 5 as base:
//  1 * 5 = 5
//  2 * 5 = 10
//  3 * 5 = 15
//  4 * 5 = 20
//  5 * 5 = 25
//  6 * 5 = 30
//  7 * 5 = 35
//  8 * 5 = 40
//  9 * 5 = 45
//  10 * 5 = 50

using System;

namespace MultiplicationTable
{
    public class MultiplicationTable
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please provide the base number for the multiplication table: ");
            int baseNumber = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine(GetMultiplicationTable(baseNumber));

            Console.ReadLine();
        }

        public static string GetMultiplicationTable(int n)
        {
            string table = "";

            for (int i = 1; i <= 10; i++)
            {
                table += $"{i} * {n} = {i * n}\n";
            }

            return table;
        }
    }
}
