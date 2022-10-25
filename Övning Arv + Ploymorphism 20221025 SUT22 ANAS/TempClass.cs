using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_Arv___Ploymorphism_20221025_SUT22_ANAS
{
    class TempClass
    {
        public double Temp;

        public virtual double Convert(double celsius)
        {

            return celsius + 273;

        }




    }
}
