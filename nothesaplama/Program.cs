using System;

namespace nothesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int[] yazili_notlari = {100,100,100};

            Console.WriteLine("1. Yazılı Notunuz: " + yazili_notlari[0]);
            Console.WriteLine("2. Yazılı Notunuz: " + yazili_notlari[1]);
            Console.WriteLine("3. Yazılı Notunuz: " + yazili_notlari[2]);


            int hesapla =(yazili_notlari[0] + yazili_notlari[1] + yazili_notlari[2]) /3 ;
            Console.WriteLine(hesapla);
        }
    }
}
