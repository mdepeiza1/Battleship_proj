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
            switch (choiceOfShip)// add check for overlapping
            {
                case 1:
                    if (!destroyerIsChosen) 
                    {
                        if (frontRow == backRow || frontColumn == backColumn) //this is a check for correct placement / not diagonal
                        {
                            if ((frontRow == backRow) && (frontColumn + 1 == backColumn || backColumn + 1 == frontColumn)
                                || (frontColumn == backColumn) && (frontRow + 1 == backRow || backRow + 1 == frontRow)) // check for length
                            {
                                Ship destroyer = new Destroyer();
                                destroyer.frontRow = frontRow;
                                destroyer.frontColumn = frontColumn;
                                destroyer.backRow = backRow;
                                destroyer.backColumn = backColumn;
                                destroyerIsChosen = true;
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
                                Ship submarine = new Submarine();
                                submarine.frontRow = frontRow;
                                submarine.frontColumn = frontColumn;
                                submarine.backRow = backRow;
                                submarine.backColumn = backColumn;
                                submarineIsChosen = true;
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
                                Ship battleship = new Battleship();
                                battleship.frontRow = frontRow;
                                battleship.frontColumn = frontColumn;
                                battleship.backRow = backRow;
                                battleship.backColumn = backColumn;
                                battleshipIsChosen = true;
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
                                Ship aircraftCarrier = new AircraftCarrier();
                                aircraftCarrier.frontRow = frontRow;
                                aircraftCarrier.frontColumn = frontColumn;
                                aircraftCarrier.backRow = backRow;
                                aircraftCarrier.backColumn = backColumn;
                                aircraftCarrierIsChosen = true;
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
    }
}
