using Jumper.Classes;


namespace Jumper
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Do you want to start a New Game? ");
            string answer = Console.ReadLine();
            if (answer == "Y")
            {
                Game game = new Game();
                game.StartGame();
            }
        }
    }
}