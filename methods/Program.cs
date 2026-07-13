using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //learning methods with strings and indexing
            string designer = "Anders Hejlsberg";

            Console.WriteLine(designer);
            int indexOfSpace = designer.IndexOf(" ");
            int indexOfSecondName = indexOfSpace + 1;

            string secondName = designer.Substring(indexOfSecondName);

            Console.WriteLine(secondName);

            //creating our own methods
            VisitPlanets();
        }

        static void VisitPlanets()
        {
            Console.WriteLine("You visited many new planets…");
        }

        /*Playing with parameters
        static void Main(string[] args)
        {
            VisitPlanets(3);
            VisitPlanets(10);
            VisitPlanets(36);
        }

        //we place an int in the parameters so now when its called in main its expected to recieve and int
        static void VisitPlanets(int numberOfPlanets)
        {
            Console.WriteLine($"You visited {numberOfPlanets} new planets...");
        }
        */

        /*Return statements
        static void Main(string[] args)
        {
            Console.WriteLine(DecoratePlanet("Jupiter"));
        }   

        static string DecoratePlanet(string name)
        {
            return $"*.*.* Welcome to {name} *.*.*";
        }
        */
        

        //Method Overloading
        /*
        static void Main(string[] args)
        {
            IntroduceFriends("Laika", "Albert");
            IntroduceFriends("Naomi", "Jasmine", "Cyrus");
            IntroduceFriends();
        }

        static void IntroduceFriends(string name1, string name2)
        {
            Console.WriteLine($"These are my friends, {name1} and {name2}!");
        }

        static void IntroduceFriends(string name1, string name2,string name3)
        {
            Console.WriteLine($"These are my friends, {name1}, {name2} and {name3}!");
        }

        static void IntroduceFriends()
        {
            Console.WriteLine("There is no one who needs to be introduced.");
        }
        */

        //out parameters
        /*
        static voi?430!d Main(string[] args)
        {
            string scoreAsString = "85.6";
            string statement = "Hello World";

            bool outcome;
            double scoreAsDouble;

            outcome = Double.TryParse(scoreAsString, out scoreAsDouble);

            Console.WriteLine(outcome);
            Console.WriteLine(scoreAsDouble);

            string whispered = Whisper("WHAM!", out bool marker);
            Console.WriteLine(whispered);
        }  

        static string Whisper(string phrase, out bool wasCalled)
        {
            wasCalled = true;
            return phrase.ToLower();
        }
        */

        //optional parameters
        /*
        static void Main(string[] args)
        {
            VisitPlanets(3);
            VisitPlanets(4);
            VisitPlanets();
        }
    
        static void VisitPlanets(int numberOfPlanets = 0)
        {
            Console.WriteLine($"You visited {numberOfPlanets} new planets...");
        }
        */

        //Named Arguments
        /*
        static void Main(string[] args)
        {
            VisitPlanets(numberOfPlanets : 2,name : "will");
        }
    
        static void VisitPlanets(
            string adjective = "brave",
            string name = "Cosmonaut", 
            int numberOfPlanets = 0,
            double gForce = 4.2)
        {
            Console.WriteLine($"Welcome back, {adjective} {name}.");
            Console.WriteLine($"You visited {numberOfPlanets} new planets...");
            Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
        }
        */
    }
}
