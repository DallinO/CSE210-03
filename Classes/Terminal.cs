using System;
using System.Collections.Generic;

namespace Jumper.Classes
{
    public class Terminal
    {
        public void TerminalDisplay(Game game)
        {
           foreach (string line in game.parachuteList)
           {
               Console.WriteLine(line);
           }
        }
    }
}