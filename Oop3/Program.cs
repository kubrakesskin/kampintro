using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            //Çalıştır
            //Yani INTERFACELER DE REFERANS BİLGİSİ TUTAR.
            ILoggerService databaseLoggerService = new DatebaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);

            //basvuruManager.BasvuruYap(ihtiyacKrediManager); //yukarıda üç secenek tanımlamıstık 
            //çalıştırdığımızda "ihtiyaç kredisi ödeme planı hesaplandı" der neyi seçersek ona çıktı verir.
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            //ılogger icin önceki kodu kapattık ve yeni log kodu ekledik
        }
    }
}
