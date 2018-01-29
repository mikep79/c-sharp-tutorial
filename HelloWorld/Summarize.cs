using System;
using System.Collections.Generic;

namespace numberFun
{
    public class Summarize
    {
        public static void Summarizer()
        {
            // write a method to display "..." if sentence is too long
            string sentence = "According to Strava, athletes with the Metro/heatmap opt-out privacy setting have all data excluded from the mapping project.";
            const int maxLength = 30;

            if (sentence.Length < maxLength)
            {
                Console.WriteLine(sentence);
            }
            else
            {
                Console.WriteLine("The sentence is longer than {0} characters.", maxLength);
                string[] words = sentence.Split(' ');
                // join words in loop into list. Break if longer than maxLength
                var wordsList = new List<string>();
                int totalLength = 0;
                foreach (string word in words)
                {
                    if (totalLength < maxLength)
                    {
                        totalLength += word.Length + 1;
                        wordsList.Add(word);
                    }
                    else
                        break;
                }
                // use .Join method on String .NET class
                //store as new string and display
                string newSentence = System.String.Join(" ", wordsList) + "...";
                Console.WriteLine(newSentence);
            }

            // refactor using static method returning a string

            // move to separate class
        }
    }
}
