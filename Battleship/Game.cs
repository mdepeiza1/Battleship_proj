using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Game
    {
        BattleshipBoard board;
        public Game()
        {
            board = new BattleshipBoard();
        }

        public void RunGame()
        {
            Console.WriteLine("Player 1 goes first");
            board.CreateBoard();
            Console.ReadLine();
            bool continuelooping = true;
            while (continuelooping)
            {

                Console.WriteLine("Please enter the number of the ship to place:");
                Console.WriteLine("1:Destroyer");
                Console.WriteLine("2:Submarine");
                Console.WriteLine("3:Battleship");
                Console.WriteLine("4:Aircraft Carrier");


                if (Int32.TryParse(Console.ReadLine(), out int chosenShip))
                {
                    switch (chosenShip)
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
                                            if(board.player1.fleet.Count == 4)
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
                                            if(board.player1.fleet.Count == 4)
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
                            Console.WriteLine("Please enter the row of the front of the destroyer:");
                            if (Int32.TryParse(Console.ReadLine(), out int value9))
                            {
                                Console.WriteLine("Please enter the column of the front of the destroyer:");
                                if (Int32.TryParse(Console.ReadLine(), out int value10))
                                {
                                    Console.WriteLine("Please enter the row of the back of the destroyer:");
                                    if (Int32.TryParse(Console.ReadLine(), out int value11))
                                    {
                                        Console.WriteLine("Please enter the column of the back of the destroyer:");
                                        if (Int32.TryParse(Console.ReadLine(), out int value12))
                                        {
                                            board.player1.AddShips(value9, value10, value11, value12, 3);
                                            if(board.player1.fleet.Count == 4)
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
                                            if(board.player1.fleet.Count == 4)
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
            Console.ReadLine();
        }
    }
}
