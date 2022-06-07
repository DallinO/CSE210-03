using System;
using System.Collections.Generic;

namespace Jumper.Classes
{
    public class Word
    {
        private List<string> wordList = new List<string>();
        string word;
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
            word = wordList[x];
            return(word);
        }

        public List<string> getCharacterList()
        {
            List<string> characterList = new List<string>();
            foreach (char letter in word)
            {
                characterList.Add(letter.ToString());
            }
            return(characterList);
        }
    }
}