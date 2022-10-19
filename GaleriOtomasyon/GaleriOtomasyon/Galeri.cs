using System;
using System.Collections.Generic;

namespace GaleriOtomasyon
{
    public class Galeri
    {
        //GALERİYE AİT VERİLER
        public List<Araba> Arabalar = new List<Araba>();

        public int ToplamArabaSayisi
        {
            get
            {
                return Arabalar.Count;
            }
        }
        public int KiradakiArabaSayisi
        {
            get
            {
                int adet = 0;
                foreach (Araba item in Arabalar)
                {
                    if (item.Durum == DURUM.Kirada)
                    {
                        adet++;
                    }
                }
                return adet;
            }
        }
        public int GaleridekiArabaSayisi
        {
            get
            {
                int adet = 0;
                foreach (Araba item in Arabalar)
                {
                    if (item.Durum == DURUM.Galeride)
                    {
                        adet++;
                    }
                }
                return adet;
            }
        }
        public int ToplamArabaKiralamaSuresi
        {
            get
            {
                int kiralamaSuresi = 0;
                Araba a = null;
                foreach (Araba item in Arabalar)
                {

                    a = item;
                    kiralamaSuresi += a.ToplamKiralanmaSuresi;

                }
                return kiralamaSuresi;
            }
        }
        public int ToplamArabaKiralamaAdedi 
        {
            get
            {
                Araba a = null;
                int toplamKiraAdedi = 0;
                foreach (Araba item in Arabalar)
                {
                    a = item;
                    toplamKiraAdedi += a.KiralamaSayisi;

                }
                return toplamKiraAdedi;
            }
        }
        public float Ciro
        {
            get
            {
                float ciro = 0;
                foreach (Araba item in Arabalar)
                {
                    ciro += item.KiralanmaSuresi * item.KiralamaBedeli;

                }
                return ciro;
            }
        }

        public void ArabaEkle(string plaka, string marka, float kbedel, ARABA_TIPI atip)
        {

            Araba a = new Araba(plaka, marka, kbedel, atip);
            this.Arabalar.Add(a);
        } //Tamamlandı

        public void ArabaKiralama(string plaka, int sure) //Tamamlandı
        {
            Araba a = null;
            foreach (Araba item in Arabalar)
            {
                if (item.Plaka == plaka)
                {
                    a = item;
                }
            }
            if (a != null)
            {
                a.Durum = DURUM.Kirada;
                a.KiralanmaSureleri.Add(sure);
                a.KiralanmaSuresi = sure;
            }
        }

        public void ArabaTeslimAlim(string plaka) 
        {
            Araba a = null;
            foreach (Araba item in Arabalar)
            {
                if (item.Plaka == plaka && item.Durum == DURUM.Kirada)
                {
                    a = item;
                }
            }
            if (a != null && a.Durum == DURUM.Kirada)
            {
                a.Durum = DURUM.Galeride;
            }
            
        }

        public void ArabaKiralamaIptal(string plaka)
        {
            Araba a = null;
            foreach (Araba item in Arabalar)
            {
                if (item.Plaka == plaka)
                {
                    a = item;
                }
            }
            if (a != null)
            {
                a.Durum = DURUM.Galeride;
                a.KiralanmaSureleri.Remove(a.KiralanmaSuresi);
            }
        }

        public void ArabaSil(string plaka) //Tamamlandı
        {
            Araba a = null;
            foreach (Araba item in Arabalar)
            {
                if (item.Plaka == plaka)
                {
                    a = item;
                }
            }
            if (a != null)
            {
                Arabalar.Remove(a);
            }
        }


    }
}

