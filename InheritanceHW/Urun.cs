using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW
{
    class Urun : BaseClass
    {



        public string Marka { get; set; } //belirtmiş olduğumuz markalr içine ürün eklenebilsin.
        public string Model { get; set; }

        private decimal _satisFiyati;
        public decimal SatisFiyati
        {
            get
            {
                return _satisFiyati;
            }
            set
            {
                if (value < _alisFiyati)
                {
                    Console.WriteLine("Satış fiyatı alış fiyatından küçük olamaz.");
                }
                else
                {
                    _satisFiyati = value;
                }
            }
        } //alış fiyatından küçük olamaz


        private decimal _alisFiyati;
        public decimal AlisFiyati
        {
            get
            {
                return _alisFiyati;
            }
            set
            {
                if (value > 0)
                {
                    _alisFiyati = value;
                }
                else
                {
                    Console.WriteLine("0 dan küçük olamaz");
                }

            }
        }


        private decimal _kampanyaFiyati; //kampanya fiyat değer, sıfırdan küçük olamaz.
        public decimal KampanyaFiyati
        {
            get { return _kampanyaFiyati; }

            set
            {
                if (value<=0)
                {
                    Console.WriteLine("Böyle de kampanya olmaz ki");
                }
                else
                {
                    _kampanyaFiyati = value;
                }
            }
        }
    }
}
