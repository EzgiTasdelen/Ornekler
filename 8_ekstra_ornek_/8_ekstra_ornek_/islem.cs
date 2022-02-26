using System;
using System.Collections.Generic;
using System.Text;

namespace _8_ekstra_ornek_
{
    class islem
    {
        string ad;

        public string Ad
        {
           get { return ad; }
            set { ad = value; }
        }
        string baskent;

        public string Baskent
        {
            get { return baskent; }
            set { baskent = value; }
        }

        int nufus = 1500;

        public int Nufus
        {
            get { return nufus; }
            set { nufus = value; }
        }

        string paraBirimi;

        public string ParaBirimi
        {
            get { return paraBirimi; }
            set { paraBirimi = value; }
        }

        public void Yazdir()
        {
            Console.WriteLine("Ülke Adı      :" + ad);

            Console.WriteLine("Başkenti      :" + baskent);

            Console.WriteLine("Nüfusu        :" + nufus);

            Console.WriteLine("Para Birimi   :" + paraBirimi);

            Console.WriteLine("==========================================");


        }
    }
}
