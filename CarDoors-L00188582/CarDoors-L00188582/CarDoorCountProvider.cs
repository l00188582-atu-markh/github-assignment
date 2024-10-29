using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDoors_L00188582
{
    public class CarDoorCountProvider
    {
        private int _numberOfDoors = 0;

        public int GetDoors()
        {
            return _numberOfDoors;
        }

        public void SetDoors(int quantityToSet)
        {
            _numberOfDoors = quantityToSet;
        }
    }
}
