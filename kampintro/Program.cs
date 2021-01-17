using System;

namespace kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği 
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolanBugun = 7.45;

            //if yaz çift tab'a bas
            if (dolarDun>dolanBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolanBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            //şart geçerliyse aşağıdaki aralık çalışsın
            //if yaz çift tab'a bas

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }

            //sisteme ya giriş yapmıştır ya da yapmamıştır o zaman da else
            //else yaz çift tab'a bas.
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            
            //çalıştır.
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
