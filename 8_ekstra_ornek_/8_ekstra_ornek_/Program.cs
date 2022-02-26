using System;

namespace _8_ekstra_ornek_
{
    class Program
    {
        static void Main(string[] args)
        {
            islem devlet1 = new islem();
            devlet1.Ad = "Türkiye";
            devlet1.Baskent = "Ankara";
            devlet1.ParaBirimi = "TL";
            devlet1.Nufus = 800000;
            devlet1.Yazdir();

            islem devlet2 = new islem();
            devlet2.Ad = "Almanya";
            devlet2.Baskent = "Berlin";
            devlet2.ParaBirimi = "Euro";
            devlet2.Nufus = 745000;
            devlet2.Yazdir();

            Console.ReadKey();
        }
    }
}
