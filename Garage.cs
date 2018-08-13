using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USFParking
{
    public class Garage
    {
        public string name;
        public int availableR;
        public int availableS;
        public int availableE;
        public int waitingCars;

        public Garage(string n, int r, int s, int e, int cars)
        {
            name = n;
            availableR = r;
            availableS = s;
            availableE = e;
            waitingCars = cars;
        }

        public int availableSpaces(string category)
        {
            if (category == "E")
            {
                return availableE + availableS;
            }
            else if (category == "R")
            {
                return availableR;
            }
            else if (category == "S")
            {
                return availableS;
            }
            return 0;
        }

        public void parkCar(string category)
        {
            if (category == "E")
            {
                if (availableE > 0)
                {
                    availableE--;
                    waitingCars--;
                }
            }
            else if (category == "S")
            {
                if (availableS > 0)
                {
                    availableS--;
                    waitingCars--;
                }
            }
            else if (category == "R")
            {
                if (availableR > 0)
                {
                    availableR--;
                    waitingCars--;
                }
            }
        }

        public void enterCar()
        {
            waitingCars++;
        }

        public void exitCar()
        {
            waitingCars--;
        }

        public void exitCarFromSpace(string category)
        {
            if (category == "R")
            {
                availableR++;
            }
            else if (category == "E")
            {
                availableE++;
            }
            else if (category == "S")
            {
                availableS++;
            }
        }
    }
}
