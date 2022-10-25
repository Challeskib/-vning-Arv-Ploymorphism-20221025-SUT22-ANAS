using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_Arv___Ploymorphism_20221025_SUT22_ANAS
{
    class Fahrenheit : TempClass
    {

        
        public override double Convert(double celsius)
        {
            
            return (celsius * 9) / 5 + 32;
        }
    }
}
