using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) //buraya istedigimiz tür kredi yazabiliriz.
            //hesaplama sonunda hangi loglayıcı secilmisse onu logla dedik
        {
            //Başvuran bilgilerini değerlendirme
            //Bu algoritma içinde şimdi de kredi hesaplayalım
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            //Bu sekilde hesaplama yapar ama her sey sadece konutkredisi ile calısır.
            //Tüm başvuruları konutkredisine bagımlı hale getirmis olduk.
            //bunu önlemek icin ilk satırdaki basvuruyap() içini doldurduk :)
            krediManager.Hesapla(); //bu durumu önlemek icin bu sekilde yazdık ne gönderirsek o calısmıs olacak.
            //bu noktada programcs ye gidilir.  
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        //bana bir liste olustur bunun türü IkrediManager olsun

        {
            //aynı veri türünde veriyi taşıyabilecek veri grubu olusturmak icin: Liste kullanırız
            //tanımla ve program cs ye git
            foreach (var kredi in krediler)
            {
                kredi.Hesapla(); //listedeki her kredinin hesabını yap

            }
        }

    }
}
