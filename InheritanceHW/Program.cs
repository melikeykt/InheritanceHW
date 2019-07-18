using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar B1 = new Bilgisayar();
           
            B1.Marka = "Dell";
            B1.Model = "Inspiron";
            B1.Islemci = "i5";
            B1.AlisFiyati = -10;
            B1.SatisFiyati = 1600;
            B1.KampanyaFiyati = 1599;
            B1.Barkod = "1235675";
            int deger = B1.ID;

            SanalDatabase.UrunEkle(B1);



            Bilgisayar B2 = new Bilgisayar();

            B2.Marka = "Dell";
            B2.Model = "Inspiron";
            B2.Islemci = "i5";
            B2.AlisFiyati = -10;
            B2.SatisFiyati = 1600;
            B2.KampanyaFiyati = 1599;
            B2.Barkod = "12356757";
            int deger2 = B2.ID;

            SanalDatabase.UrunEkle(B2);


            Console.ReadLine();
        }
    }
}
