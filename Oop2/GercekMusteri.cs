using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    class GercekMusteri:Musteri
    {
        public string TcNo { get; set; } //toplama cıkarma gibi sayı görevi vermiyorsan metinsel tanımlamalısın
        //bu veri uyumlulugu acısından önemlidir.
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
