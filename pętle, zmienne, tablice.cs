using System;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tworzymy potrzebne nam w programie zmienne:
            
            int mood; //Humor profesora, liczba całkowita

            double arithmeticMean; //Średnia arytmetyczna, typ double, ponieważ średnia może nie być liczbą całkowitą

            string name; // Nazwa studenta

            int sum = 0; // Suma punktów uzyskana przez studenta na wszystkich kolokwiach

            int[] grades = new int[10]; // Tworzymy tablicę typu int, ktora będzie przechowywała 10 zmiennych typu int
                                        // wg schematu typ[] nazwaTablicy = new typ[liczbaElmentów];
                                        // liczbaElementów może być liczbą wpisaną bepośrednio, albo 
                                        // możemy tam wpisać nazwę zmiennej o wcześniej określonej wartości
										
            Console.WriteLine("Dzień dobry wielmożny! Jak się Pan dzisiaj czuje? (1-10)"); //Wypisujemy komunikat na ekran

            mood = int.Parse(Console.ReadLine()); // Przypisujemy do zmiennej mood to, co wpisujemy na ekranie
                                                  // Ale onieważ zapisujemy to do typu int, a Console.ReadLine() zwraca nam typ string
                                                  // to musimy dokonać tzw. konwersji (parsowania) co wygląda tak: int.Parse(to co mamy skonwertować)

            while(false)
            {
                Console.WriteLine("Podaj studenta do odstrzału: ");
                name = Console.ReadLine();
                Console.WriteLine("Podaj oceny jakie uzyskał na kolokwiach (10 ocen):");

                for (int i = 0; i < 10; i++)
                {
                    grades[i] = int.Parse(Console.ReadLine());
                    sum += grades[i];
                }

                arithmeticMean = sum / 10.0;

                Console.Write("Oceny: ");

                foreach (int grade in grades)
                {
                    Console.Write(grade + " ");
                }
                Console.WriteLine("Średnia: {0}", arithmeticMean);
                if (arithmeticMean > 10)
                {
                    Console.WriteLine("Niestety, dany student zdaje, ale zawsze możesz "+
                        "próbować za rok!\nBTW Masz humor -1");

                    if (mood > 0)
                    {
                        mood--;
                    }

                }
                else
                {
                    if (mood > 5)
                    {
                        Console.WriteLine("Jest nadzieja, że student nie zda, "+
                            "ale pozwalamy mu poprawić");
                    }
                    else
                    {
                        Console.WriteLine("Fuck yeah! Mission accomplished\n"+
                            "Student {0} nie zdaje\nPoprawa humoru +1", name);
                        if (mood < 10)
                            mood++;
                    }
                }
                Console.WriteLine("Czy masz juz dość? T/N:");
                if (Console.ReadLine() == "T")
                    break;
            }

        }
    }
}
