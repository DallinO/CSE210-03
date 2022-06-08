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
                bool correct = false;
                foreach (string letter2 in game.guessList)
                {
                    if (letter1.ToUpper() == letter2.ToUpper())
                    {
                        Console.Write($"{letter1} ");
                        correct = true;
                    }
                }
                if (correct == false)
                {
                    Console.Write("_ ");
                }
                
            }
            Console.WriteLine("\n");
        }

        public void guessPrompt()
        {
            Console.Write("Guess a letter [a-z]: ");
        }

        public void EndScreen(Game game)
        {
            
            if (game.gameOver == 4)
            {
                displayParachute(game);
                Console.WriteLine("GAME OVER!");
            }
            else
            {
                displayWord(game);
                Console.WriteLine("YOU WIN!");
            }
        }
    }
}