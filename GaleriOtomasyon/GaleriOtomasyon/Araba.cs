using System;
using System.Collections.Generic;

namespace GaleriOtomasyon
{
    public class Araba
    {
        public List<int> KiralanmaSureleri = new List<int>();

        //ARABA NESNESİNE AİT VERİ YÖNETİMİ
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public float KiralamaBedeli { get; set; }
        public int KiralanmaSuresi { get; set; }
        
        public ARABA_TIPI ArabaTipi;
        public DURUM Durum;

        public int KiralamaSayisi //Tamamlandı
        {
            
            get
            {
                int adet = 0;
                for (int i = 0; i < KiralanmaSureleri.Count; i++)
                {
                    adet++;
                }
                return adet;
                
            }
        }

        public int ToplamKiralanmaSuresi //Tamamlandı
        {
            get
            {
                int toplam = 0;
                foreach (int sure in KiralanmaSureleri)
                {
                    toplam += sure;
                }
                return toplam;
            }
        }


        public Araba()
        {
            this.Durum = DURUM.Galeride;
        }

        public Araba(string plaka, string marka, float k_bedeli, ARABA_TIPI a_tipi)
        {
            this.Plaka = plaka;
            this.Marka = marka;
            this.KiralamaBedeli = k_bedeli;
            this.ArabaTipi = a_tipi;
        }

        
    }
    public enum ARABA_TIPI
    {
        Empty, SUV, Hatchback, Sedan
    }

    public enum DURUM
    {
        Galeride, Kirada
    }
}

