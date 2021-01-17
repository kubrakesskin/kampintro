using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //örneğin sepete ürün ekleme işlemi yapalım
        //python'da def ile yapılıyordu.

        //naming convention-isimlendirme kuralı
        public void Ekle(Urun urun) //normal parantez varsa metot çalışıyor
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi: + urunAdi");

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi : " + urunAdi);
        }
}
}
