using System;
using System.Collections.Generic;

namespace Jumper.Classes
{
    public class Terminal
    {
        public void displayParachute(Game game)
        {
           foreach (string line in game.parachuteList)
           {
               Console.WriteLine(line);
           }
        }

        public void displayWord(Game game)
        {
            foreach (string letter in game.characterList)
            {
                Console.Write($"{letter} ");
            }
        }
    }
}