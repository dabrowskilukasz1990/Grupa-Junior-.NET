using System;

namespace BubbleSort
{
    class Program
    {
        //wypełnianie tablicy losowymi warościami
        static void FillArray(int[] a)
        {
            Random randomizer = new Random();
            for(int i=0; i<a.Length; i++)
            {
                a[i] = randomizer.Next(1, 1000);
            }
        }
        //zamiana wartości zmiennych
        static void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        //wyświetlanie tablicy
        static void DisplayArray(int[] a)
        {
            for(int i=0; i<a.Length; i++)
            {
                Console.Write(a[i]+ " ");
            }
            Console.WriteLine();
        }
        //SORTOWANIE BĄBELKOWE (wyświetlanie krok po kroku zmian w tablicy [3 zakomentowane linie])
        static void BubbleSort(int[] a)
        {
            //int step = 1;
            int n = a.Length;
            do
            {
                for(int i=0; i < n-1; i++)
                {
                    if(a[i]>a[i+1])
                        Swap(ref a[i],ref a[i + 1]);
                }
                n--;
                //Console.Write("Krok "+(step++)+": ");
                //DisplayArray(a);
            }
            while (n > 1);
        }
        //przeszukiwanie binarne
        static int BinarySearch(int[] a, int element, int left, int right)
        {
            Console.WriteLine(left + " " + right);
            if (left > right) return -1;

            int middle = (left + right) / 2;

            if (a[middle] > element) return BinarySearch(a, element, left, middle - 1);
            if (a[middle] < element) return BinarySearch(a, element, middle + 1, right);

            return middle;
        }

        static void Main(string[] args)
        {
            Console.Write("Wpisz ilość elementów: ");
            int n = int.Parse(Console.ReadLine());
            int[] Array = new int[n];

            FillArray(Array);

            Console.WriteLine("Tablica przed sortowaniem: ");
            DisplayArray(Array);

            BubbleSort(Array);

            Console.WriteLine("Tablica po sortowaniu: ");
            DisplayArray(Array);

            Console.Write("Wpisz jakiego elementu mam szukać: ");
            int element = int.Parse(Console.ReadLine());

            Console.WriteLine("Szukany element znajduje się na indexie " +
                BinarySearch(Array, element, 0, Array.Length - 1));
        }
    }
}
