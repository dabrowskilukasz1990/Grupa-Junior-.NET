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

            int[] waga = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1 }; //10
            string nrPesel;
            

            Console.WriteLine("Podaj PESEL");
            nrPesel = Console.ReadLine();
            
            string chars = nrPesel.ToCharArray();
            

            for (int i = 0; i <= 10; i++)
            {
                int suma = waga[i] * chars[i];
                Console.WriteLine(suma);
            }
           

            
            Console.ReadLine();
       }
    }
}
