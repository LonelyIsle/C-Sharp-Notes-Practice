using System;

namespace arrays_and_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration and initilization of variables
            string[] summerStrut;
            int[] ratings;

            summerStrut = new string[] {"Juice","Missing U","Raspberry Beret","New York Groove","Make Me Feel","Rebel Rebel","Despacito","Los Angeles"};

            ratings = new int[]{1,2,3,4,5,4,3,2};
            
            //implicit typed arrays, they are typed differently and the data type is implied by the elements in the arrays
            /*
            var summerStrut = new[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            var ratings = new[] { 5, 4, 4, 3, 3, 5, 5, 4 };
            */

            //Array Length
            /*
            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            if(summerStrut.Length == 8)
            {
                Console.WriteLine("Good to go!");
            }
            else if(summerStrut.Length > 8)
            {
                Console.WriteLine("Too many songs!");
            }
            else
            {
                Console.WriteLine("Add more songs!");
            }
            */

            //Accessing Array Items
            /*
            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

            Console.WriteLine("you rated the song " + summerStrut[1] + " " + ratings[1] + " stars.");
            */

            //Editing arrays
            /*
            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };\

            summerStrut[7] = "Smooth";
            ratings[7] = 3;
            */

            //Built in methods
            //There are a lot of built in methods for arrays for example Sort(), IndexOf() and, Reverse()
            /*
            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

            int firstThree = Array.IndexOf(ratings, 3) + 1;
            Console.WriteLine("Song number " + firstThree + " is rated three stars.");

            Console.WriteLine(summerStrut[0] + " " + summerStrut[7]);
            Array.Reverse(summerStrut);
            Console.WriteLine(summerStrut[0] + " " + summerStrut[7]);

            Array.Sort(summerStrut);
            Console.WriteLine(summerStrut[0] + " " + summerStrut[7]);
            */
        }
    }
}