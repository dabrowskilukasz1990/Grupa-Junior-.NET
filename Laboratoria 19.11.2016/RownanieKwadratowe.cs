using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuadraticEquation
{
    class RownanieKwadratowe
    {
        static void Main(string[] args)
        {
            //Program obliczający równanie kwadratowe
            //Ax^2 + Bx + C = 0

            //Deklarujemy zmienne typu double (współczynniki i wynik nie muszą być liczbami całkowitymi)
            //dla współczynników a,b,c , delty, oraz wyników
            double a, b, c, delta, x1, x2;
            //Przypisujemy do zmiennych a,b,c to co wpiszemy w konsoli z klawiatury
            //ale musimy to zamienić na typ double przy pomocy double.Parse();
            Console.WriteLine("Podaj współczynnik A: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik B: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik C: ");
            c = double.Parse(Console.ReadLine());

            //Obliczamy deltę ze wzoru
            delta = (b * b) - (4 * a * c);

            //Rozpatrujemy pzrzypadki: delta<0, delta>0, delta=0
            if (delta < 0)
            {
                Console.WriteLine("Brak rozwiązań w liczbach rzeczywistych");
            }
            else if(delta > 0)  //To co jest po else(w tym przypadku następny if) wykona się tylko wtedy, jeżeli 
            {                   //nie zostanie spełniony warunek w poprzedzającym go if'ie
                                //(bo po co mamy sprawdzać czy delta > 0, skoro już ustaliliśmy że w danym przypadku jest mniejsza)

                //liczymy x1 i x2 ze wzorów (musimy pamiętać o kolejności wykonywania działań)
                // Math.Sqrt() zwraca na pierwiastek z liczby którą wpiszemy do nawiasu
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                //Wypisujemy wyniki na ekran:
                //W miejsce {0} wstawiana jest pierwsza "rzecz" po przecinku (czyli wartość x1)
                //W miejsce {1} wstawiana jest druga "rzecz" po przecinku (czyli wartość x2)
                //itd.
                Console.WriteLine("Rozwiązanie 1: {0} Rozwiązanie 2: {1}", x1, x2 );
            }
            else//Na koniec sytuacja kiedy delta==0, nie musimy pisać tutaj kolejnego if'a,
                //Ponieważ jeśli program dotarł tutaj, to znaczy, że delta nie była ani większa ani mniejsza od zera
                //czyli musiała by równa 0
            {
                //Wypisujemy wynik, dla odmiany nie zapisuemy go do żadnej zmiennej, tylko od razu wypisujemy na ekran
                Console.WriteLine("Rozwiązanie: {0}", (-b) / (2 * a));
            }

        }
    }
}
