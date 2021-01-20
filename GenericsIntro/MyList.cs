using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro //hangi tip verirsen onunla çalışır.
{
    class MyList<T> //T verilen tipe karşılık gelir
        
    {
        T[] items; //Yukarıda t verdiğimiz için
        //direkt class içinde bütün operatörlere erisebilen bir dizi
       
        //ctor + çift tab. Classı bir yerde newlersen hemen başlangıçta çalışır

        public MyList()
        {
            items = new T[0];
        }

        //newlediğin andsa çalışan bloğa constructor denilir.

        public void Add(T item) //bunu hafızaya ekler ama nasıl kullanacak
            //biraz önce tanımladığımız list aslında bir arrayi yönetiyor.

        {
            T[] tempArray = items; //geçici dizinin referansı, itemsın referansı oldu. 
            items = new T[items.Length + 1]; //string listemin elemanlarını 1 arttırdım, dinamikleştirdim.
            //for + çift tab
            for (int i = 0; i < tempArray.Length; i++) 
            {
                //verilen geçici elemanları kendi üzerimize yeniden alıyoruz
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; //aslında eklenmek istenen eleman su an eklenebildi.
        }
    }
}
