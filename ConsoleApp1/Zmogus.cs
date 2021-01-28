using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Zmogus : Gyventojas, IKalbantis
    {

        public string Pavarde { get; set; }


        public int Amzius { get; set; }
        public string Rusis { get; set; }

        public Zmogus(string p, int a, string r)
        {
            Pavarde = p;
            Amzius = a;
            Rusis = r;
        }

        public new string Kalbek()
        {
            return "Kalbu kaip zmogus";
        }
        public string PasakykAmziuIrRusi()
        {
            return $"{Amzius} {Rusis}";
        }

        public string Rasyk()
        {
            return "As moku rasyti.";
        }
    }

}
