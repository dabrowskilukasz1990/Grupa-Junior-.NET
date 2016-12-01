using System;

namespace WielkiZłyOgr
{
    class Program
    {
        static void Main(string[] args)
        {
            Random skutekZjedzeniaKrolika = new Random();

            int wielkiZlyOgrZjadlKrolika=skutekZjedzeniaKrolika.Next(1,6);

            switch (wielkiZlyOgrZjadlKrolika)//switch przyjmuje jakąś wartość wielkiZły... a później w zależności jaka cyfra weszła, to wybiera odpowiedni warunek, czyli np dla 1 będzie "Królik był chory..."
            {
                case 1: Console.WriteLine("Królik był chory, więc ogr jest osłabiony"); break;
                case 2: Console.WriteLine("Królik był naspedowany, więc ogr jest super-silny!"); break;
                case 3: Console.WriteLine("Królik był zwykłym królikiem, nic się nie dzieje"); break;
                default: Console.WriteLine("Jakiś błąd");//w przypadku, gdy weszła wartość, która nie spełniła żadnego z poprzednich warunków to wykonuje się default,
                    break;//zawsze musi być na koniec polecenia, powoduje wyjście z obecnej pętli, warunku itp.
            }
        }
    }
}
