﻿using System;

namespace CalculatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int secondNumber = int.Parse(Console.ReadLine());

            int answer = firstNumber + secondNumber;

            Console.WriteLine("{0} + {1} = {2}", firstNumber, + secondNumber, answer);
        }

    }
}

