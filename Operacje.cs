using System;
using System.Collections.Generic;
using System.Text;

namespace TicTac
{
    class Operacje
    {
       
        public char KogoKolej(int i)
        {
            if (i % 2 == 0)
            {
                char pionek = 'X';
                return pionek;
            }
            else
            {
                char pionek = 'O';
                return pionek;
            }
        }

        public bool SprawdzenieWygranej(char[,] tablica, char pionek)
        {
            if (tablica[0, 0] == pionek && tablica[0, 2] == pionek && tablica[0, 4] == pionek) return true;
            else if (tablica[2, 0] == pionek && tablica[2, 2] == pionek && tablica[2, 4] == pionek) return true;
            else if (tablica[4, 0] == pionek && tablica[4, 2] == pionek && tablica[4, 4] == pionek) return true;

            else if (tablica[0, 0] == pionek && tablica[2, 0] == pionek && tablica[4, 0] == pionek) return true;
            else if (tablica[0, 2] == pionek && tablica[2, 2] == pionek && tablica[4, 2] == pionek) return true;
            else if (tablica[0, 4] == pionek && tablica[2, 4] == pionek && tablica[4, 4] == pionek) return true;


            else if (tablica[0, 0] == pionek && tablica[2, 2] == pionek && tablica[4, 4] == pionek) return true;
            else if (tablica[0, 4] == pionek && tablica[2, 2] == pionek && tablica[4, 0] == pionek) return true;
            else return false;

        }


        public void KomunikatWygranej(char znakPionka)
        {
            Console.WriteLine("\t Wygrał zawodnik:  {0}", znakPionka);
        }

    }
}
