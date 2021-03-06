﻿using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            int n = 5;
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please provide a number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            SumAve(numbers);

            Console.ReadLine();
        }

        public static void SumAve(int[] numbers)
        {
            int sum = 0;
            double average;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            average = sum / numbers.Length;

            Console.WriteLine("Sum of the numbers is: {0}, their average is: {1}", sum, average);
        }
    }
}