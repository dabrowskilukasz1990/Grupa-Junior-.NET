using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PESEL
{
    class Program
    {
        static void Main(string[] args)
        {
            //90072104496
            int nrPesel;

            int[] waga = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1 }; //10
            int[] pesel = new int[10];


            Console.WriteLine("Podaj PESEL");
            nrPesel = Console.Read();

            for (int i = 0; i <= 10; i++)
            {
                pesel[i] = int.Parse(Console.ReadLine());
            }
           
            Console.WriteLine(pesel[0]*waga[0]);
            Console.ReadLine();

        }
        public int Mnoznik()
        {
            return;
        }
    }
}
