using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Individual
    //Musteri de olan her şey Gercek ve Tuzel musteride de var artık
    class GercekMusteri:Musteri
    { 
        public string TcNo { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }
    }
}
