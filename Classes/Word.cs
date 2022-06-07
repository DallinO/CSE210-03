using System;
using System.Collections.Generic;

namespace Jumper.Classes
{
    public class Word
    {
        private List<string> wordList = new List<string>();
        Random rnd = new Random();
        public Word()
        {
            wordList.Add("Money");
            wordList.Add("Crazy");
            wordList.Add("Pizza");
            wordList.Add("Alone");
            wordList.Add("Breed");
            wordList.Add("Class");
            wordList.Add("Faith");
            wordList.Add("Jones");
            wordList.Add("North");
            wordList.Add("Motor");
        }

        public string GetWord()
        {
            int x = rnd.Next(wordList.Count);
            string word = wordList[x];
            return(word);
        }
    }
}