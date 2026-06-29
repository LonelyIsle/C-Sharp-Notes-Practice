using System;

namespace logic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boolean Data Types
            //True or False: The number 500 is greater than 24.
            bool answerOne = true;

            //True or False: “coffee” contains the letter “a”.
            bool answerTwo = false;

            //Equality operators
            //Cookie store example
            int cookiesSoldGuess = 250;

            int storeOneCookies = 110;
            int storeTwoCookies = 135;

            int cookiesSoldActual = storeOneCookies + storeTwoCookies;

            bool guessedCorrect = (cookiesSoldGuess == cookiesSoldActual);

            Console.WriteLine(guessedCorrect);

            //Comparison operators
            double timeToDinner = 4;

            double distance = 95;
            double rate = 30;

            double tripDuration = distance / rate;

            bool answer = tripDuration <= timeToDinner;

            Console.WriteLine(answer);

            //Logical operators
            //AND, OR, NOT
            bool beach = true;
            bool hiking = false;
            bool city = true;

            bool yourNeeds = (beach && city);

            bool friendNeeds = (beach || hiking);

            bool tripDecision = (yourNeeds && friendNeeds);
            Console.WriteLine(tripDecision);
            
        }
    }
}