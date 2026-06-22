using System;

namespace data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            //strings
            string name = "Shadow";
            string breed = "Golden Retriever";
            //int
            int age = 5;
            //double
            double weight = 65.22;
            //boolean
            bool spayed = true;
            
            //writing all the variables to the console
            Console.WriteLine(name);
            Console.WriteLine(breed);
            Console.WriteLine(age);
            Console.WriteLine(weight);
            Console.WriteLine(spayed);

            //the use of the keyword of var in C#, allowing C# to pick the datatype
            var food = "apple";
            var calories = 95;
            var isFruit = true;

            Console.WriteLine(food);
            Console.WriteLine(calories);
            Console.WriteLine(isFruit);

            //data type conversion
            Console.WriteLine("Enter your favorite number!: ");
            int faveNumber = Convert.ToInt32(Console.ReadLine());
            //double dFavNumber = Convert.ToDouble(Console.ReadLine());
            //bool bFavNumber = Convert.ToBoolean(Console.ReadLine());
        }
    }
}