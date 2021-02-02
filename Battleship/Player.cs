using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Player
    {
        public List<Ship> fleet;
        public List<Attack> shots;
        public Player()
        {
            fleet = new List<Ship>();
            shots = new List<Attack>();
        }

        public void Attack(int row, int column, Player opponent)
        {
            for(int x = 0; x < opponent.fleet.Count; x++)
            {
                if (((row > opponent.fleet[x].frontRow && row < opponent.fleet[x].backRow) ||
                    (row > opponent.fleet[x].backRow && row < opponent.fleet[x].frontRow)) &&
                    ((column > opponent.fleet[x].frontColumn && column < opponent.fleet[x].backColumn) ||
                    (column > opponent.fleet[x].backColumn && row < opponent.fleet[x].frontColumn)))
                {
                    Attack hit = new Hit(row, column);
                    this.shots.Add(hit);
                }
            }
        }
    }
}
