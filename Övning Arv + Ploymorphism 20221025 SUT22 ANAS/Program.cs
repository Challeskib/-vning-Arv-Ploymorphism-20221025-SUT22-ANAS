using System;

namespace Övning_Arv___Ploymorphism_20221025_SUT22_ANAS
{
    class Program
    {
        static void Main(string[] args)
        {

            TempClass newCalc0 = new TempClass();

            

            Console.WriteLine(newCalc0.Convert(0));
            
            Fahrenheit newCalc = new Fahrenheit();

            Console.WriteLine(newCalc.Convert(0));

            Celsius newCalc1 = new Celsius();

            Console.WriteLine(newCalc1.Convert(32));


        }
    }
}
