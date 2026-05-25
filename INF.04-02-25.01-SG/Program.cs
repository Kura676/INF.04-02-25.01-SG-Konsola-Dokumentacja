using System;

namespace Egzamin
{

    public class Program
    {

        static void Main()
        {

            Pralka pralka = new Pralka();
            Odkurzacz odkurzacz = new Odkurzacz();

            Console.WriteLine("Podaj nr prania 1..12");

            int nrPrania = Convert.ToInt32(Console.ReadLine());
            pralka.UstawNrPrania(nrPrania);

            odkurzacz.on();
            odkurzacz.on();
            odkurzacz.on();

            odkurzacz.wyswietlKomunikat("Odkurzacz wyladowal sie");

            odkurzacz.off();


        }


    }


}