using System;

namespace working_with_text
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring a string variable
            string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune must be in want of a wife.";

            //second string with a break \
            string firstSpeech = "\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"" ;

            //printing is with a line break or escape character
            Console.WriteLine(firstSentence + "\n\n" + firstSpeech);

            //string concatenation
            //make our variables
            string beginning = "This is the beginning of the story.";
            string middle = "this is the middle of the story.";
            string end =  "this the the end of the said story.";

            //concatenation and storing them in the variable story
            string story = beginning + " " + middle + " " + end;

            //printing the concatenated story
            Console.WriteLine(story);

            //string interpolation
            //making the variables
            string b = "This is the beginning of the story.";
            string m = "this is the middle of the story.";
            string e =  "this the the end of the said story.";

            //interpoling and storing into a variable
            string s = $"in the beginning {b} the in the middle {m} and finally {e}.";

            //printing the story
            Console.WriteLine(s);

            //getting info about strings
            //length
            string password = "a92301j2add";
            int passwordLength = password.Length;

            //Indexof
            int passwordCheck = password.IndexOf("!");

            // Print results
            Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");
        }
    }
}