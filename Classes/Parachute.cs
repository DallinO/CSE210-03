using System;
using System.Collections.Generic;

namespace Jumper.Classes
{
    public class Parachute
    {
        private List<string> parachute = new List<string>();
        public Parachute()
        {
            parachute.Add(" ___ ");
            parachute.Add("/___\\");
            parachute.Add("\\   /");
            parachute.Add(" \\ / ");
            parachute.Add("  O  ");
            parachute.Add(" /|\\ ");
            parachute.Add(" / \\ ");
            parachute.Add("     ");
        }

        public List<string> GetParachute()
        {
            return(parachute);
        }
    }
}