using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Hutton_Riley
{
    /// <summary>
    /// implements the IAutomobile interface and has private setters
    /// </summary>
    class Sedan : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        //a constructor that takes a double parameter called speed and sets the wheels, speed, and plate #
        public Sedan(double speed)
        {
            Wheels = 4;
            Speed = speed;
            LicensePlate = "420-BLZ";
        }

        //prints the string to console
        public void Stringify()
        {
            Console.WriteLine($"The Sedan is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}.");
        }

        //Will increase/decrease the speed of the sedan by 5 when called
        public void IncreaseSpeed() {  Speed += 5;  }
        public void DecreaseSpeed() {  Speed -= 5;}
    }
}
