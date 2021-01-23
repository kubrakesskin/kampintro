using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    class TuzelMusteri:Musteri //bu olaya miras (inheratance) denir
        //tüzel müşteri, bir müşteridir demektir.
    {
      
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
