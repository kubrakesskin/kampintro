using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //BU TİP CLASSLARDA SADECE ÖZELLİK OLUR
        //prop + çift tab
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int CategoryId { get; set; }
        public int UnitInStock { get; set; }
        //isimlendirmeler referans alanları olarak bilinir.

        
    }
}
