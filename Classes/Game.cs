using System;
using System.Collections.Generic;

namespace Jumper.Classes
{
    public class Game
    {
        public List<string> characterList = new List<string>();
        public List<string> parachuteList = new List<string>();
        Parachute parachute = new Parachute();
        Word word = new Word();
        Terminal display = new Terminal();
        public Game()
        {
            parachuteList = parachute.GetParachute();
            string newWord = word.GetWord();
            characterList = word.getCharacterList();
        }

        public void StartGame()
        {
            display.displayWord(this);
            display.displayParachute(this);
        }
    }
}