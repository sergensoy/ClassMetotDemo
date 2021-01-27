using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Süleyman";
            musteri1.Soyad = "Bakar";
            musteri1.Cinsiyet = 0;
            musteri1.HesapTuru = 1;
            musteri1.Bakiye1 = 1500;
            musteri1.Bakiye2 = 0;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Veli";
            musteri2.Soyad = "Mahmut";
            musteri2.Cinsiyet = 0;
            musteri2.HesapTuru = 1;
            musteri2.Bakiye1 = 15;
            musteri2.Bakiye2 = 0;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Fatma";
            musteri3.Soyad = "Neşe";
            musteri3.Cinsiyet = 1;
            musteri3.HesapTuru = 2;
            musteri3.Bakiye1 = 0;
            musteri3.Bakiye2 = 6700;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Ad = "Melisa";
            musteri4.Soyad = "Yurtsever";
            musteri4.Cinsiyet = 0;
            musteri4.HesapTuru = 1;
            musteri4.Bakiye1 = 250;
            musteri4.Bakiye2 = 0;

            List<Musteri> musteriler = new List<Musteri> { musteri1, musteri2, musteri3, musteri4 };

            MusteriManager musteriManager = new MusteriManager();

            // Müşteri Ekleme

            musteriManager.Ekle(musteri1, musteriler);
            musteriManager.Ekle(musteri2, musteriler);
            musteriManager.Ekle(musteri3, musteriler);
            musteriManager.Ekle(musteri4, musteriler);

            //Musterileri Listele

            musteriManager.Listele(musteriler);

            musteriManager.Sil(musteri2);
        }
    }
}
