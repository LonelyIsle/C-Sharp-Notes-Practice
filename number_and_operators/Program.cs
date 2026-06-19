using System;
using System.Security.Cryptography;

namespace number_and_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example of math operations
            // Calculating Net Income 
            double revenue = 853023.45;
            double expenses = 438374.11;
            double netIncome = revenue - expenses;

            Console.WriteLine(netIncome);

            // Calculating a Break-Even Point
            double fixedCosts = 912849.30;
            double salesPrice = 29.99;
            double variableCostPerUnit = 17.65;

            double breakEvenVolume = fixedCosts / (salesPrice - variableCostPerUnit);
            Console.WriteLine(breakEvenVolume);

            //Number examples and how to use ints or decimal data types
            //number of shops a pizza place has
            int pizzaShops = 4332;

            //total number of employees a company has
            int totalEmployees = 86928;

            //Revenue for a buisness
            decimal revenue2 = 390819.28m;

            //print the vaules
            Console.WriteLine(pizzaShops);
            Console.WriteLine(totalEmployees);
            Console.WriteLine(revenue2);

            //Arithmetic Operators ie. addition, subtraction, multiplication and division
            //Example is calculating you age on different planets
            
            //age on earth
            int age = 24;
            
            //length of years on jupiter
            double jupiterYears = 11.86;

            //age on jupiter
            double jupiterAge = age / jupiterYears;

            //time on jupiter
            double journeyToJupiter = 6.142466;

            //new age on earth
            double newEarthAge = age + journeyToJupiter;

            //new age on jupiter
            double newJupiterAge = newEarthAge / jupiterYears;

            //print it out
            Console.WriteLine(age);
            Console.WriteLine(jupiterAge);
            Console.WriteLine(newEarthAge);
            Console.WriteLine(newJupiterAge);

        }
    }
}