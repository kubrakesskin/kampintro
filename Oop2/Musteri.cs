using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    class Musteri
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string SirketAdi { get; set; }
        public string TcNo { get; set; } //toplama cıkarma gibi sayı görevi vermiyorsan metinsel tanımlamalısın
        //bu veri uyumlulugu acısından önemlidir.
        public string VergiNo { get; set; }

        //eğer bir nesnede bir değeri kullanmak zorunda değilsen, o nesneye göre gibi değilse alan hata yapıyorsundur
    }
}
