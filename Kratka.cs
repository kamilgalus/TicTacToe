using System;
using System.Collections.Generic;
using System.Text;

namespace TicTac
{
    class Kratka
    {
        private char[,] kratka = new char[5,5];
        private char[,] kratkaPomocnicza = new char[5, 5];
        private Znak[] tablicaZnakow = new Znak[9];
        public Kratka()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(i%2==0)
                    {
                        if(j%2==0)
                        {                                                                                 
                            kratka[i, j] = ' ';
                        }
                        else
                        {
                            kratkaPomocnicza[i, j] = '|';
                            kratka[i, j] = '|';
                        }
                    }
                    else if(i%2==1)
                    {
                        kratkaPomocnicza[i, j] = '-';
                        kratka[i, j] = '-';
                    }
                }
            }

            kratkaPomocnicza[0,0]= '1';
            kratkaPomocnicza[0,2]= '2';
            kratkaPomocnicza[0,4]= '3';
            kratkaPomocnicza[2,0]= '4';
            kratkaPomocnicza[2,2]= '5';
            kratkaPomocnicza[2,4]= '6';
            kratkaPomocnicza[4,0]= '7';
            kratkaPomocnicza[4,2]= '8';
            kratkaPomocnicza[4,4]= '9';
        }


        public void NarysujKrate()
        {
            Console.WriteLine("\t\t\t\t  Plansza POMOCNICZA");        
            for (int i = 0; i < 5; i++)
            {
                Console.Write("\t\t");
                for (int j = 0; j < 5; j++)
                {                   
                    Console.Write(kratka[i,j]);                  
                }
                Console.Write("\t\t\t");               
                for (int k = 0; k < 5; k++)
                {
                    Console.Write(kratkaPomocnicza[i, k]);
                }
                Console.WriteLine();               
            }            
        }
     
        public char[,] ZwrocKratke()
        {
            return kratka;
        }



        public void WstawPionek(int miejsce, char pionek, char[,] kratka)
        {
            switch (miejsce)
            {
                case 1:
                    kratka[0, 0] = pionek;
                    break;
                case 2:
                    kratka[0, 2] = pionek;
                    break;
                case 3:
                    kratka[0, 4] = pionek;
                    break;
                case 4:
                    kratka[2, 0] = pionek;
                    break;
                case 5:
                    kratka[2, 2] = pionek;
                    break;
                case 6:
                    kratka[2, 4] = pionek;
                    break;
                case 7:
                    kratka[4, 0] = pionek;
                    break;
                case 8:
                    kratka[4, 2] = pionek;
                    break;
                case 9:
                    kratka[4, 4] = pionek;
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }




        public void DodajPionek(int nrPionka, char wzor , char[,] kratka)
        {
            int miejsce=0;
            bool czyZajete;

            tablicaZnakow[nrPionka] = new Znak();
            do
            {
                miejsce = tablicaZnakow[nrPionka].WybierzMiejsce(wzor);
                czyZajete = SprawdzenieWolnegoMiejsca(kratka, miejsce);
                if(czyZajete==false)
                {
                    Console.WriteLine("\t\tTo miejsce jest zajete");
                }
            }
            while (czyZajete == false);

                tablicaZnakow[nrPionka].NadajWzorPionka(wzor);
                WstawPionek(miejsce,wzor,kratka);                                                    
        }


        public bool SprawdzenieWolnegoMiejsca(char[,] krata, int miejsce)
        {
            if (miejsce == 1 && krata[0, 0] == ' ') return true;
            else if (miejsce == 2 && krata[0, 2] == ' ') return true;
            else if (miejsce == 3 && krata[0, 4] == ' ') return true;
            else if (miejsce == 4 && krata[2, 0] == ' ') return true;
            else if (miejsce == 5 && krata[2, 2] == ' ') return true;
            else if (miejsce == 6 && krata[2, 4] == ' ') return true;
            else if (miejsce == 7 && krata[4, 0] == ' ') return true;
            else if (miejsce == 8 && krata[4, 2] == ' ') return true;
            else if (miejsce == 9 && krata[4, 4] == ' ') return true;
            else
                return false;
        }

    }
}
