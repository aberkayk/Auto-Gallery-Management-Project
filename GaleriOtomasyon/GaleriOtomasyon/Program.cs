using System;
using System.Collections.Generic;

namespace GaleriOtomasyon
{
    class Program
    {
        static Galeri G034Galeri = new Galeri();

        static void Main(string[] args)
        {
            Uygulama();
            //Test2();
        }
        static void Test2()
        {
            int sayi = 2;
            string sonuc;
            if (sayi > 0)
            {
                sonuc = "0' dan büyük";
            }
            else
            {
                sonuc = "0' dan küçük";
            }
            Console.WriteLine(sonuc);
            //Tek satırda else if yazmak
            string durum = sayi > 0 ? "sıfırdan büyük" : "sıfırdan küçük";
            Console.WriteLine(durum);
            durum = sayi % 2 == 0 ? "sayı çift" : "sayı tek";
            Console.WriteLine(durum);
            durum = sayi > 0 ? "pozitif" : sayi < 0 ? "negatif": "nötr";
            Console.WriteLine(durum);

        }

        static void Test()
        {

            //Console.WriteLine(AracGerecler.IlkHarfiBuyut("AraBANI GetirME BuraYa"));
            //int sayi = AracGerecler.SayiAl("Sayi: ");


            try
            {
                int sayi = AracGerecler.SayiAl("Sayı: ");
                Console.WriteLine("Sayının iki katı: " + sayi * 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




            try
            {
                string secim = AracGerecler.StringAl();
                Console.WriteLine("Seçiminiz: " + secim);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



            try
            {
                Console.Write("Sayı: ");
                int sayi = int.Parse(Console.ReadLine());
                Console.WriteLine(sayi * 2);
                if (sayi < 50)
                {
                    Console.WriteLine("50'den küçüktür. ");
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

        }

        static void Uygulama()
        {
            SahteVeriGir();
            Menu();

            while (true)
            {
                string secim = SecimAl();
                switch (secim)
                {
                    case "1":
                    case "K":
                        ArabaKirala();
                        break;
                    case "2":
                    case "T":
                        ArabaTeslimAl();
                        break;
                    case "3":
                    case "R":
                        KiradakiArabalariListele();
                        break;
                    case "4":
                    case "M":
                        GaleridekiArabalariListele();
                        break;
                    case "5":
                    case "A":
                        TumArabalariListele();
                        break;
                    case "6":
                    case "I":
                        ArabaKiralamaIptali();
                        break;
                    case "7":
                    case "Y":
                        ArabaEkle();
                        break;
                    case "8":
                    case "S":
                        ArabaSil();
                        break;
                    case "9":
                    case "G":
                        BilgileriGoster();
                        break;

                }
            }
        }

        static void Menu()  //Tamamlandı
        {
            Console.WriteLine("Galeri Otomasyon");
            Console.WriteLine("1 - Araba Kirala (K)");
            Console.WriteLine("2 - Araba Teslim Al (T)");
            Console.WriteLine("3 - Kiradaki Arabaları Listele (R)");
            Console.WriteLine("4 - Galerideki Arabaları Listele (M)");
            Console.WriteLine("5 - Tüm Arabaları Listele (L)");
            Console.WriteLine("6 - Kiralama İptali (I)");
            Console.WriteLine("7 - Araba Ekle (Y)");
            Console.WriteLine("8 - Araba Sil (S)");
            Console.WriteLine("9 - Bilgileri Göster (G)");
        }

        static string SecimAl() //Tamamlandı
        {

            Console.WriteLine();
            string karakterler = "123456789KTRMAIYSG";
            bool loop = true;
            int sayac = 0;
            string secim1 = "";


            while (loop)
            {
                Console.Write("Seçiminiz: ");
                string secim = Console.ReadLine().ToUpper();
                Console.WriteLine();
                secim1 = secim;
                if (karakterler.IndexOf(secim) > -1 && secim.Length == 1)
                {
                    sayac++;
                    return secim;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız. Tekrar deneyin.");
                    sayac++;
                }
                if (sayac == 10)
                {
                    Console.WriteLine("Üzgünüm sizi anlayamıyorum. Program sonlandırılıyor.");
                    Environment.Exit(0);
                }
            }
            return secim1;

        }

        static void SahteVeriGir() //Tamamlandı
        {
            G034Galeri.ArabaEkle("34KL4445", "FORD", 540f, ARABA_TIPI.SUV);
            G034Galeri.ArabaEkle("34BV4345", "PORSCHE", 1000f, ARABA_TIPI.SUV);
            G034Galeri.ArabaEkle("34YK4565", "HONDA", 280f, ARABA_TIPI.Hatchback);
            G034Galeri.ArabaEkle("34AS9065", "BMW", 320f, ARABA_TIPI.Hatchback);
            G034Galeri.ArabaEkle("34PO8878", "MERCEDES", 420f, ARABA_TIPI.Sedan);
            G034Galeri.ArabaEkle("34YL1010", "HYUNDAI", 450f, ARABA_TIPI.Sedan);

        }

        //ARABA EKLE METODUNDA ÖRNEK UYGULAMADA plaka küçük harfle girilince
        //kabul etmiyor. Bunu düzelttik, otomatik ToUpper yapıyor ve küçük
        //harf girilse dahi kabul ediyor.
        static void ArabaEkle() //Tamamlandı - ekran çıktısı tamam
        {
            Console.WriteLine("--Araba Ekle--");
            bool kontrol = true;
            while (kontrol)
            {

                string plaka = PlakaAl("Plaka: ");
                bool p_kontrol = PlakaVarMi(plaka);
                if (p_kontrol)
                {

                    Console.WriteLine("Aynı plakada araba mevcut. Girdiğiniz plakayı kontrol edin.");
                    kontrol = true;
                }
                else
                {
                    string marka = YaziAl("Marka: ");
                    float k_bedeli = SayiAl("Kiralama Bedeli: ");
                    Console.WriteLine("Araba Tipleri: ");
                    Console.WriteLine("Araba Tipleri: ");
                    Console.WriteLine(" - SUV için 1");
                    Console.WriteLine(" - Hatchback için 2");
                    Console.WriteLine(" - Sedan için 3");

                    ARABA_TIPI aTipi;

                    bool kontrol1 = true;

                    while (kontrol1)
                    {
                        int secim = SayiAl("Araba tipi: ");
                        if (secim == 1)
                        {
                            Console.WriteLine();
                            aTipi = ARABA_TIPI.SUV;
                            Console.WriteLine("Araba başarılı bir şekilde eklendi.");
                            G034Galeri.ArabaEkle(plaka, marka, k_bedeli, aTipi);
                            kontrol = false;
                            kontrol1 = false;
                        }
                        else if (secim == 2)
                        {
                            Console.WriteLine();
                            aTipi = ARABA_TIPI.Hatchback;
                            Console.WriteLine("Araba başarılı bir şekilde eklendi.");
                            kontrol = false;
                            kontrol1 = false;
                            G034Galeri.ArabaEkle(plaka, marka, k_bedeli, aTipi);

                        }
                        else if (secim == 3)
                        {
                            Console.WriteLine();
                            aTipi = ARABA_TIPI.Sedan;
                            Console.WriteLine("Araba başarılı bir şekilde eklendi.");
                            kontrol = false;
                            kontrol1 = false;
                            G034Galeri.ArabaEkle(plaka, marka, k_bedeli, aTipi);
                        }
                        else
                        {
                            Console.WriteLine("Giriş tanımlanamadı. Tekrar deneyin.");
                        }
                    }

                }

            }


        }
        static void ArabaKirala() //Tamamlandı - ekran çıktısı tamam
        {
            Console.WriteLine("-Araba Kirala-");
            bool kontrol = true;
            while (kontrol)
            {
                string plaka = PlakaAl("Kiralanacak arabanın plakası: ");

                bool p_kontrol = PlakaVarMi(plaka);
                bool k_kontrol = AracKiradami(plaka);

                if (p_kontrol == true)
                {
                    if (k_kontrol == true)
                    {
                        Console.WriteLine("Araba şu anda kirada. Farklı araba seçiniz.");
                    }
                    else if (k_kontrol == false)
                    {
                        int sure = AracGerecler.SayiAl("Kiralama süresi: ");
                        Console.WriteLine(plaka + " plakalı araba " + sure + " saatliğine kiralandı.");
                        G034Galeri.ArabaKiralama(plaka, sure);
                        kontrol = false;
                    }


                }
                else
                {
                    Console.WriteLine("Galeriye ait bu plakada bir araba yok.");
                    kontrol = true;
                }



            }

        }

        //ARABA TESLİM ALMA METODUNDA ÖRNEK UYGULAMADA kirada hiç araba olmadığı halde
        //plaka istemeye devam ediyor. Bunu düzelttik.
        static void ArabaTeslimAl()
        {
            Console.WriteLine(" - Araba Teslim Al -");
            bool kontrol = true;
            while (kontrol)
            {
                if (G034Galeri.KiradakiArabaSayisi == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Kirada hiç araba yok.");
                    break;
                }

                else
                {
                    string plaka = PlakaAl("Teslim Edilecek Arabanın Plakası: ");
                    bool p_kontrol = PlakaVarMi(plaka);
                    bool g_kontrol = AracGaleridemi(plaka);

                    if (p_kontrol == true)
                    {
                        if (g_kontrol == true)
                        {
                            Console.WriteLine("Hatalı giriş yapıldı. Araba zaten galeride.");
                        }
                        else
                        {
                            G034Galeri.ArabaTeslimAlim(plaka);
                            Console.WriteLine();
                            Console.WriteLine("Araba galeride beklemeye alındı.");
                            kontrol = false;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Galeriye ait bu plakada bir araba yok.");
                        kontrol = true;
                    }
                }

            }

        }//Tamamlandı - ekran çıktısı tamam

        static void ArabaKiralamaIptali()
        {
            Console.WriteLine("-Kiralama İptali-");
            bool kontrol = true;
            while (kontrol)
            {
                string plaka = PlakaAl("Kiralaması iptal edilecek arabanın plakası: ");
                bool g_kontrol = AracGaleridemi(plaka);
                bool p_kontrol = PlakaVarMi(plaka);
                if (p_kontrol == true)
                {
                    if (g_kontrol == true)
                    {
                        Console.WriteLine("Hatalı giriş yapıldı. Araba zaten galeride.");
                    }
                    else
                    {
                        G034Galeri.ArabaKiralamaIptal(plaka);
                        Console.WriteLine();
                        Console.WriteLine("İptal gerçekleştirildi.");
                        kontrol = false;
                    }
                }
                else
                {
                    Console.WriteLine("Galeriye ait bu plakada bir araba yok.");
                    kontrol = true;
                }

            }
        } //Tamamlandı - ekran çıktısı tamam

        static void ArabaSil()
        {
            Console.WriteLine("-Araba Sil-");
            bool kontrol = true;
            while (kontrol)
            {
                string plaka = PlakaAl("Silmek istediğiniz arabanın plakasını giriniz: ");
                bool p_kontrol = PlakaVarMi(plaka);
                bool k_kontrol = AracKiradami(plaka);
                if (p_kontrol == true)
                {
                    if (k_kontrol == true)
                    {
                        Console.WriteLine("Araba kirada olduğu için silme işlemi gerçekleştirilemedi.");
                    }
                    else
                    {
                        G034Galeri.ArabaSil(plaka);
                        Console.WriteLine();
                        Console.WriteLine("Araba silindi.");
                        kontrol = false;
                    }
                }
                else
                {
                    Console.WriteLine("Galeriye ait bu plakada bir araba yok.");
                    kontrol = true;
                }
            }

        }//Tamamlandı - ekran çıktısı tamam

        static void TumArabalariListele()
        {
            if (G034Galeri.ToplamArabaSayisi > 0)
            {
                Console.WriteLine("-Tüm Arabalar-");
                Console.WriteLine("Plaka".PadRight(12) + "Marka".PadRight(10) + "K.Bedeli".PadRight(12) + "Araba Tipi".PadRight(14) + "K.Sayısı".PadRight(12) + "Durum");
                Console.WriteLine("-----------------------------------------------------------------------------");

                foreach (Araba araba in G034Galeri.Arabalar)
                {
                    Console.WriteLine(araba.Plaka.PadRight(12) +
                        araba.Marka.PadRight(10) +
                        araba.KiralamaBedeli.ToString().PadRight(12) +
                        araba.ArabaTipi.ToString().PadRight(14) +
                        araba.KiralamaSayisi.ToString().PadRight(12) +
                        araba.Durum.ToString());
                }
            }
            else
            {
                Console.WriteLine("Listelenecek araba yok.");
            }

        } //Tamamlandı
        static void KiradakiArabalariListele()
        {
            if (G034Galeri.KiradakiArabaSayisi > 0)
            {
                Console.WriteLine("-Kiradaki Arabalar-");
                Console.WriteLine("Plaka".PadRight(12) + "Marka".PadRight(10) + "K.Bedeli".PadRight(12) + "Araba Tipi".PadRight(14) + "K.Sayısı".PadRight(12) + "Durum");
                Console.WriteLine("-----------------------------------------------------------------------------");
                foreach (Araba araba in G034Galeri.Arabalar)
                {
                    if (araba.Durum == DURUM.Kirada)
                    {
                        Console.WriteLine(araba.Plaka.PadRight(12) +
                            araba.Marka.PadRight(10) +
                            araba.KiralamaBedeli.ToString().PadRight(12) +
                            araba.ArabaTipi.ToString().PadRight(14) +
                            araba.KiralamaSayisi.ToString().PadRight(12) +
                            "Kirada");
                    }
                }
            }
            else
            {
                Console.WriteLine("Listelenecek araba yok.");
            }



        } //Tamamlandı
        static void GaleridekiArabalariListele()
        {
            if (G034Galeri.GaleridekiArabaSayisi > 0)
            {
                Console.WriteLine("-Galerideki Arabalar-");
                Console.WriteLine();
                Console.WriteLine("Plaka".PadRight(12) + "Marka".PadRight(10) + "K.Bedeli".PadRight(12) + "Araba Tipi".PadRight(14) + "K.Sayısı".PadRight(12) + "Durum");
                Console.WriteLine("-----------------------------------------------------------------------------");
                foreach (Araba araba in G034Galeri.Arabalar)
                {
                    if (araba.Durum == DURUM.Galeride)
                    {
                        Console.WriteLine(araba.Plaka.PadRight(12) +
                            araba.Marka.PadRight(10) +
                            araba.KiralamaBedeli.ToString().PadRight(12) +
                            araba.ArabaTipi.ToString().PadRight(14) +
                            araba.KiralamaSayisi.ToString().PadRight(12) +
                            "Galeride");
                    }
                }
            }
            else
            {
                Console.WriteLine("Listelenecek araba yok.");
            }

        } //Tamamlandı

        static void BilgileriGoster()
        {
            Console.WriteLine("-Galeri Bilgileri-");
            Console.WriteLine("Toplam araba sayısı: " + G034Galeri.ToplamArabaSayisi);
            Console.WriteLine("Kiradaki araba sayısı: " + G034Galeri.KiradakiArabaSayisi);
            Console.WriteLine("Bekleyen araba sayısı: " + G034Galeri.GaleridekiArabaSayisi);
            Console.WriteLine("Toplam araba kiralama süresi: " + G034Galeri.ToplamArabaKiralamaSuresi);
            Console.WriteLine("Toplam araba kiralama adedi: " + G034Galeri.ToplamArabaKiralamaAdedi);
            Console.WriteLine("Toplam ciro: " + G034Galeri.Ciro);
        }


        static string PlakaAl(string mesaj)
        {
            int sayi1, sayi2, sayi3, sayi4;

            while (true)
            {
                Console.Write(mesaj);
                string plaka = Console.ReadLine().ToUpper();

                if (plaka.Length == 8)
                {
                    bool sonuc1 = int.TryParse(plaka.Substring(0, 2), out sayi1);
                    bool sonuc2 = int.TryParse(plaka.Substring(4, 4), out sayi2);
                    bool sonuc3 = int.TryParse(plaka.Substring(3, 5), out sayi3);
                    bool sonuc4 = int.TryParse(plaka.Substring(5, 3), out sayi4);
                    if (sonuc1 && sonuc4 && !sonuc3)
                    {
                        return plaka;

                    }
                    else if (sonuc1 && sonuc2 && !sonuc3)
                    {
                        return plaka;
                    }
                    else
                    {
                        Console.WriteLine("Bu şekilde plaka girişi yapamazsınız. Tekrar deneyin.");

                    }
                }
                else if (plaka.Length == 7)
                {
                    bool sonuc1 = int.TryParse(plaka.Substring(0, 2), out sayi1);
                    bool sonuc2 = int.TryParse(plaka.Substring(3, 4), out sayi2);
                    bool sonuc3 = int.TryParse(plaka.Substring(4, 3), out sayi3);
                    if (sonuc1 && sonuc2)
                    {
                        return plaka;
                    }
                    else if (sonuc1 && sonuc3)
                    {
                        return plaka;
                    }
                    else
                    {
                        Console.WriteLine("Bu şekilde plaka girişi yapamazsınız. Tekrar deneyin.");
                    }
                }
                else if (plaka.Length == 9)
                {
                    bool sonuc1 = int.TryParse(plaka.Substring(0, 2), out sayi1);
                    bool sonuc2 = int.TryParse(plaka.Substring(5, 4), out sayi2);
                    bool sonuc3 = int.TryParse(plaka.Substring(2, 3), out sayi3);
                    bool sonuc4 = int.TryParse(plaka.Substring(4, 5), out sayi4);
                    if (sonuc1 && sonuc2 && !sonuc3 && !sonuc4)
                    {
                        return plaka;
                    }
                    else
                    {
                        Console.WriteLine("Bu şekilde plaka girişi yapamazsınız. Tekrar deneyin.");
                    }
                }
                else
                {
                    Console.WriteLine("Bu şekilde plaka girişi yapamazsınız. Tekrar deneyin.");
                }
            }
        } //Tamamlandı

        static int SayiAl(string mesaj) //Tamamlandı
        {

            //Sayı input alınan her yerde bu method kullanılmalı ki giriş doğru olsun.

            int sayi;
            while (true)
            {
                Console.Write(mesaj);
                string giris = Console.ReadLine();
                bool sonuc = int.TryParse(giris, out sayi);
                if (!sonuc)
                {
                    Console.WriteLine("Giriş tanımlanamadı. Tekrar deneyin.");
                }
                else
                {
                    return sayi;
                }
            }
        }

        static string YaziAl(string mesaj)
        {
            string yazi;
            Console.Write(mesaj);
            string giris = Console.ReadLine();
            yazi = giris.ToUpper();
            return yazi;
        }//Tamamlandı

        static bool PlakaVarMi(string mesaj)
        {
            foreach (Araba item in G034Galeri.Arabalar)
            {
                if (item.Plaka.ToString() == mesaj)
                {
                    return true;
                }

            }
            return false;
        }

        static bool AracKiradami(string plaka)
        {
            foreach (Araba item in G034Galeri.Arabalar)
            {
                if (item.Plaka == plaka && item.Durum == DURUM.Kirada)
                {
                    return true;
                }

            }
            return false;

        }

        static bool AracGaleridemi(string plaka)
        {
            foreach (Araba item in G034Galeri.Arabalar)
            {
                if (item.Plaka == plaka && item.Durum == DURUM.Galeride)
                {
                    return true;
                }

            }
            return false;

        }

    }
}

