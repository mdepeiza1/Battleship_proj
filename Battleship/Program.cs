using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            BattleshipBoard board = new BattleshipBoard();
            Console.WriteLine("Player 1 goes first");
            board.CreateBoard();
            Console.ReadLine();
        }
    }
}
