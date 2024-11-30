using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDoors_L00188582
{
    public class TransmissionProvider
    {
        private string _transmission;

        public string GetTransmissionType()
        {
            return _transmission;
        }

        public void SetTransmissionType(string transmissionType)
        {
            _transmission = transmissionType;
        }
    }
}
