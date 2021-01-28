using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        //pirmasis metodas, paleidziamas programoje, priimantis masyva string tipo argumentu.
        //metodas statinis (t.y. jo nereikia inicializuoti)
        //metodas nieko negrazina nes yra void
        static void Main(string[] args)
        {
            //kintamieji (variables)
            int namas = 1;
            double kablelis = 1.2;
            bool tiesaMelas = false; //arba true
            string zodis = "ddddeee fff 23 fgg";

            //masyvas arba array - simbolis []
            int[] obuoliai = new int[3]; // [5, 6, 7]

            // [3] yra masyvo indeksas
            obuoliai[0] = 5;
            obuoliai[1] = 6;
            obuoliai[2] = 7;
            //obuoliai[3] = 5;
            //obuoliai[4] = 9;

            //ciklas for
            //i yra iteratorius
            for (int i = 0; i < obuoliai.Length; i++)
            {
                Console.WriteLine(obuoliai[i]);
            }


            List<int> slyvos = new List<int>();
            slyvos.Add(6);
            slyvos.Add(3);
            slyvos.Add(9);
            slyvos.Add(11);

            //isrusiavom for fun ;] 
            slyvos.Sort();

            for (int i = 0; i < slyvos.Count; i++)
            {
                Console.WriteLine(slyvos[i]);
            }

            //manoSaras yra sarasas objektu. Gyventojas yra klase.
            //sekancioj eiluteje mes turime sarasa Gyventojas objektu pavadinimu manoSarasas
            List<Gyventojas> manoSarasas = new List<Gyventojas>();
            //susikureme objekta g1, kurio tipas Gyventojas (klase Gyventojas)
            //1. budas. susikurem g1 objekta ir iskarto priskyrem jam savybes
            Gyventojas g1 = new Gyventojas()
            {
                ButoNr = 1,
                Vardas = "Jonas"
            };
            manoSarasas.Add(g1);
            //2. budas susikurem anonimini objekta, ji tiesiai idejom i sarasa
            manoSarasas.Add(new Gyventojas() { ButoNr = 2, Vardas = "Petras" });
            //3.sukurem objekta g3. veliau prikyrem jo savybes
            Gyventojas g3 = new Gyventojas();
            g3.ButoNr = 3;
            g3.Vardas = "Antanas";
            manoSarasas.Add(g3);
            //4. sukurem gyventoja su konstruktoriumi, kuriame yra parametru, irgi anoniminis
            manoSarasas.Add(new Gyventojas(4, "Mindaugas"));

            //klase yra brezinys o namas yra objektas :)
            //cia kuriam objekta
            Pastatas daugiabutis = new Pastatas(5, PastatuTipai.Blokinis, manoSarasas, StogoTipas.Slaitinis);

            int gyvSk = daugiabutis.GyventojuSkaicius();
            Enum pasTip = daugiabutis.PastatoTipas();
            Console.WriteLine($"Mes turim {gyvSk} gyventojus");
            Console.WriteLine($"Sis pastatas yra {pasTip}");

            List<Gyventojas> imigrantai = new List<Gyventojas>();
            //papildyti sarasa
            imigrantai.Add(new Gyventojas(5, "Armondas"));
            imigrantai.Add(new Gyventojas(7, "Taurintas"));
            imigrantai.Add(new Gyventojas(9, "Norbertas"));
            imigrantai.Add(new Gyventojas(3, "Dalius"));
            imigrantai.Add(new Gyventojas(4, "Ignotas"));
            Pastatas manoNamas = new Pastatas(7, PastatuTipai.Medinis, imigrantai, StogoTipas.Plokscias);

            //Console.WriteLine("{0} gyvena {1} bute.", imigrantai[0].Vardas, imigrantai[0].ButoNr);

            for (int i = 0; i < imigrantai.Count; i++)
            {
                Console.WriteLine($"{imigrantai[i].Vardas} {imigrantai[i].ButoNr}");
            }

            for (int i = 0; i < imigrantai.Count; i++)
            {
                imigrantai[i].Vardas += " Pavardenis";
                imigrantai[i].ButoNr = 4;
            }

            for (int i = 0; i < imigrantai.Count; i++)
            {
                Console.WriteLine($"{imigrantai[i].Vardas} {imigrantai[i].ButoNr}");
            }

            foreach (var item in imigrantai)
            {
                Console.WriteLine($"{item.Vardas} {item.ButoNr}");

            }

            List<Gyvunas> gyvunuSar = new List<Gyvunas>();
            gyvunuSar.Add(new Gyvunas(6, "suo"));
            gyvunuSar.Add(new Gyvunas(7, "kate"));
            gyvunuSar.Add(new Gyvunas(2, "eziukas"));

            List<Zmogus> zmoniuSar = new List<Zmogus>();
            zmoniuSar.Add(new Zmogus("Pavardenis", 33, "baltas"));
            zmoniuSar.Add(new Zmogus("Pavardenis2", 13, "juodas"));
            zmoniuSar.Add(new Zmogus("Pavardenis3", 63, "ryzas"));

            List<Gyventojas> gyventojuSar = new List<Gyventojas>();
            gyventojuSar.AddRange(gyvunuSar);
            gyventojuSar.AddRange(zmoniuSar);

            foreach (var item in gyventojuSar)
            {
                if (item is Gyvunas g)
                {
                    Console.WriteLine(g.SysiokViesai());
                    Console.WriteLine(g.PasakykAmziuIrRusi());
                }
                if (item is Zmogus z)
                {
                    Console.WriteLine(z.Rasyk());
                    Console.WriteLine(z.PasakykAmziuIrRusi());
                }
                Console.WriteLine(item.Kalbek());
            }

        }

    }


}
