using System;

namespace TicTac
{
    class Program
    {
        static void Main()
        {
            Kratka k1 = new Kratka();
            Operacje op1 = new Operacje();
            bool czyWygrana;
            int iterator = 0;
            char wzorPionka;


            do
            {              
                Console.Clear();
                k1.NarysujKrate();
                wzorPionka = op1.KogoKolej(iterator);
                k1.DodajPionek(iterator, wzorPionka);
                czyWygrana = op1.SprawdzenieWygranej(k1.ZwrocKratke(), wzorPionka);
                iterator++;
            }
            while (czyWygrana == false);
            {
                Console.Clear();
                k1.NarysujKrate();
                op1.KomunikatWygranej(wzorPionka);
            }
                
            
            
        }
    }
}
