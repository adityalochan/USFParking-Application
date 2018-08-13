using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USFParking
{
    class ParkingSpace
    {
        string category;
        bool empty;
        double price;

        public ParkingSpace(string c)
        {
            if (c.ToUpper() == "R" || c.ToUpper() == "S" || c.ToUpper() == "E")
                category = c;
            else
            {
                category = "NA";
                price = 0.5;
            }

            empty = true;
        }

        public ParkingSpace(string c, bool e)
        {
            if (c.ToUpper() == "R" || c.ToUpper() == "S" || c.ToUpper() == "E")
                category = c;
            else
            {
                category = "NA";
                price = 0.5;
            }

            empty = e;
        }

        public ParkingSpace(double p, bool e)
        {
            category = "NA";
            price = p;
            empty = e;
        }

        public ParkingSpace(double p)
        {
            category = "NA";
            price = p;
            empty = true;
        }

        public bool availableFree(string c)
        {
            if (!empty || c == "NA" || category == "NA" || (category != c && c != "E") || (category == "R" && c == "E"))
            {
                return false;
            }
            return true;
            
        }

        public double getPrice()
        {
            if (!empty || category != "NA")
                return 100000;
            return price;
        }




    }
}
