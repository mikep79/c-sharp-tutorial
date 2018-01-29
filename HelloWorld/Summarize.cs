using System;
using System.Collections.Generic;

namespace numberFun
{
    public class Summarize
    {
        public static string Summarizer(int maxLength, string sentence = "Here is a sample sentence.")
        {
            // write a method to display "..." if sentence is too long
            if (sentence.Length > maxLength)
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
                // join words and return
                var summarySentence = System.String.Join(" ", wordsList) + "...";
                return summarySentence;
            } 
            else
                return sentence;
        }
    }
}
