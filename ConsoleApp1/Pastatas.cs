using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    enum PastatuTipai
    {
        Plytinis,
        Blokinis,
        Medinis,
        Misrus
    }

    enum StogoTipas
    {
        Plokscias,
        Slaitinis,
        Vienslaitis,
        Sutapdintas
    }

    class Pastatas //cia brezinys
    {
        //properties
        private int aukstuSkaicius { get; set; }
        private Enum pastatoTipas { get; set; }
        private List<Gyventojas> pastatoGyventojai { get; set; }
        private Enum koksStogas { get; set; }

        //konstruktorius
        public Pastatas(int aukst, Enum pastTip, List<Gyventojas> gyv, Enum stogas)
        {
            aukstuSkaicius = aukst;
            pastatoTipas = pastTip;
            pastatoGyventojai = gyv;
            koksStogas = stogas;
        }

        //metodas (funkcija) garzinanti gyventoju skaiciu
        public int GyventojuSkaicius()
        {
            int gyvSk = pastatoGyventojai.Count;
            return gyvSk;
        }
        public Enum PastatoTipas()
        {
            return pastatoTipas;
        }
    }
}
