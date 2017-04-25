using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tic
{
    class GameMechanics
    {

        public char[] currentBoard { get; set; }

        //constructor, initializing array with available boardspots (0 is free spot/box, 1 is player1, 2 is player2.
        public GameMechanics()
        {
            this.currentBoard = new char[] {' ',' ',' ',' ',' ',' ',' ',' ',' '};
        }


        //render gameboard
        public void RenderBoard()
        {
            char[] boxes = currentBoard;

            Console.Clear();

            Console.WriteLine("TIC TAC TOE - TP EDITION");
            Console.WriteLine("_____________________\n\n");


            Console.WriteLine("  " + boxes[0] + " | " + boxes[1] + "  | " + boxes[2] + " " );
            Console.WriteLine("____|____|____");
            Console.WriteLine("  " + boxes[3] + " | " + boxes[4] + "  | " + boxes[5] + " ");
            Console.WriteLine("____|____|____");
            Console.WriteLine("  " + boxes[6] + " | " + boxes[7] + "  | " + boxes[8] + " ");
            Console.WriteLine("    |    |    ");
        }

 
            
        public bool getPlayerChoice(int choice, int player)
        {
            char[] boxes = currentBoard;
            char p = ' ';
           
            int boxIndex = choice - 1;

            if (boxes[boxIndex] == ' ')
            {
                if (player == 1)
                {
                    p = 'X';
                }
                else
                {
                    p = 'O';
                }
                currentBoard[boxIndex] = p;
                return true;
            }
            else
            {
                Console.WriteLine("Du kan inte välja den här rutan. Försök igen.");
                Thread.Sleep(2000);
                return false;
            }
        }

        //checking if there is a winner. returning '0' if game is still on, '1' for player1, '2' for player1.
        public int CheckWinCondition(int player)
        {
            char[] boxes = currentBoard;
            int freeBoxes = 0;


            if (boxes[0] == boxes[1] && boxes[1] == boxes[2] && boxes[2] != ' ')
            {
                return player;
            }
            else if (boxes[3] == boxes[4] && boxes[4] == boxes[5] && boxes[5] != ' ')
            {
                return player;
            }
            else if (boxes[6] == boxes[7] && boxes[7] == boxes[8] && boxes[8] != ' ')
            {
                return player;
            }
            else if (boxes[0] == boxes[3] && boxes[3] == boxes[6] && boxes[6] != ' ')
            {
                return player;
            }
            else if (boxes[1] == boxes[4] && boxes[4] == boxes[7] && boxes[7] != ' ')
            {
                return player;
            }
            else if (boxes[2] == boxes[5] && boxes[5] == boxes[8] && boxes[8] != ' ')
            {
                return player;
            }
            else if (boxes[0] == boxes[5] && boxes[4] == boxes[8] && boxes[8] != ' ')
            {
                return player;
            }
            else if (boxes[2] == boxes[4] && boxes[4] == boxes[6] && boxes[6] != ' ')
            {
                return player;
            }

            //checking i board is running out of boxes (draw if none of the above statements were true)
            foreach (char box in boxes)
            {
                if (box == ' ')
                {
                    freeBoxes++;
                }
            }

            if(freeBoxes == 0)
            {
                //draw
                return 3;
            }

            else
            {
                //game keeps running
                return 0;
            }


        }
    }
}
