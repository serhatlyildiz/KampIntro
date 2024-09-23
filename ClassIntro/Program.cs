using System;

namespace ClassIntro
{
    class Stajyer
    {
        public string sAdi { get; set; }
        public string sSoyad { get; set; }
        public int sYas { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Stajyer stajyer1 = new Stajyer();
            stajyer1.sAdi = "Serhat";
            stajyer1.sSoyad = "Yıldız";
            stajyer1.sYas = 23;

            Stajyer stajyer2 = new Stajyer();
            stajyer2.sAdi = "Furkan";
            stajyer2.sSoyad = "Alper";
            stajyer2.sYas = 21;

            Stajyer stajyer3 = new Stajyer();
            stajyer3.sAdi = "Gaye";
            stajyer3.sSoyad = "Işık";
            stajyer3.sYas = 24;

            Stajyer[] stajyerler = new Stajyer[] { stajyer1, stajyer2, stajyer3 };

            foreach (var stajyer in stajyerler)
            {
                Console.WriteLine(stajyer.sAdi + " - " + stajyer.sSoyad + " - " + stajyer.sYas);
            }
        }
    }
}
