using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri, List<Musteri> musteriler)
        {
            if (musteri.HesapTuru == 1)
            {
                Console.WriteLine("ID : " + musteri.Id + "\nAd : " + musteri.Ad + "\nSoyad : " + musteri.Soyad + "\nHesap Türü : TL" + "\nBakiye : " + musteri.Bakiye1 + "\nHesap Başarı ile Eklenmiştir.\n");
            }

            else
            {
                Console.WriteLine("ID : " + musteri.Id + "\nAd : " + musteri.Ad + "\nSoyad : " + musteri.Soyad + "\nHesap Türü : Döviz" + "\nBakiye : " + musteri.Bakiye2 + "\nHesap Başarı ile Eklenmiştir.\n");
            }
        }
        public void Listele(List<Musteri> musteriler)
        {
            Console.WriteLine("\n\n--------------------------------MÜŞTERİLER--------------------------------");

            foreach (var musteri in musteriler)
            {
                if (musteri.HesapTuru == 1)
                {
                    if (musteri.Cinsiyet == 0)
                    {
                        Console.WriteLine("Müşteri ID : " + musteri.Id + "\nMüşteri Adı Soyadı: " + musteri.Ad + " " + musteri.Soyad + "\nCinsiyet: Erkek" + "\nHesap Türü: TR " + "\nBakiye : " + musteri.Bakiye1);

                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Müşteri ID : " + musteri.Id + "\nMüşteri Adı Soyadı: " + musteri.Ad + " " + musteri.Soyad + "\nCinsiyet: Kadın" + "\nHesap Türü: TR " + "\nBakiye : " + musteri.Bakiye1);

                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                    }

                }
                else
                {
                    if (musteri.Cinsiyet == 0)
                    {
                        Console.WriteLine("Müşteri ID : " + musteri.Id + "\nMüşteri Adı Soyadı: " + musteri.Ad + " " + musteri.Soyad + "\nCinsiyet: Erkek" + "\nHesap Türü: Döviz " + "\nBakiye : " + musteri.Bakiye2);

                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Müşteri ID : " + musteri.Id + "\nMüşteri Adı Soyadı: " + musteri.Ad + " " + musteri.Soyad + "\nCinsiyet: Kadın" + "\nHesap Türü: Döviz " + "\nBakiye : " + musteri.Bakiye2);

                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                    }

                }
            }
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("\n\n------------------ HESAP SİLME EKRANI ------------------");

            if (musteri.Cinsiyet == 0)
            {
                Console.WriteLine(musteri.Id + " ID'li Müşterimiz " + musteri.Ad + " " + musteri.Soyad + " " + "Beyin Hesabı silinmiştir..");
            }
            else
            {
                Console.WriteLine(musteri.Id + " ID'li Müşterimiz " + musteri.Ad + " " + musteri.Soyad + " " + "Hanımın Hesabı silinmiştir..");
            }
        }
    }
}
