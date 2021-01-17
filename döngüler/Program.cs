using System;

namespace döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";

            //array-dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" ,
                "Programlamaya Başlangıç İçin Temel Kurs" ,
                "Java" };

            //normal şartlarda array'den yararlanmasaydık her yeni eklenen işlemde bütün kodları tekrar yazacaktık
            //bunu ortadan kaldırmak icin elimizdeki veriyi döndürerek işlem yapıyoruz
            //döngüler; eldeki verinin dönmesi için kullanılır.


            for (int i = 0; i<kurslar.Length; i++)
            //burada dinanizm sağlanmış olur.
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti");


            //farklı bir döngü yöntemi: for yaz kendini foreache getir çift taba bas
            //düzenleme yap
            //dizi temelli yapıları tek tek dönmeye yarar. 
            //in kurslar; kursları tek tek dolaş. Burada kurs dediğimiz takma isimdir.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            //for geniş dolaşım içindir foreach kısayol içindir. 

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
