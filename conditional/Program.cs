using System;

namespace conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            //conditionals
            //if, if/else, else if,switch, ternary operators

            //if statements
            int socks = 6;

            if(socks <= 3)
            {
                Console.WriteLine("Time to do laundry!");
            }

            //if - else statement
            int people = 11;
            string weather = "nice";

            if(people <= 10 && weather == "nice")
            {
                Console.WriteLine("SaladMart");
            }
            else{
                Console.WriteLine("Soup N Sandwich");
            }

            //else if statement
            double ph = 7.0;

            if(ph < 7)
            {
                Console.WriteLine("Acidic");
            }
            else if(ph > 7)
            {
                Console.WriteLine("Basic");
            }
            else{
                Console.WriteLine("Neutral");
            }
        }
    }
}
