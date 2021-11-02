using System;
using System.Collections.Generic;
using System.Text;

namespace Auto_IT3B
{
    class Auto
    {
        private int naklad;
     
        public int Naklad { get => naklad; }
        public string Znacka { get; }
        public int Nosnost { get; }

        public Auto(string znacka, int nosnost)
        {
            Znacka = znacka;
            Nosnost = nosnost;
        }

        public int Nalozit(int naklad)
        { // zjistí se, kolik tam je místa, když by nebylo dostatek místa a hrozilo přeložení, tak se naloží do plna s tím, že zbyek se nenaloží!
            var misto = Nosnost - Naklad;
            if(misto < naklad)
            {
                //throw new Exception("Náklad přesahuje nosnost.")     Jiný zápis 
                this.naklad += misto;
                return misto;
            }
            else
            { 
            this.naklad += naklad;
                return naklad;
            }
        }

        public int Vylozit(int naklad)
        {
            if (Naklad < naklad)
            {
                var vylozeni = Naklad;
                this.naklad = 0;
                return vylozeni;
            }
            else
            {
                this.naklad -= naklad;
                return naklad;
            }
        }

        public int Zaparkovat()
        {
            var vylozeni = Naklad;
            this.naklad = 0;
            return vylozeni;
        }

    }
}
