using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out
{
    class Program
    {

        public static void CzasNaREF(ref int wynik)
        {
            wynik++;
        }

        public static void CzasNaOUT(out int wynik)
        {
            wynik = 12;//różnica między ref i out, tutaj musi być przypisanie wartości, w ref w środku funkcji może nie być
            wynik++;
        }

        /*public static void CzasNaOUT(out int wynik)//to jest źle napisany kod, brak inicializacji wyniku, jest tylko jego zwiększenie
        {
            wynik++;
        }*/

        static void Main(string[] args)
        {
          //  W skrócie Ref:
//    1.Przekazuje zmienną przez adres, a nie przez wartość .
//    2.Zmienna przekazana przez REF musi być już zainicjalizowana.

            //Z kolei out:
    //1.Tak samo jak ref, również przekazuje zmienną przez adres.
  // 2.Zmienna przekazana przez OUT nie musi być zainicjalizowana (aczkolwiek może).
   // 3.Zmienna przekazana przez OUT musi za to być zainicjalizowana w ciele metody.


            //ref i out
            int wynikREF = 5, wynikOUT;//różnica-out nie musi być zainicjalizowany przed wprowadzeniem do funkcji
            CzasNaREF(ref wynikREF);
            CzasNaOUT(out wynikOUT);
            Console.WriteLine(wynikREF);//musi być zainicjalizowana poza ciałem metody, w środku nie musi
            Console.WriteLine(wynikOUT);//inicjalizacja w ciele metody, poza nie musi
        }
    }
}
