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
        bool isItPlayerOnesTurn;

        public BattleshipBoard()
        {
            player1 = new Player();
            player2 = new Player();
            isItPlayerOnesTurn = true;
        }

        public void CreateBoard()
        {
            Console.WriteLine("Player 2's Board");
            for(int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    player2board[x, y] = "^";
                    Console.Write(player2board[x, y]);
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            Console.WriteLine("Player 1's board");
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    player1board[x, y] = "^";
                    Console.Write(player1board[x, y]);
                }
                Console.Write("\n");
            }
        }

        public void UpdateBoard()
        {
            if(isItPlayerOnesTurn)
            {
                ReloadBoardPlayer1sTurn();
            }
            else
            {
                ReloadBoardPlayer2sTurn();
            }
        }

        public void AddShipsOfPlayer1ToPlayer1sBoard()
        {

        }

        public void AddShipsOfPlayer2ToPlayer2sBoard()
        {

        }

        public void AddShotsOfPlayer1ToPlayer2sBoard()
        {
            for(int x = 0; x < player1.shots.Count; x++)
            {
                player2board[player1.shots[x].row, player1.shots[x].column] = player1.shots[x].attackType;
            }
        }

        public void AddShotsOfPlayer2ToPlayer1sBoard()
        {
            for (int x = 0; x < player2.shots.Count; x++)
            {
                player1board[player2.shots[x].row, player2.shots[x].column] = player2.shots[x].attackType;
            }
        }

        public void ReloadBoardPlayer1sTurn()
        {
            Console.WriteLine("Player 2's Board");
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    Console.Write(player2board[x, y]);
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            Console.WriteLine("Player 1's board");
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    Console.Write(player1board[x, y]);
                }
                Console.Write("\n");
            }
        }

        public void ReloadBoardPlayer2sTurn()
        {
            Console.WriteLine("Player 1's Board");
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    Console.Write(player1board[x, y]);
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            Console.WriteLine("Player 2's board");
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    Console.Write(player2board[x, y]);
                }
                Console.Write("\n");
            }
        }
    }
}
