using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            //classı kullanmak için bu şekilde yazdık.
            //Yani bir değişkeni bu şekilde tanımlayabilirsin.
            //şu an tipi kurs olan kurs1 isimli bir değişkenin oldu.
            //DEĞER OLUŞTURMAK İÇİN BUNU YAPIYORUZ.

            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            //bunları aşağıdaki tanımlamalardan sonra yazdık. 
            //DEĞER ATAMAK İÇİN BUNU YAPIYORUZ.


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            //ben buraya yeni kurs tanımlayıp listeye eklediğimde otomatik olarak her şeyi düzeltebiliriz. 
            //Listeye dokunmaya gerek kalmadan çıktıda yeni değişken görülebilir.



            //Bu sayede üç farklı kurs tanımlanmış oldu. Buradan önce tek string tanımlıyorduk ama burada class var birden çok özellik
            //tanımlamak gerekir. Gerçek hayatta e ticaret sisteminde de biz girip ürün listeliyoruz ve onlar da class. Yani aynısı :)
            //basit düşündüğümüzde her birisi bir değişkendir. 

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
            //direkt bu sekilde çalıştırdığımızda sadece engin demiroğ, c yazacaktı biraz önceki gibi yapmayı deneyelim yani dizide tanımlayalım

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };
            //yani içinde kurs nesnesini barındıran bir array tanımladık. eskiden string tutarken şimdi obje tutuyoruz.

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
            //çalıştırdığımızda kurs adlarını sırasıyla yazar. 




            //Console.WriteLine("Hello World!");
        }
    }
    //Düzenle ve classın yanına kurs yaz
    class Kurs
    {
        public string KursAdi { get; set; }
        //prop yaz çift taba bas düzenle
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

        //Şu an kurs içinde yukarı yazdığımız üç özellik mevcut oldu. Yani içinde birden fazla eleman içeriyor. 
        //Bunların arkaplanda nasıl tutulacagını diger ders görecegiz.
       
    }
}
