using System;
using System.Collections.Generic;
using System.Linq;//Tutaj są podane wszystkie biblioteki, czyli paczki funkcji, które możemy użyć w programie, 
using System.Text;//jednymi z funkcji, które są zawarte w bibliotekach są Console.WriteLine(); i Console.Read();
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //program tworzymy w tym miejscu, pomiędzy tymi klamrami, reszta na razie może Was nie interesować, będzie o tym na zajęciach dotyczących
            //programowania obiektowego, które będą za około 2 tygodnie


            /*Inny typ komentarza
            nie trzeba kazdej lini oznaczać znakami '//'             
             */
            Console.WriteLine("Hello World!");//każdą instrukcję kończymy średnikiem, inaczej program wyrzuci błąd
            Console.Write("Hi    ");//ta funkcja wypisuje na ekran bez entera po wykonaniu
            
            Console.Read();//służy do zatrzymania wykonywania programu do naciśnięcia jakiegoś przycisku
        }
    }
}
