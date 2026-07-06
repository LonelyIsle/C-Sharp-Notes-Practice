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

            //switch statements using the if/else above
            switch(ph){
        
            case <= 3:
                Console.WriteLine("Very Acidic");
                break;

            case < 7:
                Console.WriteLine("Acidic");
                break;

            case >= 11:
                Console.WriteLine("Very Basic");
                break;
        
            case > 7:
                Console.WriteLine("Basic");
                break;

            default:
                Console.WriteLine("Neutral");
                break;
            }

            //Ternary Operators

            int pepperLength = 4;
            string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";

            Console.WriteLine(message);
        }
    }
}