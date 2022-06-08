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
            foreach (string letter1 in game.characterList)
            {
                foreach (string letter2 in game.guessList)
                {
                    if (game.characterList == game.guessList)
                    {
                        Console.Write($"{letter1} ");
                        game.gameOver = game.gameOver + 1;
                    }
                    else
                    {
                        Console.Write("_ ");
                    }
                }
                
            }
        }

        public void guessPrompt()
        {
            Console.Write("Guess a letter [a-z]: ");
        }
    }
}