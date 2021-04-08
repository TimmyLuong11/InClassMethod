﻿using System;
using System.Collections.Generic;

namespace Method_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> gpas = new List<double>();
            List<double> itemPrices = new List<double>();
            string response = "";
            bool shouldLoopAgain = true;

            while (shouldLoopAgain)
            {
                double gpa = ValidateInputIsADouble("Please enter in a GPA:");
                gpas.Add(gpa);

                shouldLoopAgain = DoesTheUserWantToGoAgain();
                //Console.WriteLine("Do you want to enter another GPA? Type yes or no.");
                //response = Console.ReadLine();
            }
            response = "";
            shouldLoopAgain = true;
            while(shouldLoopAgain) //(response != "no")
            {
                double gpa = ValidateInputIsADouble("Please enter the price of the item:");
                itemPrices.Add(gpa);

                shouldLoopAgain = DoesTheUserWantToGoAgain();
                //Console.WriteLine("Do you want to enter another price? Type yes or no.");
                //response = Console.ReadLine();
            }
            response = "";
            shouldLoopAgain = true;
            while (shouldLoopAgain)
            {
                double gpa = ValidateInputIsADouble("Please enter the price of the item:");
                itemPrices.Add(gpa);

                shouldLoopAgain = DoesTheUserWantToGoAgain();
                //Console.WriteLine("Do you want to enter another price? Type yes or no.");
                //response = Console.ReadLine();
            }
        }

        /// <summary>
        /// Determines whether the user has more input to enter
        /// </summary>
        /// <returns> 
        /// Returns true of the user is yes
        /// Returns false if the user say no
        /// </returns>
        private static bool DoesTheUserWantToGoAgain()
        {
            string answer ="";
            bool shouldContinue;
            Console.WriteLine("Do you want to enter another value? yes or no");
            answer = Console.ReadLine();
            while (answer.ToLower() != "no" && answer.ToLower() != "yes")
            {
                Console.WriteLine("You must enter the word 'yes' or 'no'.");
                Console.WriteLine("Do you want to enter another value yes or no");
                answer = Console.ReadLine();
            }
            if (answer.ToLower() == "no")
            {
                shouldContinue = false;
                //return false;
            }
            else
            {
                shouldContinue = true;
                //return true;
            }
            return shouldContinue;
        }

        /// <summary>
        /// Validates the user gives a valid double response for the question        
        /// </summary>
        /// <param name="message">The question to ask the user</param>
        /// <returns>A valid double response</returns>
        static double ValidateInputIsADouble(string message)
        {
            double value;
            string answer;
            do
            {
                Console.WriteLine(message);
                answer = Console.ReadLine();
                //bool isDouble = double.TryParse(answer, out value);
            } while(double.TryParse(answer, out value) == false);

            return value;
        }
    }
}
