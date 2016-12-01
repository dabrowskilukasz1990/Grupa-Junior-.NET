using System;

public class Test
{
    public static void Main()
    {
        //Prosty kalkulator

        //deklarujemy dwie zmienne zmiennoprzecinkowe (czyli niecalkowite)
        double a, b;

        Console.WriteLine("Podaj liczbę a: ");
        //Przypisujemy zmiennej a to co wpisaliśmy w konsoli
        //Pamiętając o zamianie wpisanej wartości na typ double
        //za pomocą double.Parse();
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj liczbę b: ");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine("Wyniki: ");
        //Wypisujemy nasze obliczenia oraz ich wyniki
        //W miejsce {0} pojawi się pierwszy element, który jest po przecinku
        //W tym przypadku wynik obliczenia np. a + b itd.
        Console.WriteLine("A + B = {0}", a + b);
        Console.WriteLine("A - B = {0}", a - b);
        Console.WriteLine("A * B = {0}", a * b);

        //Jak wiadomo nie możemy dzielić przez 0, bo wtedy giną małe kotki
        //także musimy wprowadzić warunek b różne od 0
        if (b != 0)
        {
            Console.WriteLine("A / B = {0}", a / b);

            //Na koniec tzw. operacja modulo, która zwraca nam resztę z dzielenia liczby a przez b
            Console.WriteLine("A % B = {0}", a % b);

        }
        else//Jeżeli jednak b nie będzie różne od zera to wypisujemy coś takiego
        {
            Console.WriteLine("Nie dziel cholero przez zero");
        }


    }
}