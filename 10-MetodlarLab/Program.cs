namespace _10_MetodlarLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sorular
            /*
             * 1- KdvHesapla(100,20,dahil) ==> 83.33
             * KdvHesapla(100,20,haric) ==> 120
             * 
             * 2-HizHesapla(100km,30 dakika) ==> 200 km hızla gitmelisin.
             * 
             * 3-DiziOLustur(elemanSayisi) ==> int tipinden icerisinde 1-100 rastgele sayıların olduğu bir dizi dönecek
             * 
             * 
             * 4-SehirGetir(0) ==> rastgele bir şehir getirsin 
             * SehirGetir(34) ==> İstanbul'u getir
             * 
             * 5-SesliHarfSayisi(string) ==> 5 adet sesli harf vardır. a,e,i şeklinde bir çıktı versin.
             * 
             * 6-Sifrele(string) ==> sifrelenmis şekilde bastırsın. SifreCoz(sifrelenmis) ==> kelime
             */

            //1-KdvHesapla metodu çağırma 


            //2-HizHesapla() metodu çağırma
            //hız = x*t  t = hiz/ x 
            HizHesapla(100,0.5);

            //3-DiziOlustur() metodu çağırma
            DiziOlustur(20);
            #endregion
        }

        public static void HizHesapla(double yol, double sure) 
        {
            double sonuc = 0;
            sonuc = yol / sure;
            Console.WriteLine($"İstediğiniz Saatte Varmak İçin Gitmeniz Gereken Hız: {sonuc}");
        }

        public static void DiziOlustur(int elemanSayisi)
        {
            Random rnd = new Random();
            int [] randomDizi = new int [20];

            for (int i = 0; i < 100; i++)
            {
                randomDizi[i] = rnd.Next(1, 100);
            }
            Console.WriteLine($"Rastgele Diziniz Oluşturuldu: {elemanSayisi}");
            foreach (int num in randomDizi)
            {
                Console.Write(num + " ");
            }
        }

    }
}
