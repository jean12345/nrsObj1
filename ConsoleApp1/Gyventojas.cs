using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Gyventojas
    {
        public int ButoNr { get; set; }
        public string Vardas {get; set;}
        

        public Gyventojas()
        {

        }

        public virtual string Kalbek()
        {
            return "Kalba gyventojas";
        }

        public Gyventojas(int butNr, string vard)
        {
            ButoNr = butNr;
            Vardas = vard;
        }
    }



}
