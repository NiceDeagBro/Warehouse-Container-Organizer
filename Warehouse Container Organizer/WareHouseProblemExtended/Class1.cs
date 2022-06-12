using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseProblemExtended
{
    class Boxes
    {
        private int type;     // Type of a box
        private int volume;   // Volume of a box
        private int rows;     // Volume of a box
        private int rowSize;  // Volume of a box

        public Boxes(int type)
        {
            this.type = type;
            switch (type)
            {
                case 1:
                    volume = 1;             //volume is equal to 1 since Type 1 container is 1x1x1 meters in size
                    rows = 17;              //amount of rows that will fit in a warehouse leaving the required space between them
                    rowSize = 50 * 6;       
                    break;
                case 2:
                    volume = 4;             //volume is equal to 4 since Type 2 container is 2x2x1 meters in size
                    rows = 13;              //amount of rows that will fit in a warehouse leaving the required space between them
                    rowSize = 50 * 2 * 6;
                    break;
                case 3:
                    volume = 8;             //volume is equal to 8 since Type 3 container is 2x2x2 meters in size
                    rows = 13;              //amount of rows that will fit in a warehouse leaving the required space between them
                    rowSize = 50 * 2 * 6;   //warehouse width * container's height * height of warehouse / 2
                    break;
            }

        }

        public int warehouseVolume()
        {
            return rows * rowSize;
        }


        public double addBoxes(int containerAmount)
        {
            double freeSpace = this.warehouseVolume() - this.volume * containerAmount;
            return freeSpace;
        }

        public double removeBoxes(int freeSpace, int containerAmount)
        {
            double freeSpaceLeft = freeSpace + this.volume * containerAmount;
            return freeSpaceLeft;
        }
    }
}
