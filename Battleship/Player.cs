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
        bool destroyerIsChosen;
        bool submarineIsChosen;
        bool battleshipIsChosen;
        bool aircraftCarrierIsChosen;
        public Player()
        {
            fleet = new List<Ship>();
            shots = new List<Attack>();
            destroyerIsChosen = false;
            submarineIsChosen = false;
            battleshipIsChosen = false;
            aircraftCarrierIsChosen = false;
        }

        public void Attack(int row, int column, Player opponent)//add destroyed ship logic
        {
            bool missed = true;
            for (int x = 0; x < opponent.fleet.Count; x++)
            {
                if (((row >= opponent.fleet[x].frontRow && row <= opponent.fleet[x].backRow) ||
                    (row >= opponent.fleet[x].backRow && row <= opponent.fleet[x].frontRow)) &&
                    ((column >= opponent.fleet[x].frontColumn && column <= opponent.fleet[x].backColumn) ||
                    (column >= opponent.fleet[x].backColumn && row <= opponent.fleet[x].frontColumn)))
                {
                    Attack hit = new Hit(row, column);
                    this.shots.Add(hit);
                    missed = false;
                    break;
                }
                else
                {
                    missed = true;
                }
            }
            if (missed)
            {
                Attack miss = new Miss(row, column);
                this.shots.Add(miss);
            }
        }

        public void AddShips(int frontRow, int frontColumn, int backRow, int backColumn, int choiceOfShip)
        {
            string[,] establishedPositions = new string[20, 20];
            string[,] proposedPosition = new string[20, 20];
            bool isOverlapping = false;
            switch (choiceOfShip)
            {
                case 1:
                    if (!destroyerIsChosen)
                    {
                        if (frontRow == backRow || frontColumn == backColumn) //this is a check for correct placement / not diagonal
                        {
                            if ((frontRow == backRow) && (frontColumn + 1 == backColumn || backColumn + 1 == frontColumn)
                                || (frontColumn == backColumn) && (frontRow + 1 == backRow || backRow + 1 == frontRow)) // check for length
                            {
                                establishedPositions = GetPlacedShipPositions();//overlapping logic begins
                                proposedPosition = GetShipAboutToBePlacedsPosition(frontRow, frontColumn, backRow, backColumn);
                                for (int i = 0; i < 20; i++)
                                {
                                    for (int j = 0; j < 20; j++)
                                    {
                                        if ((establishedPositions[i, j] == proposedPosition[i, j]) && (establishedPositions[i, j] != null))
                                        {
                                            isOverlapping = true;
                                        }
                                    }
                                }//overlapping logic ends
                                if (!isOverlapping) //overlapping check
                                {
                                    Ship destroyer = new Destroyer();
                                    destroyer.frontRow = frontRow;
                                    destroyer.frontColumn = frontColumn;
                                    destroyer.backRow = backRow;
                                    destroyer.backColumn = backColumn;
                                    this.fleet.Add(destroyer);
                                    destroyerIsChosen = true;
                                }
                                else
                                {
                                    Console.WriteLine("The destroyer is overlapping.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("The destroyer is not the correct length.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The destroyer is diagonal.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The destroyer has already been chosen.");
                    }
                    break;
                case 2:
                    if (!submarineIsChosen)
                    {
                        if (frontRow == backRow || frontColumn == backColumn) //this is a check for correct placement / not diagonal
                        {
                            if ((frontRow == backRow) && (frontColumn + 2 == backColumn || backColumn + 2 == frontColumn)
                                || (frontColumn == backColumn) && (frontRow + 2 == backRow || backRow + 2 == frontRow))
                            {
                                establishedPositions = GetPlacedShipPositions();
                                proposedPosition = GetShipAboutToBePlacedsPosition(frontRow, frontColumn, backRow, backColumn);
                                for (int i = 0; i < 20; i++)
                                {
                                    for (int j = 0; j < 20; j++)
                                    {
                                        if ((establishedPositions[i, j] == proposedPosition[i, j]) && (establishedPositions[i, j] != null))
                                        {
                                            isOverlapping = true;
                                        }
                                    }
                                }
                                if (!isOverlapping)
                                {
                                    Ship submarine = new Submarine();
                                    submarine.frontRow = frontRow;
                                    submarine.frontColumn = frontColumn;
                                    submarine.backRow = backRow;
                                    submarine.backColumn = backColumn;
                                    this.fleet.Add(submarine);
                                    submarineIsChosen = true;
                                }
                                else
                                {
                                    Console.WriteLine("The submarine is overlapping.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("The submarine is not the correct length.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The submarine is diagonal.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The submarine has already been chosen.");
                    }
                    break;
                case 3:
                    if (!battleshipIsChosen)
                    {
                        if (frontRow == backRow || frontColumn == backColumn) //this is a check for correct placement / not diagonal
                        {
                            if ((frontRow == backRow) && (frontColumn + 3 == backColumn || backColumn + 3 == frontColumn)
                                || (frontColumn == backColumn) && (frontRow + 3 == backRow || backRow + 3 == frontRow))
                            {
                                establishedPositions = GetPlacedShipPositions();
                                proposedPosition = GetShipAboutToBePlacedsPosition(frontRow, frontColumn, backRow, backColumn);
                                for (int i = 0; i < 20; i++)
                                {
                                    for (int j = 0; j < 20; j++)
                                    {
                                        if ((establishedPositions[i, j] == proposedPosition[i, j]) && (establishedPositions[i, j] != null))
                                        {
                                            isOverlapping = true;
                                        }
                                    }
                                }
                                if (!isOverlapping)
                                {
                                    Ship battleship = new Battleship();
                                    battleship.frontRow = frontRow;
                                    battleship.frontColumn = frontColumn;
                                    battleship.backRow = backRow;
                                    battleship.backColumn = backColumn;
                                    this.fleet.Add(battleship);
                                    battleshipIsChosen = true;
                                }
                                else
                                {
                                    Console.WriteLine("The battleship is overlapping.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("The battleship is not the correct length.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The battleship is diagonal.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The battleship has already been chosen.");
                    }
                    break;
                case 4:
                    if (!aircraftCarrierIsChosen)
                    {
                        if (frontRow == backRow || frontColumn == backColumn) //this is a check for correct placement / not diagonal
                        {
                            if ((frontRow == backRow) && (frontColumn + 4 == backColumn || backColumn + 4 == frontColumn)
                                || (frontColumn == backColumn) && (frontRow + 4 == backRow || backRow + 4 == frontRow))
                            {
                                establishedPositions = GetPlacedShipPositions();
                                proposedPosition = GetShipAboutToBePlacedsPosition(frontRow, frontColumn, backRow, backColumn);
                                for (int i = 0; i < 20; i++)
                                {
                                    for (int j = 0; j < 20; j++)
                                    {
                                        if ((establishedPositions[i, j] == proposedPosition[i, j]) && (establishedPositions[i, j] != null))
                                        {
                                            isOverlapping = true;
                                        }
                                    }
                                }
                                if (!isOverlapping)
                                {
                                    Ship aircraftCarrier = new AircraftCarrier();
                                    aircraftCarrier.frontRow = frontRow;
                                    aircraftCarrier.frontColumn = frontColumn;
                                    aircraftCarrier.backRow = backRow;
                                    aircraftCarrier.backColumn = backColumn;
                                    this.fleet.Add(aircraftCarrier);
                                    aircraftCarrierIsChosen = true;
                                }
                                else
                                {
                                    Console.WriteLine("The aircraft carrier is overlapping.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("The aircraft carrier is not the correct length.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The aircraft carrier is diagonal.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The aircraft carrier has already been chosen.");
                    }
                    break;
                default:
                    Console.WriteLine("Error, please try again.");
                    break;
            }
        }
        private string[,] GetPlacedShipPositions()
        {
            string[,] positions = new string[20, 20];
            for (int i = 0; i < this.fleet.Count; i++)//overlapping logic
            {
                if (this.fleet[i].frontRow == this.fleet[i].backRow)
                {
                    if (this.fleet[i].frontColumn > this.fleet[i].backColumn)
                    {
                        for (int j = this.fleet[i].backColumn; j <= this.fleet[i].frontColumn; j++)
                        {
                            positions[this.fleet[i].frontRow, j] = "T";//for taken
                        }
                    }
                    else if (this.fleet[i].frontColumn < this.fleet[i].backColumn)
                    {
                        for (int j = this.fleet[i].frontColumn; j <= this.fleet[i].backColumn; j++)
                        {
                            positions[this.fleet[i].frontRow, j] = "T";
                        }
                    }
                }
                else
                {
                    if (this.fleet[i].frontRow > this.fleet[i].backRow)
                    {
                        for (int j = this.fleet[i].backRow; j <= this.fleet[i].frontRow; j++)
                        {
                            positions[j, this.fleet[i].frontColumn] = "T";
                        }
                    }
                    else if (this.fleet[i].frontRow < this.fleet[i].backRow)
                    {
                        for (int j = this.fleet[i].frontRow; j <= this.fleet[i].backRow; j++)
                        {
                            positions[j, this.fleet[i].frontColumn] = "T";
                        }
                    }
                }
            }//overlapping logic
            return positions;
        }
        private string[,] GetShipAboutToBePlacedsPosition(int frontRow, int frontColumn, int backRow, int backColumn)
        {
            string[,] positions = new string[20, 20];

            if (frontRow == backRow)
            {
                if (frontColumn > backColumn)
                {
                    for (int j = backColumn; j <= frontColumn; j++)
                    {
                        positions[frontRow, j] = "T";
                    }
                }
                else if (frontColumn < backColumn)
                {
                    for (int j = frontColumn; j <= backColumn; j++)
                    {
                        positions[frontRow, j] = "T";
                    }
                }
            }
            else
            {
                if (frontRow > backRow)
                {
                    for (int j = backRow; j <= frontRow; j++)
                    {
                        positions[j, frontColumn] = "T";
                    }
                }
                else if (frontRow < backRow)
                {
                    for (int j = frontRow; j <= backRow; j++)
                    {
                        positions[j, frontColumn] = "T";
                    }
                }
            }

            return positions;
        }
    }
}
