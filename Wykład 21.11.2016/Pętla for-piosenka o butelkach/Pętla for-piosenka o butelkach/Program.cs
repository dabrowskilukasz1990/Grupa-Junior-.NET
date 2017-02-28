using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pętla_for_piosenka_o_butelkach
{
    class Program
    {
        static void Main(string[] args)
        {
            string naszaZmienna = "juice";
            for (int i=99 ; i>=0; i--)//pętla bdzie się wykonywała 100 razy
            {
                if (i != 0)//dopóki i nie jest równe zero
                    Console.WriteLine("{1} bottles of {0} on the wall, {1} bottles of {0}.\nTake one down and pass it around,{2} bottles of {0} on the wall.\n", naszaZmienna, i,i-1);// w miejsca {0}, {1},{2} wpisywane są zmienne, kolejno naszaZmienna,i,i-1
                else//jeżeli poprzedni warunek jest niespełniony wykonuje się linijka poniżej, a nie powyższa
                    Console.WriteLine("No more bottles of {0} on the wall, no more bottles of {0}.\nGo to the store and buy some more, 99 bottles of juice on the wall", naszaZmienna);
            }
        }
    }
}
