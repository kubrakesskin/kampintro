using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            //tür belirtmemiz gerekiyor. Burada string belirlediğimiz için bu türde bir liste oldu
            isimler.Add("Engin");

            Console.WriteLine("Hello World!");
        }
    }
}
