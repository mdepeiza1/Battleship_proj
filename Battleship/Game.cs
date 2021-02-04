using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Battleship
{
    class Game
    {
        bool nobodyHasWonYet;
        bool p1Won;
        bool p2Won;
        BattleshipBoard board;
        public Game()
        {
            board = new BattleshipBoard();
            nobodyHasWonYet = true;
            p1Won = false;
            p2Won = false;
        }

        public void RunGame()
        {
            Console.WriteLine("Player 1 goes first!");
            board.CreateBoard();
            Console.WriteLine("Please press enter to begin:");
            Console.ReadLine();
            bool continuelooping = true;
            while (continuelooping)
            {

                Console.WriteLine("Please enter the number of the ship to place:");
                Console.WriteLine("1:Destroyer");
                Console.WriteLine("2:Submarine");
                Console.WriteLine("3:Battleship");
                Console.WriteLine("4:Aircraft Carrier");


                if (Int32.TryParse(Console.ReadLine(), out int chosenShip1))
                {
                    switch (chosenShip1)
                    {
                        case 1:
                            Console.WriteLine("Please enter the row of the front of the destroyer:");
                            if (Int32.TryParse(Console.ReadLine(), out int value1))
                            {
                                Console.WriteLine("Please enter the column of the front of the destroyer:");
                                if (Int32.TryParse(Console.ReadLine(), out int value2))
                                {
                                    Console.WriteLine("Please enter the row of the back of the destroyer:");
                                    if (Int32.TryParse(Console.ReadLine(), out int value3))
                                    {
                                        Console.WriteLine("Please enter the column of the back of the destroyer:");
                                        if (Int32.TryParse(Console.ReadLine(), out int value4))
                                        {
                                            board.player1.AddShips(value1, value2, value3, value4, 1);
                                            if (board.player1.fleet.Count == 4)
                                            {
                                                continuelooping = false;
                                            }
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter an integer.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter an integer.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please enter an integer.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter an integer.");
                            }
                            break; //check that it's only exiting the switch statement
                        case 2://submarine logic
                            Console.WriteLine("Please enter the row of the front of the submarine:");
                            if (Int32.TryParse(Console.ReadLine(), out int value5))
                            {
                                Console.WriteLine("Please enter the column of the front of the submarine:");
                                if (Int32.TryParse(Console.ReadLine(), out int value6))
                                {
                                    Console.WriteLine("Please enter the row of the back of the submarine:");
                                    if (Int32.TryParse(Console.ReadLine(), out int value7))
                                    {
                                        Console.WriteLine("Please enter the column of the back of the submarine:");
                                        if (Int32.TryParse(Console.ReadLine(), out int value8))
                                        {
                                            board.player1.AddShips(value5, value6, value7, value8, 2);
                                            if (board.player1.fleet.Count == 4)
                                            {
                                                continuelooping = false;
                                            }
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter an integer.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter an integer.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please enter an integer.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter an integer.");
                            }
                            break;
                        case 3://battleship logic
                            Console.WriteLine("Please enter the row of the front of the battleship:");
                            if (Int32.TryParse(Console.ReadLine(), out int value9))
                            {
                                Console.WriteLine("Please enter the column of the front of the battleship:");
                                if (Int32.TryParse(Console.ReadLine(), out int value10))
                                {
                                    Console.WriteLine("Please enter the row of the back of the battleship:");
                                    if (Int32.TryParse(Console.ReadLine(), out int value11))
                                    {
                                        Console.WriteLine("Please enter the column of the back of the battleship:");
                                        if (Int32.TryParse(Console.ReadLine(), out int value12))
                                        {
                                            board.player1.AddShips(value9, value10, value11, value12, 3);
                                            if (board.player1.fleet.Count == 4)
                                            {
                                                continuelooping = false;
                                            }
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter an integer.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter an integer.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please enter an integer.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter an integer.");
                            }
                            break;
                        case 4://aircraft carrier logic
                            Console.WriteLine("Please enter the row of the front of the aircraft carrier:");
                            if (Int32.TryParse(Console.ReadLine(), out int value13))
                            {
                                Console.WriteLine("Please enter the column of the front of the aircraft carrier:");
                                if (Int32.TryParse(Console.ReadLine(), out int value14))
                                {
                                    Console.WriteLine("Please enter the row of the back of the aircraft carrier:");
                                    if (Int32.TryParse(Console.ReadLine(), out int value15))
                                    {
                                        Console.WriteLine("Please enter the column of the back of the aircraft carrier:");
                                        if (Int32.TryParse(Console.ReadLine(), out int value16))
                                        {
                                            board.player1.AddShips(value13, value14, value15, value16, 4);
                                            if (board.player1.fleet.Count == 4)
                                            {
                                                continuelooping = false;
                                            }
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter an integer.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter an integer.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please enter an integer.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter an integer.");
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an integer.");
                }

            }
            board.UpdateBoard();
            Console.WriteLine("Board will be cleared in 8 seconds.");
            Thread.Sleep(8000);
            Console.Clear();
            Console.WriteLine("Please press enter for Player 2 to place their ships:");
            Console.ReadLine();
            bool continuelooping2 = true;
            while (continuelooping2)
            {

                Console.WriteLine("Please enter the number of the ship to place:");
                Console.WriteLine("1:Destroyer");
                Console.WriteLine("2:Submarine");
                Console.WriteLine("3:Battleship");
                Console.WriteLine("4:Aircraft Carrier");


                if (Int32.TryParse(Console.ReadLine(), out int chosenShip2))
                {
                    switch (chosenShip2)
                    {
                        case 1:
                            Console.WriteLine("Please enter the row of the front of the destroyer:");
                            if (Int32.TryParse(Console.ReadLine(), out int value1))
                            {
                                Console.WriteLine("Please enter the column of the front of the destroyer:");
                                if (Int32.TryParse(Console.ReadLine(), out int value2))
                                {
                                    Console.WriteLine("Please enter the row of the back of the destroyer:");
                                    if (Int32.TryParse(Console.ReadLine(), out int value3))
                                    {
                                        Console.WriteLine("Please enter the column of the back of the destroyer:");
                                        if (Int32.TryParse(Console.ReadLine(), out int value4))
                                        {
                                            board.player2.AddShips(value1, value2, value3, value4, 1);
                                            if (board.player2.fleet.Count == 4)
                                            {
                                                continuelooping2 = false;
                                            }
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter an integer.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter an integer.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please enter an integer.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter an integer.");
                            }
                            break; //check that it's only exiting the switch statement
                        case 2://submarine logic
                            Console.WriteLine("Please enter the row of the front of the submarine:");
                            if (Int32.TryParse(Console.ReadLine(), out int value5))
                            {
                                Console.WriteLine("Please enter the column of the front of the submarine:");
                                if (Int32.TryParse(Console.ReadLine(), out int value6))
                                {
                                    Console.WriteLine("Please enter the row of the back of the submarine:");
                                    if (Int32.TryParse(Console.ReadLine(), out int value7))
                                    {
                                        Console.WriteLine("Please enter the column of the back of the submarine:");
                                        if (Int32.TryParse(Console.ReadLine(), out int value8))
                                        {
                                            board.player2.AddShips(value5, value6, value7, value8, 2);
                                            if (board.player2.fleet.Count == 4)
                                            {
                                                continuelooping2 = false;
                                            }
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter an integer.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter an integer.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please enter an integer.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter an integer.");
                            }
                            break;
                        case 3://battleship logic
                            Console.WriteLine("Please enter the row of the front of the battleship:");
                            if (Int32.TryParse(Console.ReadLine(), out int value9))
                            {
                                Console.WriteLine("Please enter the column of the front of the battleship:");
                                if (Int32.TryParse(Console.ReadLine(), out int value10))
                                {
                                    Console.WriteLine("Please enter the row of the back of the battleship:");
                                    if (Int32.TryParse(Console.ReadLine(), out int value11))
                                    {
                                        Console.WriteLine("Please enter the column of the back of the battleship:");
                                        if (Int32.TryParse(Console.ReadLine(), out int value12))
                                        {
                                            board.player2.AddShips(value9, value10, value11, value12, 3);
                                            if (board.player2.fleet.Count == 4)
                                            {
                                                continuelooping2 = false;
                                            }
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter an integer.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter an integer.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please enter an integer.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter an integer.");
                            }
                            break;
                        case 4://aircraft carrier logic
                            Console.WriteLine("Please enter the row of the front of the aircraft carrier:");
                            if (Int32.TryParse(Console.ReadLine(), out int value13))
                            {
                                Console.WriteLine("Please enter the column of the front of the aircraft carrier:");
                                if (Int32.TryParse(Console.ReadLine(), out int value14))
                                {
                                    Console.WriteLine("Please enter the row of the back of the aircraft carrier:");
                                    if (Int32.TryParse(Console.ReadLine(), out int value15))
                                    {
                                        Console.WriteLine("Please enter the column of the back of the aircraft carrier:");
                                        if (Int32.TryParse(Console.ReadLine(), out int value16))
                                        {
                                            board.player2.AddShips(value13, value14, value15, value16, 4);
                                            if (board.player2.fleet.Count == 4)
                                            {
                                                continuelooping2 = false;
                                            }
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please enter an integer.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter an integer.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please enter an integer.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter an integer.");
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an integer.");
                }

            }
            board.UpdateBoard();
            Console.WriteLine("Board will be cleared in 8 seconds.");
            Thread.Sleep(8000);
            Console.Clear();
            Console.WriteLine("Please press enter to begin the game:");
            Console.ReadLine();

            while (nobodyHasWonYet) //handle out of range exceptions too
            {
                board.UpdateBoard(); //Player 1's turn
                Console.WriteLine("Please enter the row of your first attack:");
                while (true)
                {
                    if (Int32.TryParse(Console.ReadLine(), out int attrow1))
                    {
                        Console.WriteLine("Please enter the column of your first attack:");
                        if (Int32.TryParse(Console.ReadLine(), out int attcol1))
                        {
                            if(board.player1.Attack(attrow1, attcol1, board.player2))//add check for winning condition in here
                            {
                                nobodyHasWonYet = false;
                                p1Won = true;
                            }//add check for winning condition in here

                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter an integer.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter an integer.");
                    }
                }
                if(p1Won)
                {
                    break;
                }
                Console.WriteLine("Board will be cleared in 5 seconds.");
                Thread.Sleep(5000);
                Console.Clear();
                Console.WriteLine("Please press enter to go to Player 2's turn:");
                Console.ReadLine();

                board.UpdateBoard(); //Player 2's turn
                Console.WriteLine("Please enter the row of your first attack:");
                while (true)
                {
                    if (Int32.TryParse(Console.ReadLine(), out int attrow2))
                    {
                        Console.WriteLine("Please enter the column of your first attack:");
                        if (Int32.TryParse(Console.ReadLine(), out int attcol2))
                        {
                            if (board.player2.Attack(attrow2, attcol2, board.player1))
                            {
                                nobodyHasWonYet = false;
                                p2Won = true;
                            }//add check for winning condition in here
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter an integer.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter an integer.");
                    }
                }
                if(p2Won)
                {
                    break;
                }
                Console.WriteLine("Board will be cleared in 5 seconds.");
                Thread.Sleep(5000);
                Console.Clear();
                Console.WriteLine("Please press enter to go to Player 1's turn:");
                Console.ReadLine();
            }
            if (p1Won)
            {
                Console.Clear();
                Console.WriteLine("Player One Has Won!");
                Console.WriteLine("Please press enter to end the game.");
                Console.ReadLine();
            }
            if (p2Won)
            {
                Console.Clear();
                Console.WriteLine("Player Two Has Won!");
                Console.WriteLine("Please press enter to end the game.");
                Console.ReadLine();
            }//"hit and sunk" needs to be added, out of bounds needs to be handled
        }
    }
}
