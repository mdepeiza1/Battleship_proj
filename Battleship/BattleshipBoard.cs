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
        public string[,] player1board = new string[20, 20];
        public string[,] player2board = new string[20, 20];
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
            for (int x = 0; x < 20; x++)
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
            if (isItPlayerOnesTurn)
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
            for (int i = 0; i < player1.fleet.Count; i++)
            {
                if (player1.fleet[i].frontRow == player1.fleet[i].backRow)
                {
                    if (player1.fleet[i].frontColumn < player1.fleet[i].backColumn)
                    {
                        for (int y = player1.fleet[i].frontColumn; y <= player1.fleet[i].backColumn; y++)//update this for the rows 1-20 instead of 0-19
                        {
                            player1board[player1.fleet[i].frontRow, y] = player1.fleet[i].typeOfShip;
                        }
                    }
                    else
                    {
                        for (int y = player1.fleet[i].backColumn; y <= player1.fleet[i].frontColumn; y++)//update this for the rows 1-20 instead of 0-19
                        {
                            player1board[player1.fleet[i].frontRow, y] = player1.fleet[i].typeOfShip;
                        }
                    }
                }
                else
                {
                    if (player1.fleet[i].frontRow < player1.fleet[i].backRow)
                    {
                        for (int x = player1.fleet[i].frontRow; x <= player1.fleet[i].backRow; x++)//update this for the rows 1-20 instead of 0-19
                        {
                            player1board[x, player1.fleet[i].frontColumn] = player1.fleet[i].typeOfShip;
                        }
                    }
                    else
                    {
                        for (int x = player1.fleet[i].backRow; x <= player1.fleet[i].frontRow; x++)//update this for the rows 1-20 instead of 0-19
                        {
                            player1board[x, player1.fleet[i].frontColumn] = player1.fleet[i].typeOfShip;
                        }
                    }
                }
            }
        }

        public void AddShipsOfPlayer2ToPlayer2sBoard()
        {
            for (int i = 0; i < player2.fleet.Count; i++)
            {
                if (player2.fleet[i].frontRow == player2.fleet[i].backRow)
                {
                    if (player2.fleet[i].frontColumn < player2.fleet[i].backColumn)
                    {
                        for (int y = player2.fleet[i].frontColumn; y <= player2.fleet[i].backColumn; y++)//update this for the rows 1-20 instead of 0-19
                        {
                            player2board[player2.fleet[i].frontRow, y] = player2.fleet[i].typeOfShip;
                        }
                    }
                    else
                    {
                        for (int y = player2.fleet[i].backColumn; y <= player2.fleet[i].frontColumn; y++)//update this for the rows 1-20 instead of 0-19
                        {
                            player2board[player2.fleet[i].frontRow, y] = player2.fleet[i].typeOfShip;
                        }
                    }
                }
                else
                {
                    if (player2.fleet[i].frontRow < player2.fleet[i].backRow)
                    {
                        for (int x = player2.fleet[i].frontRow; x <= player2.fleet[i].backRow; x++)//update this for the rows 1-20 instead of 0-19
                        {
                            player2board[x, player2.fleet[i].frontColumn] = player2.fleet[i].typeOfShip;
                        }
                    }
                    else
                    {
                        for (int x = player2.fleet[i].backRow; x <= player2.fleet[i].frontRow; x++)//update this for the rows 1-20 instead of 0-19
                        {
                            player2board[x, player2.fleet[i].frontColumn] = player2.fleet[i].typeOfShip;
                        }
                    }
                }
            }
        }

        public void AddShotsOfPlayer1ToPlayer2sBoard()
        {
            for (int x = 0; x < player1.shots.Count; x++)
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
            for (int x = 0; x < 20; x++)//refreshing board
            {
                for (int y = 0; y < 20; y++)
                {
                    player2board[x, y] = "^";
                }
            }
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    player1board[x, y] = "^";
                }
            }//refreshing board
            Console.Clear();
            AddShipsOfPlayer1ToPlayer1sBoard();
            AddShotsOfPlayer1ToPlayer2sBoard();
            AddShotsOfPlayer2ToPlayer1sBoard();
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
            isItPlayerOnesTurn = false;
        }

        public void ReloadBoardPlayer2sTurn()
        {
            for (int x = 0; x < 20; x++)//refreshing board
            {
                for (int y = 0; y < 20; y++)
                {
                    player2board[x, y] = "^";
                }
            }
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    player1board[x, y] = "^";
                }
            }//refreshing board
            Console.Clear();
            AddShipsOfPlayer2ToPlayer2sBoard();
            AddShotsOfPlayer1ToPlayer2sBoard();
            AddShotsOfPlayer2ToPlayer1sBoard();
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
            isItPlayerOnesTurn = true;
        }
    }
}
