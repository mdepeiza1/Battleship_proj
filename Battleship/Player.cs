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

        public void Attack(int row, int column, Player opponent)
        {
            bool missed = true;
            for(int x = 0; x < opponent.fleet.Count; x++)
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
            switch (choiceOfShip)
            {
                case 1:
                    if (!destroyerIsChosen) // add a check for length as well / check for correct placement / check for overlapping
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
                        Console.WriteLine("The destroyer has already been chosen.");
                    }
                    break;
                case 2:
                    if (!submarineIsChosen)
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
                        Console.WriteLine("The submarine has already been chosen.");
                    }
                    break;
                case 3:
                    if (!battleshipIsChosen)
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
                        Console.WriteLine("The battleship has already been chosen.");
                    }
                    break;
                case 4:
                    if (!aircraftCarrierIsChosen)
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
