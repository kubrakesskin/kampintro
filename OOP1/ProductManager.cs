using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    //içerisinde çeşitli operasyonlar barındırır.

    {
        public void Add(Product product) //ekleme operasyonu
        {
            //cw + çift tab
            Console.WriteLine(product.ProductName + "EKLENDİ");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "GÜNCELLENDİ");
        }
        //İŞLEMDE EKSTRA BİLGİYE İHTİYAÇ YOKSA VOİD
   
        
    }

}
