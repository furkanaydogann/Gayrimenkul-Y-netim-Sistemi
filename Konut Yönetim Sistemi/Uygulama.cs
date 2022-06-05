using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konut_Yönetim_Sistemi
{
    class Uygulama
    {
        List<Musteri> Musteriler = new List<Musteri>();
        List<Daire> Daireler = new List<Daire>();
        public void Calistir()
        {
            Menu();
            SahteVeri();
            SecimUygula();
            Console.WriteLine();
        }
        public void SecimUygula()
        {
            do
            {
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        DaireEkle();
                        break;
                    case "2":
                        MusteriEkle();
                        break;
                    case "3":
                        DaireKiralaSatınAL();
                        break;
                    case "4":
                        ButunMusterileriListele();
                        break;
                    case "5":
                        ButunDaireleriListele();
                        break;
                    case "6":
                        KiralıkDaireleriListele();
                        break;
                    case "7":
                        SatilikDaireleriListele();
                        break;
                    case "8":
                        DaireBilgileriniGor();
                        break;
                    case "9":
                        FiyataGoreListele();
                        break;
                    case "10":
                        TariheGoreListele();
                        break;
                    case "11":
                        AdreseGoreListele();
                        break;
                    case "12":
                        SatilikPahaliİlkBeş();
                        break;
                    case "13":
                        KiralikPahaliİlkBeş();
                        break;
                    case "14":
                        SatilikUcuzİlkUc();
                        break;
                    case "15":
                        KiralikUcuzİlkUc();
                        break;
                    case "16":
                        KiralananSonDaire();
                        break;
                    case "17":
                        SatilanSonDaire();
                        break;
                    case "18":
                        DaireGuncelle();
                        break;
                    case "19":
                        MusteriGuncelle();
                        break;
                    case "20":
                        DaireSil();
                        break;
                    case "21":
                        MusteriSil();
                        break;
                    default:
                        Console.WriteLine("         Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");
                        Console.WriteLine("Yapmak istediğiniz işlemi seçin : ");
                        break;
                }
            } while (true);

        }
        public void MenuTekrar()
        {
            Console.WriteLine();
            Console.WriteLine("Menüyü tekrar listelemek için “liste”, çıkış yapmak için “çıkış” yazın.");

            string karar = Console.ReadLine().ToLower();
            bool x = true;

            do
            {
                switch (karar)
                {
                    case "liste":
                        Menu();
                        x = false;
                        SecimUygula();
                        Console.WriteLine();
                        break;
                    case "çıkış":
                        return;
                        break;
                    default:
                        Console.WriteLine("         Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");
                        break;
                }
            } while (x);

        }
        public void Deneme()
        {

        }
        public void Menu()
        {
            Console.WriteLine("------Gayrimenkul Yönetim Sistemi------");
            Console.WriteLine();
            Console.WriteLine("1  - Daire Ekle                                 ");
            Console.WriteLine("2  - Müşteri Ekle                               ");
            Console.WriteLine("3  - Daire kirala veya satın al                 ");
            Console.WriteLine("4  - Bütün Müşterileri Listele                  ");
            Console.WriteLine("5  - Bütün Daireleri Listele                    ");
            Console.WriteLine("6  - Kiralık Daireleri Listele                  ");
            Console.WriteLine("7  - Satılık Daireleri Listele                  ");
            Console.WriteLine("8  - Dairenin Bilgilerini Görüntüle             ");
            Console.WriteLine("9  - Fiyat Aralığına Göre Daireleri Listele     ");
            Console.WriteLine("10 - Şu Tarihten Sonra Yapılan Daireleri Listele");
            Console.WriteLine("11 - Adrese Göre Daireleri Listele              ");
            Console.WriteLine("12 - En Pahalı ve Satılık 5 Daireyi Listele     ");
            Console.WriteLine("13 - En Pahalı ve Kiralık 5 Daireyi Listele     ");
            Console.WriteLine("14 - En Ucuz ve Satılık 3 Daireyi Listele       ");
            Console.WriteLine("15 - En Ucuz ve Kiralık 3 Daireyi Listele       ");
            Console.WriteLine("16 - Kiralanan Son Daireyi Gör                  ");
            Console.WriteLine("17 - Satılan Son Daireyi Gör                    ");
            Console.WriteLine("18 - Daire Güncelle                             ");
            Console.WriteLine("19 - Müşteri Güncelle                           ");
            Console.WriteLine("20 - Daire Sil                                  ");
            Console.WriteLine("21 - Müşteri Sil                                ");
            Console.WriteLine();
            Console.Write("Yapmak istediğiniz işlemi seçin : ");
        }
        public void SahteVeri()
        {
            Daire d1 = new Daire();
            d1.DaireNo = 1;
            d1.DaireTuru = DAIRETUR.Kiralık;
            d1.Fiyat = 100;
            d1.NetOlcu = 120;
            d1.OdaSayisi = "2+1";
            d1.YapilisTarihi = new DateTime(2011, 5, 20);
            d1.DaireDurum = DAIREDURUM.Kiralanmadi;
            d1.İl = "İstanbul";
            d1.İlce = "Beşiktaş";

            Daire d2 = new Daire();
            d2.DaireNo = 2;
            d2.DaireTuru = DAIRETUR.Satilik;
            d2.Fiyat = 350000;
            d2.NetOlcu = 150;
            d2.OdaSayisi = "3+1";
            d2.YapilisTarihi = new DateTime(2016, 8, 14);
            d2.DaireDurum = DAIREDURUM.Satilmadi;
            d2.İl = "İstanbul";
            d2.İlce = "Kadıköy";

            Daire d3 = new Daire();
            d3.DaireNo = 3;
            d3.DaireTuru = DAIRETUR.Satilik;
            d3.Fiyat = 500000;
            d3.NetOlcu = 150;
            d3.OdaSayisi = "3+1";
            d3.YapilisTarihi = new DateTime(2016, 8, 14);
            d3.DaireDurum = DAIREDURUM.Satilmadi;
            d3.İl = "İstanbul";
            d3.İlce = "Tuzla";

            Daire d4 = new Daire();
            d4.DaireNo = 4;
            d4.DaireTuru = DAIRETUR.Satilik;
            d4.Fiyat = 410000;
            d4.NetOlcu = 150;
            d4.OdaSayisi = "3+1";
            d4.YapilisTarihi = new DateTime(2016, 8, 14);
            d4.DaireDurum = DAIREDURUM.Satilmadi;
            d4.İl = "Ankara";
            d4.İlce = "Keçiören";

            Daireler.Add(d1);
            Daireler.Add(d2);
            Daireler.Add(d3);
            Daireler.Add(d4);

            Musteri m1 = new Musteri();
            m1.Ad = "Metin";
            m1.Soyad = "Tekin";
            m1.MusteriNo = 1;
            m1.Cinsiyet = CINSIYET.Erkek;
            m1.MusteriButcesi = 3000;
            m1.İl = "İstanbul";
            m1.İlce = "Beşiktaş";
            m1.Mahalle = "Cihannüma";
            m1.ArananSehir = "İstanbul";
            m1.MusteriDurum = MUSTERIDURUM.Ariyor;

            Musteri m2 = new Musteri();
            m2.Ad = "Ali";
            m2.Soyad = "Güntekin";
            m2.MusteriNo = 2;
            m2.Cinsiyet = CINSIYET.Erkek;
            m2.MusteriButcesi = 400000;
            m2.İl = "İstanbul";
            m2.İlce = "Kadıköy";
            m2.Mahalle = "Caferağa";
            m2.ArananSehir = "İstanbul";
            m2.MusteriDurum = MUSTERIDURUM.Ariyor;

            Musteri m3 = new Musteri();
            m3.Ad = "Feyza";
            m3.Soyad = "Çınar";
            m3.MusteriNo = 3;
            m3.Cinsiyet = CINSIYET.Kiz;
            m3.MusteriButcesi = 1000;
            m3.İl = "İstanbul";
            m3.İlce = "Sarıyer";
            m3.Mahalle = "İpekyolu";
            m3.ArananSehir = "Ankara";
            m3.MusteriDurum = MUSTERIDURUM.Aramiyor;

            Musteriler.Add(m1);
            Musteriler.Add(m2);
            Musteriler.Add(m3);
        }
        public void DaireListele(List<Daire> liste)
        {
            Console.WriteLine(" No".PadRight(11) + "Net Ölçü(m2)".PadRight(20) + "Oda Sayısı".PadRight(18) + "Fiyatı".PadRight(14) + "Türü".PadRight(12) + "Durum".PadRight(16) + "Adres");
            Console.WriteLine("----      --------------      ------------      --------      ------      -------       -------------");
            foreach (Daire item in liste)
            {
                Console.WriteLine("  " + item.DaireNo.ToString().PadRight(13) + item.NetOlcu.ToString().PadRight(19) + item.OdaSayisi.PadRight(15) + item.Fiyat.ToString().PadRight(13) + item.DaireTuru.ToString().PadRight(12) + item.DaireDurum.ToString().PadRight(15) + item.İl + "(" + item.İlce + ")");
            }
        }
        public void ButunDaireleriListele()
        {
            Console.WriteLine(" No".PadRight(11) + "Net Ölçü(m2)".PadRight(20) + "Oda Sayısı".PadRight(18) + "Fiyatı".PadRight(14) + "Türü".PadRight(12) + "Durum".PadRight(13));
            Console.WriteLine("----      --------------      ------------      --------      ------      -------");
            foreach (Daire item in Daireler)
            {
                Console.WriteLine("  " + item.DaireNo.ToString().PadRight(13) + item.NetOlcu.ToString().PadRight(19) + item.OdaSayisi.PadRight(15) + item.Fiyat.ToString().PadRight(13) + item.DaireTuru.ToString().PadRight(12) + item.DaireDurum.ToString());
            }
            MenuTekrar();
        }
        public void ButunMusterileriListele()
        {
            Console.WriteLine(" No".PadRight(11) + "Adı Soyadı".PadRight(20) + "Müşteri Bütçesi".PadRight(22) + "Aranan Şehir".PadRight(20) + "Durum".PadRight(12));
            Console.WriteLine("----      ------------        -----------------     --------------      -------      ");
            foreach (Musteri item in Musteriler)
            {
                Console.WriteLine(" " + item.MusteriNo.ToString().PadRight(9) + (item.Ad + " " + item.Soyad).PadRight(25) + item.MusteriButcesi.ToString().PadRight(20) + item.ArananSehir.PadRight(18) + item.MusteriDurum);
            }
            MenuTekrar();
        }
        public void DaireEkle()
        {
            Console.WriteLine();
            Daire d = new Daire();
            Console.WriteLine("Daire Ekle --------------------------");
            int sayac = 0;

            bool x1 = true;
            // daire no ekleme
            do
            {
                Console.Write("Daire numarası : ");
                int no;

                if (int.TryParse(Console.ReadLine(), out no))
                {
                    d.DaireNo = no;
                    foreach (Daire item in Daireler)
                    {
                        bool y = true;
                        do
                        {
                            if (item.DaireNo == d.DaireNo)
                            {
                                d.DaireNo++;
                                sayac++;
                            }
                            else
                            {
                                y = false;
                            }
                        } while (y);

                    }
                    x1 = false;
                }
                else
                {
                    Console.WriteLine("         Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");
                }
            } while (x1);

            bool x2 = true;
            // yapilis tarihi ekleme
            do
            {
                Console.Write("Dairenin yapılış tarihi : ");
                DateTime tarih;

                if (DateTime.TryParse(Console.ReadLine(), out tarih))
                {
                    d.YapilisTarihi = tarih;
                    x2 = false;
                }
                else
                {
                    Console.WriteLine("         Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");
                }

            } while (x2);

            bool x3 = true;
            // tür ekleme
            do
            {
                Console.Write("Daire türü(Satılık(S) /Kiralık(K)) : ");
                string tur = Console.ReadLine().ToUpper();

                switch (tur)
                {
                    case "S":
                        d.DaireTuru = DAIRETUR.Satilik;
                        d.DaireDurum = DAIREDURUM.Satilmadi;
                        x3 = false;
                        break;
                    case "K":
                        d.DaireTuru = DAIRETUR.Kiralık;
                        d.DaireDurum = DAIREDURUM.Kiralanmadi;
                        x3 = false;
                        break;
                    default:
                        Console.WriteLine("         Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");
                        break;
                }
            } while (x3);

            // adres ekleme
            Console.WriteLine("Dairenin adresi:");
            Console.Write("      İl:");
            d.İl = Console.ReadLine();
            Console.Write("      İlçe:");
            d.İlce = Console.ReadLine();

            bool x4 = true;
            // fiyat ekleme
            do
            {
                Console.Write("Dairenin fiyatı : ");
                int fiyat;

                if (int.TryParse(Console.ReadLine(), out fiyat))
                {
                    d.Fiyat = fiyat;
                    x4 = false;
                }
                else
                {
                    Console.WriteLine("         Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");
                }

            } while (x4);

            bool x5 = true;
            // ölçü ekleme
            do
            {
                Console.Write("Dairenin net ölçüsü(m2) : ");
                int olcu;

                if (int.TryParse(Console.ReadLine(), out olcu))
                {
                    d.NetOlcu = olcu;
                    x5 = false;
                }
                else
                {
                    Console.WriteLine("         Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");
                }
            } while (x5);

            // daire oda sayısı
            Console.Write("Dairenin oda sayısı : ");
            d.OdaSayisi = Console.ReadLine();

            Daireler.Add(d);

            Console.WriteLine();
            Console.WriteLine(d.DaireNo + " numaralı daire sisteme başarılı bir şekilde eklenmiştir.");
            if (sayac != 0)
            {
                Console.WriteLine("Sistemde " + (d.DaireNo - sayac) + " numaralı daire olduğu için verdiğiniz daire no " + d.DaireNo + " olarak değiştirildi.");
            }

            MenuTekrar();
        }
        public void MusteriEkle()
        {
            Console.WriteLine();
            Console.WriteLine("Müşteri Ekle ------------------------");
            Musteri m = new Musteri();
            int sayac = 0;

            bool x1 = true;
            // musteri no ekleme
            do
            {
                Console.Write("Müşteri numarası : ");
                int no;

                if (int.TryParse(Console.ReadLine(), out no))
                {
                    m.MusteriNo = no;
                    foreach (Musteri item in Musteriler)
                    {
                        bool y = true;
                        do
                        {
                            if (item.MusteriNo == m.MusteriNo)
                            {
                                m.MusteriNo++;
                                sayac++;
                            }
                            else
                            {
                                y = false;
                            }
                        } while (y);

                    }
                    x1 = false;
                }
                else
                {
                    Console.WriteLine("         Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");
                }
            } while (x1);

            // musteri ad soyad ekleme
            Console.Write("Müşteri adı: ");
            m.Ad = Console.ReadLine();
            Console.Write("Müşteri soyadı: ");
            m.Soyad = Console.ReadLine();

            // cinsiyet ekleme
            bool x2 = true;
            do
            {
                Console.Write("Müşteri cinsiyeti (K/E) : ");
                string giris;
                giris = Console.ReadLine().ToUpper();

                switch (giris)
                {
                    case "K":
                        m.Cinsiyet = CINSIYET.Kiz;
                        x2 = false;
                        break;
                    case "E":
                        m.Cinsiyet = CINSIYET.Erkek;
                        x2 = false;
                        break;
                    default:
                        m.Cinsiyet = CINSIYET.Empty;
                        Console.WriteLine("         Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");
                        break;
                }


            } while (x2);

            // musteri adresi
            Console.WriteLine("Müşteri Adresi:");
            Console.Write("      İl:");
            m.İl = Console.ReadLine();
            Console.Write("      İlçe:");
            m.İlce = Console.ReadLine();
            Console.Write("      Mahalle:");
            m.Mahalle = Console.ReadLine();

            // musteri butcesi
            bool x3 = true;
            do
            {
                Console.Write("Müşteri bütçesi:");
                int butce;
                if (int.TryParse(Console.ReadLine(), out butce))
                {
                    m.MusteriButcesi = butce;
                    x3 = false;
                }
                else
                {
                    Console.WriteLine("         Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");
                }

            } while (x3);

            // daire aranan şehir
            Console.WriteLine("Daire aranan şehir:");
            m.ArananSehir = Console.ReadLine();


            Musteriler.Add(m);

            Console.WriteLine();
            Console.WriteLine("Bilgiler sisteme girilmiştir.");

            Console.WriteLine();
            Console.WriteLine(m.MusteriNo + " numaralı müşteri sisteme başarılı bir şekilde eklenmiştir.");
            if (sayac != 0)
            {
                Console.WriteLine("Sistemde " + (m.MusteriNo - sayac) + " numaralı müşteri olduğu için verdiğiniz müşteri no " + m.MusteriNo + " olarak değiştirildi.");
            }

            MenuTekrar();

        }
        public void DaireKiralaSatınAL()
        {
            List<Daire> yeniDaireListe = new List<Daire>();
            string tur;
            Console.WriteLine();
            Console.WriteLine("Daire Kirala/Satın Al ---------------");

            int aliciNo;
            Musteri m = new Musteri();
            // musteri no belirleme
            bool x = true;
            do
            {
                Console.Write("Müşteri numarası:");

                if (int.TryParse(Console.ReadLine(), out aliciNo))
                {
                    foreach (Musteri item in Musteriler)
                    {
                        if (item.MusteriNo == aliciNo)
                        {
                            m = Musteriler.Where(t => t.MusteriNo == aliciNo).FirstOrDefault();
                            x = false;
                        }
                    }
                    if (m.MusteriNo != aliciNo)
                    {
                        Console.WriteLine("Bu numaraya ait bir müşteri bulunamadı.");
                    }
                }
                else
                {
                    Console.WriteLine("         Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");
                }
            } while (x);

            // daire türü , burada daire türüne göre yeni bir liste oluşturulur.(kiralık daireler, satılık daireler)
            bool x2 = true;
            do
            {
                Console.Write("Daire türü(Satılık(S) /Kiralık(K)) : ");
                tur = Console.ReadLine().ToUpper();

                switch (tur)
                {
                    case "S":
                        yeniDaireListe = Daireler.Where(t => t.DaireTuru == DAIRETUR.Satilik).ToList();
                        x2 = false;
                        break;
                    case "K":
                        yeniDaireListe = Daireler.Where(t => t.DaireTuru == DAIRETUR.Kiralık).ToList();
                        x2 = false;
                        break;
                    default:
                        Console.WriteLine("         Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");
                        break;
                }
            } while (x2);

            // aranan adres
            Console.WriteLine("Aranan adres:");
            Console.Write("      Şehir:");
            string sehir = Console.ReadLine();
            Console.Write("      Semt:");
            string semt = Console.ReadLine();

            // fiyat aralığı 
            Console.Write("Minimum fiyat:");
            int minFiyat = int.Parse(Console.ReadLine());
            Console.Write("Maksimum fiyat:");
            int maxFiyat = int.Parse(Console.ReadLine());

            yeniDaireListe = yeniDaireListe.Where(t => t.İl == m.ArananSehir).ToList();
            yeniDaireListe = yeniDaireListe.Where(t => t.Fiyat >= minFiyat).ToList();
            yeniDaireListe = yeniDaireListe.Where(t => t.Fiyat <= maxFiyat).ToList();

            DaireListele(yeniDaireListe);

            // Daire kiralama. Dairelerin ve müşterilerin durumlarının vs değiştirilmesi.
            Console.WriteLine();

            int no;
            bool x3 = true;
            do
            {
                Console.WriteLine("Kiralamak istediğiniz daire numarasını giriniz: ");
                if (int.TryParse(Console.ReadLine(), out no))
                {
                    foreach (Daire item in yeniDaireListe)
                    {
                        if (item.DaireNo == no)
                        {
                            if (tur == "K")
                            {
                                item.DaireDurum = DAIREDURUM.Kiralandi;
                            }
                            else if (tur == "S")
                            {
                                item.DaireDurum = DAIREDURUM.Satildi;
                            }
                            m.MusteriDurum = MUSTERIDURUM.Aramiyor;
                            x3 = false;
                        }
                        else
                        {
                            Console.WriteLine("         Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("         Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");
                }
            } while (x3);


            MenuTekrar();

        }
        public void KiralıkDaireleriListele()
        {
            List<Daire> kiralıkDaireListesi = new List<Daire>();
            kiralıkDaireListesi = Daireler.Where(t => t.DaireTuru == DAIRETUR.Kiralık).ToList();

            DaireListele(kiralıkDaireListesi);

            MenuTekrar();
        }
        public void SatilikDaireleriListele()
        {
            List<Daire> satilikDaireListesi = new List<Daire>();
            satilikDaireListesi = Daireler.Where(t => t.DaireTuru == DAIRETUR.Satilik).ToList();

            DaireListele(satilikDaireListesi);

            MenuTekrar();
        }
        public void DaireBilgileriniGor()
        {
            Console.Write("Daire numarası: ");
            int no;
            bool x = true;
            List<Daire> tekDaireListesi = new List<Daire>();

            do
            {
                if (int.TryParse(Console.ReadLine(), out no))
                {
                    tekDaireListesi = Daireler.Where(t => t.DaireNo == no).ToList();
                    x = false;
                }
                else
                {
                    Console.WriteLine("         Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");
                }
            } while (x);

            DaireListele(tekDaireListesi);

            MenuTekrar();
        }
        public void FiyataGoreListele()
        {
            List<Daire> fiyataGoreListe = new List<Daire>();

            Console.Write("Daire türü (K/S) : ");
            DAIRETUR tur = DAIRETUR.Empty;

            string giris = Console.ReadLine().ToUpper();
            bool x = true;

            do
            {
                switch (giris)
                {
                    case "K":
                        tur = DAIRETUR.Kiralık;
                        x = false;
                        break;
                    case "S":
                        tur = DAIRETUR.Satilik;
                        x = false;
                        break;
                    default:
                        Console.WriteLine("         Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");
                        break;
                }
            } while (x);

            Console.Write("Minimum fiyat :");
            int minFiyat = int.Parse(Console.ReadLine());
            Console.Write("Maksimum fiyat :");
            int maxFiyat = int.Parse(Console.ReadLine());

            fiyataGoreListe = Daireler.Where(t => t.DaireTuru == tur).ToList();
            fiyataGoreListe = fiyataGoreListe.Where(t => t.Fiyat >= minFiyat).ToList();
            fiyataGoreListe = fiyataGoreListe.Where(t => t.Fiyat <= maxFiyat).ToList();

            DaireListele(fiyataGoreListe);
            MenuTekrar();

        }
        public void TariheGoreListele()
        {
            Console.Write("Tarih giriniz(YYYY/AA/GG) : ");
            DateTime tarih = DateTime.Parse(Console.ReadLine());

            List<Daire> tariheGoreListe = new List<Daire>();

            tariheGoreListe = Daireler.Where(t => t.YapilisTarihi >= tarih).ToList();

            DaireListele(tariheGoreListe);
            MenuTekrar();
        }
        public void AdreseGoreListele()
        {
            List<Daire> adreseGoreListe = new List<Daire>();

            Console.Write("İl : ");
            string il = Console.ReadLine();

            adreseGoreListe = Daireler.Where(t => t.İl == il).ToList();

            DaireListele(adreseGoreListe);
            MenuTekrar();

        }
        public void SatilikPahaliİlkBeş()
        {
            List<Daire> satilikİlkBeş = new List<Daire>();

            satilikİlkBeş = Daireler.Where(t => t.DaireTuru == DAIRETUR.Satilik).OrderByDescending(r => r.Fiyat).Take(5).ToList();

            DaireListele(satilikİlkBeş);
            MenuTekrar();
        }
        public void KiralikPahaliİlkBeş()
        {
            List<Daire> kiralikİlkBeş = new List<Daire>();

            kiralikİlkBeş = Daireler.Where(t => t.DaireTuru == DAIRETUR.Kiralık).OrderByDescending(r => r.Fiyat).Take(5).ToList();

            DaireListele(kiralikİlkBeş);
            MenuTekrar();
        }
        public void SatilikUcuzİlkUc()
        {
            List<Daire> satilikUcuzUc = new List<Daire>();

            satilikUcuzUc = Daireler.Where(t => t.DaireTuru == DAIRETUR.Satilik).OrderBy(r => r.Fiyat).Take(3).ToList();

            DaireListele(satilikUcuzUc);
            MenuTekrar();
        }
        public void KiralikUcuzİlkUc()
        {
            List<Daire> kiralikUcuzUc = new List<Daire>();

            kiralikUcuzUc = Daireler.Where(t => t.DaireTuru == DAIRETUR.Kiralık).OrderBy(r => r.Fiyat).Take(3).ToList();

            DaireListele(kiralikUcuzUc);
            MenuTekrar();
        }
        public void KiralananSonDaire()
        {
            MenuTekrar();
        }
        public void SatilanSonDaire()
        {
            MenuTekrar();
        }
        public void DaireGuncelle()
        {
            MenuTekrar();
        }
        public void MusteriGuncelle()
        {
            MenuTekrar();
        }
        public void DaireSil()
        {
            MenuTekrar();
        }
        public void MusteriSil()
        {
            MenuTekrar();
        }


    }
}
