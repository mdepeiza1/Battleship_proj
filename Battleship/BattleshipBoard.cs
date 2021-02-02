using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class BattleshipBoard : IBoard
    {
        public Player player1;
        public Player player2;
        public string[,] player1board = new string[20,20];
        public string[,] player2board = new string[20,20];

        public BattleshipBoard()
        {

        }

        public void CreateBoard()
        {
            Console.WriteLine("Player 1 goes first");
            Console.WriteLine("Player 2's Board");
            for(int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    player1board[x, y] = "^";
                    Console.Write(player1board[x, y]);
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            Console.WriteLine("Player 1's board");
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    player2board[x, y] = "^";
                    Console.Write(player2board[x, y]);
                }
                Console.Write("\n");
            }
        }

        public void UpdateBoard()
        {

        }
    }
}
