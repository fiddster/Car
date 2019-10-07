using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class TeslaModel3 : Car
    {
        public TeslaModel3(string registrationNumber) 
            : base("Tesla", "Model 3", registrationNumber)
        {
            
        }

        public override void Accelerate(int seconds)
        {
            Velocity = seconds * 3 * 3.6;

        }
    }
}
