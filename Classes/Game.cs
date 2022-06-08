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
        }

        public void StartGame()
        {
            while (gameOver != 5)
            {
                display.displayWord(this);
                display.displayParachute(this);
                Guess();
            }
        }


    }
}