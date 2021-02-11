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
            board.CreateBoard();
            Console.WriteLine("Player 1 goes first!");
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


                if (Int32.TryParse(Console.ReadLine(), out int chosenShip1) && (chosenShip1 >= 1 && chosenShip1 <= 4))
                {
                    switch (chosenShip1)
                    {
                        case 1:
                            Console.WriteLine("Please enter the row of the front of the destroyer:");
                            if (Int32.TryParse(Console.ReadLine(), out int value1) && (value1 >= 0 && value1 <= 19))
                            {
                                Console.WriteLine("Please enter the column of the front of the destroyer:");
                                if (Int32.TryParse(Console.ReadLine(), out int value2) && (value2 >= 0 && value2 <= 19))
                                {
                                    Console.WriteLine("Please enter the row of the back of the destroyer:");
                                    if (Int32.TryParse(Console.ReadLine(), out int value3) && (value3 >= 0 && value3 <= 19))
                                    {
                                        Console.WriteLine("Please enter the column of the back of the destroyer:");
                                        if (Int32.TryParse(Console.ReadLine(), out int value4) && (value4 >= 0 && value4 <= 19))
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
                                            Console.WriteLine("Please enter an integer between 0 and 19.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter an integer between 0 and 19.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please enter an integer between 0 and 19.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter an integer between 0 and 19.");
                            }
                            break; //check that it's only exiting the switch statement
                        case 2://submarine logic
                            Console.WriteLine("Please enter the row of the front of the submarine:");
                            if (Int32.TryParse(Console.ReadLine(), out int value5) && (value5 >= 0 && value5 <= 19))
                            {
                                Console.WriteLine("Please enter the column of the front of the submarine:");
                                if (Int32.TryParse(Console.ReadLine(), out int value6) && (value6 >= 0 && value6 <= 19))
                                {
                                    Console.WriteLine("Please enter the row of the back of the submarine:");
                                    if (Int32.TryParse(Console.ReadLine(), out int value7) && (value7 >= 0 && value7 <= 19))
                                    {
                                        Console.WriteLine("Please enter the column of the back of the submarine:");
                                        if (Int32.TryParse(Console.ReadLine(), out int value8) && (value8 >= 0 && value8 <= 19))
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
                                            Console.WriteLine("Please enter an integer between 0 and 19.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter an integer between 0 and 19.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please enter an integer between 0 and 19.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter an integer between 0 and 19.");
                            }
                            break;
                        case 3://battleship logic
                            Console.WriteLine("Please enter the row of the front of the battleship:");
                            if (Int32.TryParse(Console.ReadLine(), out int value9) && (value9 >= 0 && value9 <= 19))
                            {
                                Console.WriteLine("Please enter the column of the front of the battleship:");
                                if (Int32.TryParse(Console.ReadLine(), out int value10) && (value10 >= 0 && value10 <= 19))
                                {
                                    Console.WriteLine("Please enter the row of the back of the battleship:");
                                    if (Int32.TryParse(Console.ReadLine(), out int value11) && (value11 >= 0 && value11 <= 19))
                                    {
                                        Console.WriteLine("Please enter the column of the back of the battleship:");
                                        if (Int32.TryParse(Console.ReadLine(), out int value12) && (value12 >= 0 && value12 <= 19))
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
                                            Console.WriteLine("Please enter an integer between 0 and 19.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter an integer between 0 and 19.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please enter an integer between 0 and 19.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter an integer between 0 and 19.");
                            }
                            break;
                        case 4://aircraft carrier logic
                            Console.WriteLine("Please enter the row of the front of the aircraft carrier:");
                            if (Int32.TryParse(Console.ReadLine(), out int value13) && (value13 >= 0 && value13 <= 19))
                            {
                                Console.WriteLine("Please enter the column of the front of the aircraft carrier:");
                                if (Int32.TryParse(Console.ReadLine(), out int value14) && (value14 >= 0 && value14 <= 19))
                                {
                                    Console.WriteLine("Please enter the row of the back of the aircraft carrier:");
                                    if (Int32.TryParse(Console.ReadLine(), out int value15) && (value15 >= 0 && value15 <= 19))
                                    {
                                        Console.WriteLine("Please enter the column of the back of the aircraft carrier:");
                                        if (Int32.TryParse(Console.ReadLine(), out int value16) && (value16 >= 0 && value16 <= 19))
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
                                            Console.WriteLine("Please enter an integer between 0 and 19.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter an integer between 0 and 19.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please enter an integer between 0 and 19.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter an integer between 0 and 19.");
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 4.");
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


                if (Int32.TryParse(Console.ReadLine(), out int chosenShip2) && (chosenShip2 >= 1 && chosenShip2 <= 4))
                {
                    switch (chosenShip2)
                    {
                        case 1:
                            Console.WriteLine("Please enter the row of the front of the destroyer:");
                            if (Int32.TryParse(Console.ReadLine(), out int value1) && (value1 >= 0 && value1 <= 19))
                            {
                                Console.WriteLine("Please enter the column of the front of the destroyer:");
                                if (Int32.TryParse(Console.ReadLine(), out int value2) && (value2 >= 0 && value2 <= 19))
                                {
                                    Console.WriteLine("Please enter the row of the back of the destroyer:");
                                    if (Int32.TryParse(Console.ReadLine(), out int value3) && (value3 >= 0 && value3 <= 19))
                                    {
                                        Console.WriteLine("Please enter the column of the back of the destroyer:");
                                        if (Int32.TryParse(Console.ReadLine(), out int value4) && (value4 >= 0 && value4 <= 19))
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
                                            Console.WriteLine("Please enter an integer between 0 and 19.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter an integer between 0 and 19.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please enter an integer between 0 and 19.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter an integer between 0 and 19.");
                            }
                            break; //check that it's only exiting the switch statement
                        case 2://submarine logic
                            Console.WriteLine("Please enter the row of the front of the submarine:");
                            if (Int32.TryParse(Console.ReadLine(), out int value5) && (value5 >= 0 && value5 <= 19))
                            {
                                Console.WriteLine("Please enter the column of the front of the submarine:");
                                if (Int32.TryParse(Console.ReadLine(), out int value6) && (value6 >= 0 && value6 <= 19))
                                {
                                    Console.WriteLine("Please enter the row of the back of the submarine:");
                                    if (Int32.TryParse(Console.ReadLine(), out int value7) && (value7 >= 0 && value7 <= 19))
                                    {
                                        Console.WriteLine("Please enter the column of the back of the submarine:");
                                        if (Int32.TryParse(Console.ReadLine(), out int value8) && (value8 >= 0 && value8 <= 19))
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
                                            Console.WriteLine("Please enter an integer between 0 and 19.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter an integer between 0 and 19.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please enter an integer between 0 and 19.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter an integer between 0 and 19.");
                            }
                            break;
                        case 3://battleship logic
                            Console.WriteLine("Please enter the row of the front of the battleship:");
                            if (Int32.TryParse(Console.ReadLine(), out int value9) && (value9 >= 0 && value9 <= 19))
                            {
                                Console.WriteLine("Please enter the column of the front of the battleship:");
                                if (Int32.TryParse(Console.ReadLine(), out int value10) && (value10 >= 0 && value10 <= 19))
                                {
                                    Console.WriteLine("Please enter the row of the back of the battleship:");
                                    if (Int32.TryParse(Console.ReadLine(), out int value11) && (value11 >= 0 && value11 <= 19))
                                    {
                                        Console.WriteLine("Please enter the column of the back of the battleship:");
                                        if (Int32.TryParse(Console.ReadLine(), out int value12) && (value12 >= 0 && value12 <= 19))
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
                                            Console.WriteLine("Please enter an integer between 0 and 19.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter an integer between 0 and 19.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please enter an integer between 0 and 19.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter an integer between 0 and 19.");
                            }
                            break;
                        case 4://aircraft carrier logic
                            Console.WriteLine("Please enter the row of the front of the aircraft carrier:");
                            if (Int32.TryParse(Console.ReadLine(), out int value13) && (value13 >= 0 && value13 <= 19))
                            {
                                Console.WriteLine("Please enter the column of the front of the aircraft carrier:");
                                if (Int32.TryParse(Console.ReadLine(), out int value14) && (value14 >= 0 && value14 <= 19))
                                {
                                    Console.WriteLine("Please enter the row of the back of the aircraft carrier:");
                                    if (Int32.TryParse(Console.ReadLine(), out int value15) && (value15 >= 0 && value15 <= 19))
                                    {
                                        Console.WriteLine("Please enter the column of the back of the aircraft carrier:");
                                        if (Int32.TryParse(Console.ReadLine(), out int value16) && (value16 >= 0 && value16 <= 19))
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
                                            Console.WriteLine("Please enter an integer between 0 and 19.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please enter an integer between 0 and 19.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please enter an integer between 0 and 19.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter an integer between 0 and 19.");
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 4.");
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
                    if ((Int32.TryParse(Console.ReadLine(), out int attrow1)) && (attrow1 >= 0 && attrow1 <= 19))
                    {
                        Console.WriteLine("Please enter the column of your first attack:");
                        if ((Int32.TryParse(Console.ReadLine(), out int attcol1)) && (attcol1 >= 0 && attcol1 <= 19))
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
                            Console.WriteLine("Please enter an integer from 0 to 19.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter an integer from 0 to 19.");
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
                    if ((Int32.TryParse(Console.ReadLine(), out int attrow2)) && (attrow2 >= 0 && attrow2 <= 19))
                    {
                        Console.WriteLine("Please enter the column of your first attack:");
                        if ((Int32.TryParse(Console.ReadLine(), out int attcol2)) && (attcol2 >= 0 && attcol2 <= 19))
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
                            Console.WriteLine("Please enter an integer from 0 to 19.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter an integer from 0 to 19.");
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
