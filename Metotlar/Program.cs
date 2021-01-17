using System;

namespace Metotlar
{
    public class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double fiyati = 5;
            string aciklama = "Amasya Elması";

            string urunAdi2 = "Çilek";
            double fiyati2 = 10;
            string aciklama2 = "Çilek gibi çilek";




            string[] meyveler = new string[] { };

            Urun urun1 = new Urun(); //class oldugunda newlemek şarttır.
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";
            //yukarıda da tanımlamıştık ama açıklamak güçtü
            //bunu daha düzenli ve ilişkili yazdık.

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            //classlar ile düzene sokmuş olduk.

            Urun[] urunler = new Urun[] {urun1,urun2};
            //urun arrayi ekledik (array; istenildigi kadar veriyi tutan yapı.)

            //foreach yaz çift tab'a bas

            foreach (var urun in urunler)
            //in urunler dediğimizde ürünler isimli diziyi tek tek gez
            //süslü parantez içi ürün sayısı kadar döner mesela burada iki
            ////Urun urun kısmı ise isimlendirmedir. Soldaki veri tipidir. 
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------");
                //metotlara sağ tıkla set as Startup Project'e tıkla çalıştır. 
            }

            Console.WriteLine("-----Metotlar------");

            //instance-örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu",12, 8);
            
        }
    }
}
