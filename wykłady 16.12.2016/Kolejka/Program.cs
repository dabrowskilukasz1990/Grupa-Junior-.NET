using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;

namespace Kolejka
{
    class Program
    {
        static void SetNames(ref List<string> imiona)
        {
            imiona.Add("Tomek");
            imiona.Add("Mikołaj");
            imiona.Add("Michał");
            imiona.Add("Andrzej");
            imiona.Add("Janusz");
            imiona.Add("Paweł");
            imiona.Add("Eustachy");
            imiona.Add("Adolf");
            imiona.Add("Kasia");
            imiona.Add("Wiktoria");
            imiona.Add("Aleksandra");
            imiona.Add("Vladimir");
            imiona.Add("Putout");
            imiona.Add("Jan");
            imiona.Add("Paweł Drugi");
        }

        static void Main(string[] args)
        {
            List<string> imiona = new List<string>();
            Queue Kolejka = new Queue();
            Random rnd = new Random();
            SetNames(ref imiona);
            while (true)
            {
                int a = rnd.Next(0, 2);
                if(a == 0)
                {
                    if(Kolejka.Count > 0)
                        Kolejka.Dequeue();
                }
                else
                    Kolejka.Enqueue(imiona[rnd.Next(0, imiona.Count)]);
                foreach (string imie in Kolejka)
                {
                    Console.WriteLine(imie);
                }
                Thread.Sleep(2000); //korzysta z System.Threading, tutaj: usypia program na 2000 milisekund
                Console.Clear();
            }
        }
    }
}
