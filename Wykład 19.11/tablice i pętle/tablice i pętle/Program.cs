using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAB
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program wypisujący elementy tablicy po kolei i od tyłu            


            //Tworzymy tablicę typu string (zmienna z jakimś tekstem) o nazwie tablica o 5 elementach
            string[] tablica = new string[5];

            //Pętle będziemy jeszcze omawiać dokładniej na wykładzie w poniedziałek 21.11
            //Na chwilę obecną musicie wiedzić tylko, że poniższa pętla for robi to samo co:
            //tablica[0] = "";
            //tablica[1] = Console.ReadLine());
            //tablica[2] = Console.ReadLine());
            //tablica[3] = Console.ReadLine());
            //tablica[4] = Console.ReadLine());

            //zmienna i na początku jest równa 0 (int i = 0) rośnie przy każdym przejściu pętli o 1 (i++)
            //pętla kończy się wykonywać, gdy i osiągnie wartość 5 (warunek i<5) (bo 5<5 jest fałszem)
            for (int i = 0; i < 5; i++)
            {
                //Kod w tym miejscu wykona się 5 razy
                //Przypisujemy do i-tego elementu tablicy to co wpiszemy z klawiatury
                tablica[i] = Console.ReadLine();

            }
            //Wypisujemy komunikat "Zawartość Tablicy: 
            Console.WriteLine("Zawartość Tablicy: ");

            //W pętli wypisujemy elementy tablicy w jednej linijce po spacjach
            //Działanie analogiczne do pierwszej pętli, tyle że zamiast wczytywania mamy wypisywanie
            for (int i = 0; i < 5; i++)
            {
                //Wypisujemy zawartość i-tego elementu tablicy
                Console.WriteLine(tablica[i]);
            }

            Console.WriteLine("Zawartość tablicy odwrotnie: ");
            //Tu dla odmiany wypisujemy elementy tablicy od końca
            //i jest równa 4 oraz zmniejsza się o 1 (i--)
            //aż do czasu kiedy będzie równa -1 (-1>=0 jest fałszem)
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(tablica[i]);
            }

        }
    }
}
