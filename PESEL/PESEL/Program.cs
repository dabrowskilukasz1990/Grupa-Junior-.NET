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
            string nrPesel;

            int[] waga = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1 }; //10
            string[] pesel = new string[10];


            Console.WriteLine("Podaj PESEL");
            nrPesel = Convert.ToString(Console.Read());
            var chars = nrPesel.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars);
               
            }
            
            //for (long i = 0; i <= 10; i++)
            //{
            //    pesel[i] = Console.Read();
            //}

            Console.WriteLine(pesel[0]);
            Console.ReadLine();

            //String s = "AaBbCcDd";
            //var chars = s.ToCharArray();
            //Console.WriteLine("Original string: {0}", s);
            //Console.WriteLine("Character array:");
            //for (int ctr = 0; ctr < chars.Length; ctr++)
            //    Console.WriteLine("   {0}: {1}", ctr, chars[ctr]);
        }
    }
}
