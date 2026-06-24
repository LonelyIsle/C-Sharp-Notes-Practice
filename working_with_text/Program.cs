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

            //Getting parts of a string
            //DNA strand
            string startStrand = "ATGCGATGAGCTTAC";

            //find the location of "tga"
            int tga = startStrand.IndexOf("TGA");

            //making the start and stopping point variables
            int startPoint = 0;
            int length = tga +3;

            // usign substring usage
            string dna = startStrand.Substring(startPoint, length);
            Console.WriteLine(dna);

            //checking for mutations
            char mutation = dna[3];
            Console.WriteLine(mutation);

            //Manipulating strings using .ToUpper and .ToLower
            // Script line
            string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";

            // Get camera directions
            int charPosition = script.IndexOf("Close");
            int l = "Close on".Length;
            string cameraDirections = script.Substring(charPosition, l);

            // Get scene description
            charPosition = script.IndexOf("a portrait");
            string sceneDescription = script.Substring(charPosition);

            // Make camera directions uppercase
            cameraDirections = cameraDirections.ToUpper();

            // Make scene description lowercase
            sceneDescription = sceneDescription.ToLower();

            // Print results
            Console.WriteLine(cameraDirections + "\n" + sceneDescription);
        }
    }
}