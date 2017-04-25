using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic
{
    class Program
    {
        //variables
        static int currentPlayer = 1;
        static bool runGame = true;
        static int gameState = 0;
        static Player p1 = new Player("", 1);
        static Player p2 = new Player("", 2);


        static void Main(string[] args)
        {
            //instantiating game mechanics
            GameMechanics game = new GameMechanics();

            //creating players
            Console.WriteLine("\nSkriv in namn för spelare 1 (x): ");
            p1.playerName = "[x]" + Console.ReadLine();

            Console.WriteLine("\nSkriv in namn för spelare 2 (o): ");
            p2.playerName = "[o]" + Console.ReadLine();


            //game loop
            while (runGame)
            {
                game.RenderBoard();

                Console.WriteLine("\n" + CurrentPlayerName(currentPlayer) + "s tur");

                Console.WriteLine("\nVälj en ledig ruta (1-9): ");

                //change player if choice not valid.
                if (!game.getPlayerChoice(Convert.ToInt32(Console.ReadLine()), currentPlayer))
                    ChangePlayer();
                
                //checking if a player has won the match, returns 0 if game is still on.
                gameState = game.CheckWinCondition(currentPlayer);

                switch (gameState)
                {
                    case 1:
                        game.RenderBoard();
                        Console.WriteLine("\n" + CurrentPlayerName(currentPlayer) + " har vunnit!");
                        runGame = false;
                        break;
                    case 2:
                        game.RenderBoard();
                        Console.WriteLine("\n" + CurrentPlayerName(currentPlayer) + " har vunnit!");
                        runGame = false;
                        break;
                    case 3:
                        game.RenderBoard();
                        Console.WriteLine("\nSpelet är oavgjort.");
                        runGame = false;
                        break;
                    default:
                        break;
                }

                //changing player
                ChangePlayer();


            }
            //game loop end.


            Console.WriteLine("\nTack för att du spelat spelet!");
            Console.ReadLine();
        }


        //simple method to change player.
        static void ChangePlayer()
        {
            if (currentPlayer == 1)
            {
                currentPlayer = 2;
            }
            else
            {
                currentPlayer = 1;
            }
        }


        //fetching current playername
        static string CurrentPlayerName(int currentPlayer)
        {
            if (currentPlayer == 1)
            {

                return p1.playerName;
            }
            else
            {
                return p2.playerName;
            }
        }

     

    }
}
