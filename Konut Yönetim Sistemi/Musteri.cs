using System;
using System.Collections.Generic;
using System.Text;

namespace Konut_Yönetim_Sistemi
{
    class Musteri : Adres
    {
        public int MusteriNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public CINSIYET Cinsiyet { get; set; }
        public int MusteriButcesi { get; set; }
        public string ArananSehir { get; set; }
        public MUSTERIDURUM MusteriDurum { get; set; }
        public Adres Adresi { get; set; }
    }
    public enum CINSIYET
    {
        Empty,
        Kiz,
        Erkek
    }
    public enum MUSTERIDURUM
    {
        Empty,
        Ariyor,
        Aramiyor
    }
}
