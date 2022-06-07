using System;
using System.Collections.Generic;

namespace Jumper.Classes
{
    public class Game
    {
        public List<string> parachuteList = new List<string>();
        Parachute parachute = new Parachute();
        Word word = new Word();
        Terminal display = new Terminal();
        public Game()
        {
            parachuteList = parachute.GetParachute();
            string newWord = word.GetWord();
        }

        public void StartGame()
        {
            display.TerminalDisplay(this);
        }
    }
}