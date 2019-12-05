using System;

namespace TicTac
{
    class Program
    {
        static void Main()
        {
            Kratka krataGlowna = new Kratka();
            Operacje operacjaGlowna = new Operacje();
            bool czyWygrana;
            int iterator = 0;
            char wzorPionka;


            do
            {              
                Console.Clear();
                krataGlowna.NarysujKrate();
                wzorPionka = operacjaGlowna.KogoKolej(iterator);
                krataGlowna.DodajPionek(iterator, wzorPionka, krataGlowna.ZwrocKratke());
                czyWygrana = operacjaGlowna.SprawdzenieWygranej(krataGlowna.ZwrocKratke(), wzorPionka);
                iterator++;
            }
            while (czyWygrana == false);
            {
                Console.Clear();
                krataGlowna.NarysujKrate();
                operacjaGlowna.KomunikatWygranej(wzorPionka);
            }
                
            
            
        }
    }
}
