using System;
using System.Collections;

namespace Stos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack BookStack = new Stack();
            
            while(true)
            {
                Console.Write("Co chcesz zrobić?\n1.Dodać książkę,\n2.Usunąć książkę\n3.Wyświetlić stos książek\n");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("Podaj tytuł książki:");
                        string title = Console.ReadLine();
                        BookStack.Push(title);
                        break;

                    case 2:
                        if(BookStack.Count > 0)
                            BookStack.Pop();
                        break;

                    case 3:
                        foreach (string tytul in BookStack)
                        {
                            Console.WriteLine(tytul);
                        }
                        Console.ReadLine();
                        break;

                    default:
                        break;
                }
                Console.Clear();
            }
        }
    }
}
