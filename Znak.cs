using System;
using System.Collections.Generic;
using System.Text;

namespace TicTac
{
    class Znak
    {
        private int miejsceZnaczka;
        private char pionek;

        public int WybierzMiejsce(char wzor)
        {
            Console.Write("\n"+"\tPodaj miejsce gdzie chcesz postawic {0} [1-9]:", wzor);
            miejsceZnaczka = int.Parse(Console.ReadLine());
            return miejsceZnaczka;
        }

        public void NadajWzorPionka(char wzor)
        {
            pionek = wzor;
        }
      
    }
}
