using System;
using System.Collections.Generic;

namespace Jumper.Classes
{
    public class Game
    {
        public List<string> characterList = new List<string>();
        public List<string> parachuteList = new List<string>();
        public List<string> guessList = new List<string>();
        Parachute parachute = new Parachute();
        Word word = new Word();
        public int gameOver = 0;
        public int win = 0;
        Terminal display = new Terminal();
        public Game()
        {
            parachuteList = parachute.GetParachute();
            string newWord = word.GetWord();
            characterList = word.getCharacterList();
        }

        public void Guess()
        {
            display.guessPrompt();
            string guess = Console.ReadLine();
            guessList.Add(guess);
            bool correct = false;

            foreach (string letter in characterList)
            {
                if (letter.ToUpper() == guess.ToUpper())
                {
                    correct = true;
                }
            }
            if (correct == false)
            {
                gameOver = gameOver + 1;
                parachuteList.Remove(parachuteList[0]);
            }
            if (correct == true)
            {
                win = win + 1;
            }
        }

        public void StartGame()
        {
            while (gameOver != 4 && win != 5)
            {
                display.displayWord(this);
                display.displayParachute(this);
                Guess();
            }
            display.EndScreen(this);
        }


    }
}