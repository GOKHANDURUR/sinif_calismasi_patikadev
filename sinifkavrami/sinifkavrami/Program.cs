using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinifkavrami
{
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int CalisanNo;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisan Adi:{0}", Ad);
            Console.WriteLine("Calisan Soyadi:{0}", Soyad);
            Console.WriteLine("Calisan No:{0}", CalisanNo);
            Console.WriteLine("Calisan Departmani:{0}", Departman);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Söz Dizimi
            // class SinifAdi
            // {
            //     [Erişim Belirleyici] [Veri Tipi] ÖzelliklAdi;
            //     [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi])
            //     {
            //         //Metot komutları
            //     }
            // }

            //Erişim belirleyiciler
            // * Public -> her yerden erişilir
            // * Private -> tanımlandığı sınıf içerisinde erişilir
            // * Internal -> sadece kendi projesi içinde
            // * Protected -> sadece tanımlandığı sınıfta ve miras alan diğer tarafta alır

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Mervan";
            calisan1.Soyad = "Ozcan";
            calisan1.CalisanNo = 170215007;
            calisan1.Departman = "Software Development";

            calisan1.CalisanBilgileri();

            Console.WriteLine("*************************************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Can";
            calisan2.Soyad = "Yilmaz";
            calisan2.CalisanNo = 248639876;
            calisan2.Departman = "Product Development";

            calisan2.CalisanBilgileri();


        }
    }

    
}
    