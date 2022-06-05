using System;
using System.Collections.Generic;
using System.Text;

namespace Konut_Yönetim_Sistemi
{
    class Daire : Adres
    {
        public int DaireNo { get; set; }
        public DateTime YapilisTarihi { get; set; }
        public int Fiyat { get; set; }
        public int NetOlcu { get; set; }
        public string OdaSayisi { get; set; }
        public DAIRETUR DaireTuru { get; set; }
        public DAIREDURUM DaireDurum { get; set; }
        
    }

    public enum DAIRETUR
    {
        Empty,
        Kiralık,
        Satilik
    }
    public enum DAIREDURUM
    {
        Empty,
        Satildi,
        Satilmadi,
        Kiralandi,
        Kiralanmadi
    }
}
