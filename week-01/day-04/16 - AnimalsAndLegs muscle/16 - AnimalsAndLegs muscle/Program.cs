﻿using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have

            Console.WriteLine("Number of chickens:");
            int chickens = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of pigs:");
            int pigs = int.Parse(Console.ReadLine());

            Console.WriteLine("All the animals have together " + Legs(chickens, pigs) + " legs.");

            Console.ReadLine();
        }

        static int Legs(int chickens, int pigs)
        {
            int allLegs = chickens * 2 + pigs * 4;

            return allLegs;
        }
    }
}