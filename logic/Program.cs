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
            
            
        }
    }
}