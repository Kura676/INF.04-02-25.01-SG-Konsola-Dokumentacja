using System;
using System.Collections.Generic;
using System.Text;

namespace Egzamin
{
    public  class Pralka : Urzadzenie
    {

        private int numerProgramu = 0;

        public int UstawNrPrania(int podanyNumerProgramu)
        {

            if(podanyNumerProgramu >= 1 && podanyNumerProgramu <= 12)
            {

                numerProgramu = podanyNumerProgramu;
                Console.WriteLine("Program zostal ustawiony");
                return podanyNumerProgramu;

            }

            Console.WriteLine("Podano niepoprawny numer programu");
            numerProgramu = podanyNumerProgramu;
            return 0;

        }
    }
}
