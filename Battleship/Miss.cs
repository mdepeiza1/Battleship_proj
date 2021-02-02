using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Miss : Attack
    {
        public Miss()
        {
            attackType = "M";
        }

        public Miss(int row, int column)
        {
            attackType = "M";
            this.row = row;
            this.column = column;
        }
    }
}
