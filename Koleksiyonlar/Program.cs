using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir array oluşturalım
            //string[] isimler = new string[] {"Engin","Murat", "Kerem", "Halil"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
            //new yeni referans adı demek burada eleman verilmediği için
            //sadece 5 elemanlı boş bir alan oluştu.

            //list yaz bekle soldaki ampulden ilk secenege tıkla yukarıya ekleme yapacak sonra devam et
            //bir listeleye eleman eklemek için add kullanıyorduk. o halde:
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            //görüldüğü gibi liste yapıldığında da kayıp olmaz.

            isimler2.


        }
    }
}
