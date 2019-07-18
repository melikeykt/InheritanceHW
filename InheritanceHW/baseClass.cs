using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW
{
    public class BaseClass
    {

        public static int sayac = 1;
        public BaseClass()
        {
            _id = sayac;
            sayac++;
        }

        
        public DateTime OlusturmaTarihi { get; set; }
        public int OlusturanKullanici { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public int GuncelleyenKullanici { get; set; }
        public bool Silindi { get; set; }

        private string _barkod; //*barkod database kayıt olmasın.
        public string Barkod
        {
            get
            {
                return _barkod;
            }
            set
            {

                if (SanalDatabase.BarkodKontrol(value))
                {
                    Console.WriteLine("Alınmış barkod değeri");
                }
                else
                {
                    _barkod = value;
                }


            } 
        } 

        private int _id; //*id değeri set edilemez olsun ve hazır gelsin

        public int ID
        {
            get
            {
                return _id;
            }
            private  set
            {
               
            }
        }

       
       

    }
}
