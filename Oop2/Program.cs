using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.Id = 1;
            musteri1.TcNo = "12345";
            //musteri1.SirketAdi = "?"; olmadığı için musteri2 tanımladık

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "1234567890";
            musteri2.VergiNo = "1234567890";

            //SOLİD 

            //şimdi yeni bir müşteri oluşturalım

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            //görüldüğü gibi müşteri her ikisini de tutabiliyor.
            //bir yerde new varsa bu "bellekteki referans no'su" şeklinde okunur
            //o halde müşteri; hem gerçek müşterinin hem tüzel müşterinin referansını tutar.

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            //verilmek istenen mesaj referans tutuculara yöneliktir.
        }
    }
}
