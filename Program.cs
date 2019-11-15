using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a dictionary with key value pairs to
            represent words (key) and its definition (value)*/
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "the feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Great", "the feeling of students drinking coffee");
            wordsAndDefinitions.Add("Relieved", "the feeling of students when they are done with capstone");
            wordsAndDefinitions.Add("Relaxed", "the feeling of students on vacation");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            Console.WriteLine(wordsAndDefinitions["Awesome"]);
            Console.WriteLine(wordsAndDefinitions["Great"]);
            // Console.WriteLine(wordsAndDefinitions.value[0], wordsAndDefinitions.value[1]);
            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }
        }
    }
}