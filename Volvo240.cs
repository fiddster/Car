using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class Volvo240 : Car
    {
        public Volvo240(string registrationNumber) 
            :base("Volvo", "240", registrationNumber)
        {

        }

        public override void Accelerate(int seconds)
        {
            Velocity = seconds * 2 * 3.6;
        }
    }
}
