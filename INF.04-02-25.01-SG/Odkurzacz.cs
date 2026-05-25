using System;
using System.Collections.Generic;
using System.Text;

namespace Egzamin
{
     public class Odkurzacz : Urzadzenie
    {

        private bool stanOdkurzacza = false;



        public void on()
        {
            if (!stanOdkurzacza)
            {
                stanOdkurzacza = true;
                wyswietlKomunikat("Odkurzacz wlaczono");
            }
            
        }

        public void off()
        {
            if (stanOdkurzacza)
            {
                stanOdkurzacza = false;
                wyswietlKomunikat("Odkurzacz wylaczono");
            }

        }


    }
}
