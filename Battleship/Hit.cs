using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Hit : Attack
    {
        public Hit()
        {
            attackType = "H";
        }

        public Hit(int row, int column)
        {
            attackType = "H";
            this.row = row;
            this.column = column;
        }
    }
}
