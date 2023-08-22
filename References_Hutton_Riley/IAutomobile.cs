using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Hutton_Riley
{
    internal interface IAutomobile
    {
        //gets the speed 
        public double Speed { get; }

        //gets the number of wheels
        public int Wheels { get; }

        //gets the plate number
        public string LicensePlate { get; }

        //defines a method called stringify
        public void Stringify();

    }
}
