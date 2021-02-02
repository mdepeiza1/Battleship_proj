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
        }
    }
}
