using System;

namespace static_sinif_ve_uyeler
{
    class program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Calisan Sayisi :" + Calisan.calisanSayisi);
            Calisan c1 = new Calisan(0001,"ali","xxx","yazilim");
            Calisan c2 = new Calisan(0002,"veli" , "yyy","yazilim");
            System.Console.WriteLine("Calisan Sayisi :" + Calisan.calisanSayisi);
            
        }
    }

    class Calisan
    {
        private int tc;
        private string isim;
        private string soyisim;
        private string departman;

        public static int calisanSayisi;

        static Calisan()        // Static fonk erisim belirleyici almaz.
        {                       // Static methodaların için static değerler alırlar.
            calisanSayisi = 0;  // Static constructor sadece ilk nesne oluşturulduğunda çağrılır. 
                                // Static sınıflardan kalıtım uyglanamaz static sınıflara.
        }
        
        public Calisan(int Tc,string Isim , string Soyisim , string Depertmant)
        {
            this.tc = Tc;
            this.isim = Isim;
            this.soyisim = Soyisim;
            this.departman = Depertmant;
            calisanSayisi++;
        }

    }

    static class Islemler
    {

    }
}