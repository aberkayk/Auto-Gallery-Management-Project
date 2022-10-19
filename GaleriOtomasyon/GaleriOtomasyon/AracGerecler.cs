using System;
namespace GaleriOtomasyon
{
    public class AracGerecler
    {
        //Sık kullandığımız metotları buraya static public yapısıyla tanımlayabiliriz.
        //Heap Memoryde hazır olarak bekletir.

        static public int SayiAl(string mesaj)
        {
            int sayi;
            int sayac = 0;
            do
            {
                sayac++;
                Console.Write(mesaj);
                string giris = Console.ReadLine();
                if (int.TryParse(giris, out sayi))
                {
                    return sayi;
                }
                else if (sayac == 3)
                {
                    Exception a = new Exception("Çok fazla hatalı giriş yapıldı.");
                    throw a;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yapıldı.");
                }
            } while (true);
        }

        static public bool HarfMi(string veri)
        {
            veri = veri.ToUpper();
            bool cevap = true;
            for (int i = 0; i < veri.Length; i++)
            {
                int kod = (int)veri[i];
                if ((kod >= 65 && kod <= 90) != true)
                {
                    throw new Exception("Harf girilmedi.");
                    cevap = false;
                }
            }
            return cevap;
        }

        static public string YaziAl(string mesaj)
        {
            string yazi;
            Console.Write(mesaj);
            string giris = Console.ReadLine();
            yazi = giris.ToUpper();
            return yazi;
        }

        static public string IlkHarfiBuyut(string veri)
        {
            return veri.Substring(0, 1).ToUpper() + veri.Substring(1).ToLower();
        }

        static public string StringAl()
        {

            Console.Write("Seçiminiz: ");
            string ifade = Console.ReadLine();
            if (ifade.ToLower() == "exit")
            {
                Exception a = new Exception("Çıkış talebi alındı, program sonlandırılıyor.");
                throw a;
            }
            return ifade;


        }
    }
}

