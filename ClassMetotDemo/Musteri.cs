using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Cinsiyet { get; set; }

        // 1-TR hesabı 2- Doviz Hesabı
        public int HesapTuru { get; set; }

        // TR hesap Bakiyesi
        public int Bakiye1 { get; set; }

        //Doviz Hesap Bakiyesi
        public int Bakiye2 { get; set; }
    }
}
