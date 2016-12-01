using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pętle__tablice_i_randomy_z_ogrem
{
    class Program
    {
        static void Main(string[] args)
        {
            int wspolrzednaX, wspolrzednaY;//deklaracja współrzędnych
            Random generatorKrolikow = new Random();
            // Random jakasNazwa = new Random();
            //int naszaZmienna = jakasNazwa.Next(0,2) ->losuje nam liczby z zakresu 0-1

            Console.WriteLine("Podaj wielkosc krolikow po wspolrzednej X");//wypisanie na ekran
            wspolrzednaX = int.Parse(Console.ReadLine());//wczytywanie danych z konsoli
            Console.WriteLine("Podaj wielkosc krolikow po wspolrzednej Y");
            wspolrzednaY = int.Parse(Console.ReadLine());

            int[,] tablicaZPozycjaKrolikow = new int[wspolrzednaX,wspolrzednaY];//deklaracja tablicy dwuwymiarowej, ilość przecinków w nawiasie jest o jeden mniejsza od wymiaru

            for (int i = 0; i < wspolrzednaY; i++)
            {
                for (int j = 0; j < wspolrzednaX; j++)
                {
                    tablicaZPozycjaKrolikow[i,j]=generatorKrolikow.Next(0,2);//przypisujemy wartość danej pozycji w naszej tablicy
                    Console.Write(tablicaZPozycjaKrolikow[i, j]);//wypisanie wartości tablicy                    
                }
                Console.WriteLine("");//enter
            }
            Console.WriteLine("Podaj ile razy wielki Zły ogr uderza w króliki");
            int ileUderzen = int.Parse(Console.ReadLine());

            while (ileUderzen>0)//dopóki ileUderzeń jest większe od zera pętla będzie się wykonywać, pętla się wykonuje, dopóki warunek jest prawdziwy
            {
                Console.WriteLine("Podaj wspolrzedne X i Y celu");
                int uderzenieWX = int.Parse(Console.ReadLine());
                int uderzenieWY = int.Parse(Console.ReadLine());

                if (tablicaZPozycjaKrolikow[uderzenieWX, uderzenieWY] == 1)
                {
                    Console.WriteLine("BUMM!!Mamy punkt");
                    tablicaZPozycjaKrolikow[uderzenieWX, uderzenieWY] = 0;
                }
                else
                    Console.WriteLine("Pudło!!! Króliki się cieszą");
                ileUderzen--;//ileUderzeń zmniejszamy o 1
            }
        }
    }
}
