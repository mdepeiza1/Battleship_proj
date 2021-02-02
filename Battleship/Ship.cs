using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    abstract class Ship
    {
        public int length;
        public int frontRow;
        public int frontColumn;
        public int backRow;
        public int backColumn;
        public string typeOfShip;

        public abstract void setFrontCoordinates(int row, int column);
        public abstract void setBackCoordinates(int row, int column);
    }
}
