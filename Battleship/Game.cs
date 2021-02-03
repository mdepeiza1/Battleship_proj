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
            int val1;
            int val2;
            int val3;
            int val4;
            Console.WriteLine("Player 1 goes first");
            board.CreateBoard();
            Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Please enter front row of destroyer:");
                if (Int32.TryParse(Console.ReadLine(), out val1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter an integer.");
                }
            }
            while (true)
            {
                Console.WriteLine("Please enter front column of destroyer:");
                if (Int32.TryParse(Console.ReadLine(), out val2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter an integer.");
                }
            }
            while (true)
            {
                Console.WriteLine("Please enter back row of destroyer:");
                if (Int32.TryParse(Console.ReadLine(), out val3))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter an integer.");
                }
            }
            while (true)
            {
                Console.WriteLine("Please enter back column of destroyer:");
                if (Int32.TryParse(Console.ReadLine(), out val4))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter an integer.");
                }
            }
            board.player1.AddShips(val1, val2, val3, val4, 1);
            while (true)
            {
                Console.WriteLine("Please enter front row of submarine:");
                if (Int32.TryParse(Console.ReadLine(), out val1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter an integer.");
                }
            }
            while (true)
            {
                Console.WriteLine("Please enter front column of submarine:");
                if (Int32.TryParse(Console.ReadLine(), out val2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter an integer.");
                }
            }
            while (true)
            {
                Console.WriteLine("Please enter back row of submarine:");
                if (Int32.TryParse(Console.ReadLine(), out val3))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter an integer.");
                }
            }
            while (true)
            {
                Console.WriteLine("Please enter back column of submarine:");
                if (Int32.TryParse(Console.ReadLine(), out val4))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter an integer.");
                }
            }
            board.player1.AddShips(val1, val2, val3, val4, 2);
            board.UpdateBoard();
            Console.ReadLine();
        }
    }
}
