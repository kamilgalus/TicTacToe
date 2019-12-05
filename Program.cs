using System;

namespace TicTac
{
    class Program
    {
        static void Main()
        {
            Kratka krataGlowna = new Kratka();
            Operacje operacjeGlowne = new Operacje();
            bool czyWygrana;
            int iterator = 0;
            char wzorPionka;


            do
            {              
                Console.Clear();
                krataGlowna.NarysujKrate();
                wzorPionka = operacjeGlowne.KogoKolej(iterator);
                krataGlowna.DodajPionek(iterator, wzorPionka, krataGlowna.ZwrocKratke());
                czyWygrana = operacjeGlowne.SprawdzenieWygranej(krataGlowna.ZwrocKratke(), wzorPionka);
                iterator++;
            }
            while (czyWygrana == false);
            {
                Console.Clear();
                krataGlowna.NarysujKrate();
                operacjeGlowne.KomunikatWygranej(wzorPionka);
            }
                
            
            
        }
    }
}
