using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Destroyer : Ship
    {
        
        public Destroyer()
        {
            length = 2;
            typeOfShip = "D";
        }

        public override void setFrontCoordinates(int row, int column)
        {
            frontRow = row;
            frontColumn = column;
        }

        public override void setBackCoordinates(int row, int column)
        {
            backRow = row;
            backColumn = column;
        }
    }
}
