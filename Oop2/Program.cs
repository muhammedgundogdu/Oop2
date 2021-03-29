using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Muhammed Gündoğdu
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Muhammed";
            musteri1.Soyadi = "Gündoğdu";
            musteri1.TcNo = "123456789";


            //BiDoktoraSor
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "BiDoktoraSor.com";
            musteri2.VergiNo = "1234567890";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}
