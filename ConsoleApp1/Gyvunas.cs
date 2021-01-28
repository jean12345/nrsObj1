using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Gyvunas : Gyventojas, IKalbantis
    {
        
        public int Amzius { get; set; }
        public string Rusis { get; set; }
        
        public Gyvunas(int a, string r)
        {
            Amzius = a;
            Rusis = r;
        }

         public override string Kalbek()
         {
             return "Kalbu gyvuniskai";
         }    
        public string PasakykAmziuIrRusi()
        {
            return $"{Amzius} {Rusis}";
        }

        public string SysiokViesai()
        {
            return "Syst Syst :D.";
        }
    }

}
