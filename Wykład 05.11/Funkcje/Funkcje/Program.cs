using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje
{
    class Program
    {
        //Program z funkcjami-ciało metody to jest miejsce od znacznika 'ciało' do znacznika 'koniec ciała',
        static int Fibonacci(int n)
        {//'ciało'
            if (n == 1)
                return 1;
            else if (n == 2)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            //'koniec ciała'
        }
        //czyli cały kod, który znajduje się wewnątrz nnaszej funkcji\metody(na chwilę obecną stosujemy zamiennie nazwy funkcja i metoda)
        static void ZajebistyNapis()
        {
            Console.WriteLine("Zajebisty Napis");//funkcja void nie zwraca żadnych wyników, czyli nie przypisuje żadnych wartości do zmiennych na zakończeniu, jedyne
            //co robi to wykonuje instrukcje zawarte w metodzie, czyli np tutaj wypisze coś na ekran
        }

        static int SilniaRekurencyjnie(int n)//jeśli uzywamy funkcji int to musimy na koniec dać polecenie "return jakaszmienna\wartosc;"-wtedy funkcja działa poprawnie i przypisze jakiś wynik do zmiennej
        {
            if (n < 1)
                return 1;
            else
            return n*SilniaRekurencyjnie(n-1);//program wykonując to mnożenie wywołuje tą samą funkcje, tylko, że z argumentem mniejszym o 1, aż nie dotrze do warunku, gdzie ma zwrócić coś innego, możecie spróbować pozmieniać wartości i zobaczyc co się stanie
        }

        static int SilniaIteracyjnie(int n)
        {
            int wynik = 1;
            for (int i = 1; i <= n; i++)
            {
                wynik = wynik * i;
            }
            return wynik;
        }
        static bool CzyBedeProgramowac()//funkcja bool może zwrócić tylko wartości:prawda lub fałsz
        {
            bool bede = true;
            return bede;
        }


       

        static void Main(string[] args)
        {

            //Program.ZajebistyNapis();<-na start

            int n;
            Console.WriteLine("Podaj liczbe do silni");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Rekurencja:{0}\nIteracja:{1}", SilniaRekurencyjnie(n), SilniaIteracyjnie(n));//sposob w jaki można wywołać utworzone przez nas metody liczące na dwa sposoby silnie
           


            int zmienna=Fibonacci(2);//sposob wywołania funkcji, kiedy chcemy jej wynik przypisać zmiennej, zamiast 2 można wstawiż zmienną
            Console.WriteLine(zmienna);

        }
    }
}
