using System;
using System.Collections.Generic;

namespace Jumper.Classes
{
    public class Game
    {
        List<string> parachuteList = new List<string>();
        Parachute parachute = new Parachute();
        public Game()
        {
            parachuteList = parachute.GetParachute(); 
        }

        public void StartGame()
        {
            foreach (string line in parachuteList)
            {
                Console.WriteLine(line);
            }
        }
    }
}