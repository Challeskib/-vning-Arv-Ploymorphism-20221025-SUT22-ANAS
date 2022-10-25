using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_Arv___Ploymorphism_20221025_SUT22_ANAS
{
    class Celsius : TempClass
    {

        public override double Convert(double fahrenheit)
        {
            
            
            return (fahrenheit - 32) * 5 / 9;
        }

    }
}
