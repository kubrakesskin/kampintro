using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class TasitKrediManager : IKrediManager
    //ÖNCE I EKLE, YAZDIKTAN SONRA SOLDAKİ AMPULDEN IMPLEMENT INTERFACE İ SEC
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
        }
    }
}
