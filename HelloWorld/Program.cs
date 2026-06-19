using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Your code here
            Console.WriteLine("Hello World!");

            //learning how to read inputs from the input line in terminal
            string input = "";
            Console.WriteLine("How old are you?");
            input = Console.ReadLine();
            Console.WriteLine($"You are {input} years old!");

            //Making a console creature
            Console.WriteLine(" .-.");
            Console.WriteLine("(o o)");
            Console.WriteLine("| O |");
            Console.WriteLine("|   |");
            Console.WriteLine("'~~~'");
            Console.WriteLine("JO-Nathan");    
        }
    }
}