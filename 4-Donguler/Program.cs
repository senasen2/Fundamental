namespace _4_Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* KONU ANLATIMI
             * 3 adet döngümüz var 
             * for / while / do - while
             * foreach dongu değildir. İterasyondur.
             * Yani foreach çalışabilmesi için
             * mutlaka elimizde bir dataset olması gerekir.
             * Yani ya bir dizi olacak ya da bir liste vb. bir dataset olacak
             *
             */

            #region For Döngüsü
            /*
             * For döngüsü için bir başlangıç değeri gerekir.
             * Bir koşul olacak ve artım miktarı olacak.
             * Syntax => for(baslangic; kosul; artim)
             * {
             * 
             * }
             */

            //int temp = 0;
            //int sayi = temp++; //Önce atama yapıp sonra sayıyı 1 arttırır.
            //sayi = ++temp; //Önce sayıyı arttırır sonra atama yapar.

            #region 1 ile 10 arasında ki sayıları bastıralım
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // 10 ile 20 arasında ki sayıları bastıralım

            //for (int j = 10; j <= 20; j++)
            //{
            //    Console.WriteLine(j);
            //}

            // 50 ile 20 arasında ki sayıları bastıralım

            //for (int s = 50; s >= 20; s--)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion

            #region İlk on sayının toplamı ve ortalaması
            //int toplam = 0; // toplamı tutacak değişkeni belirledim.
            //int toplamSayi = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    toplam += i; //her adımda toplama ekleniyor.
            //    toplamSayi++; //burada ilk başta i değişkenini arttırdım ama kodda hata oldu çünkü her defasında i değişkenini arttıyordu ama hep bir önceki i değişkeninin kullanıyordu sonradan hatamı anladım i zaten döngünün içinde dönüyor sadece toplamı toplamak için ++ kullanmak gerekiyordu..
            //}
            //Console.WriteLine("İlk 10 Sayının Toplamı:" + toplam);
            //Console.WriteLine("İlk 10 Sayının Ortalaması:" +toplam / toplamSayi);
            #endregion

            #region 2015 ile 2025 arasında ki yılları ekrana basınız ancak pandemi yılını(2020) yılını yazdırmayınız. 
            //Birinci yöntem;
            //for (int i = 2015; i < 2026; i++)
            //{
            //    if (i != 2020)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (int i = 2015; i < 2026; i++)
            //{
            //    if (i == 2020)
            //    {
            //        continue;

            //    }
            //    Console.WriteLine(i);
            //} 

            //Döngüyü kırmak için 'break' kullanacağız.

            //for (int i = 2015; i < 2026; i++)
            //{
            //    if (i == 2020)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //programdan çıkmak için 'return' kullanacağız.
            //for (int i = 2015; i < 2026; i++)
            //{
            //    if (i == 2020)
            //        return;
            //        Console.WriteLine(i);

            //}
            //Console.WriteLine("PROGRAM SONU"); //RETURN KULLANDIĞIMIZ İÇİN BU KODA GELMEYECEKTİR VE BU KOD ÇALIŞMAYACAKTIR.
            #endregion
            #endregion

            #region WHILE DÖNGÜSÜ
            /*
             * While döngüsü koşul doğru olduğu sürece işlemleri gerçekleştiren bir döngüdür.
             *genel syntax
             *while(kosul)
             *{
             *     kosul doğru olduğu sürece
             *}
             */

            #region 0 girilene kadar ekrandan okutulan sayıları toplayıp yazdıralım.
            //int toplam = 0, sayi = 1, sayac = 0;
            //while (sayi != 0)
            //{
            //    Console.WriteLine("Sayıyı giriniz;");
            //    sayi = int.Parse(Console.ReadLine());
            //    toplam += sayi; //toplam = toplam +sayi;
            //    sayac++; //sayac = sayav + 1;
            //}
            ////Console.WriteLine("Girilen Sayıların Adedi" + sayac + "Toplamı:" + toplam);
            ////Console.WriteLine("Girilen Sayıların Adedi {0} Toplamı : {1}" , sayac, toplam);
            //Console.WriteLine($"Girilen Sayıların Adedi { sayac} Toplamı: { toplam}");
            #endregion

            #region Sayı Tahmin Oyunu (1 - 50 arası)
            //Kullanıcıya 5 tahmin haklı verilecek.
            //Eğer tutulandan daha büyük sayı girilirse daha küçük bir sayı giriniz
            //Eğer tutulandan daha küçük sayı girilirse daha büyük bir sayı giriniz mesajı verilecek

            //Random rnd = new Random();
            //int tutulanSayi = rnd.Next(1,50);
            //byte tahminHakki = 5;
            //Console.WriteLine(tutulanSayi);
            //int oyuncuSayisi = int.Parse(Console.ReadLine());

            //Console.WriteLine("Sayı Tahmin Oyununa Hoşgeldiniz :)");

            //while (tahminHakki > 0)
            //{
            //    Console.WriteLine("Bir sayı tahmin edin:");
            //    int oyuncuSayisi = int.Parse(Console.ReadLine());
            //    if (oyuncuSayisi < tutulanSayi)
            //    {
            //        Console.WriteLine("Daha büyük bir sayı giriniz.");
            //    }
            //    else if (oyuncuSayisi > tutulanSayi)
            //    {
            //        Console.WriteLine("Daha küçük bir sayı giriniz.");
            //    }
            //    else if(oyuncuSayisi == tutulanSayi)    
            //    {
            //        Console.WriteLine($"Tebrikler Doğru Sayıyı Bildiniz :) {6-tahminHakki}. denemede bildiniz");
            //        break;
            //    }
            //    tahminHakki--;  // Tahmin hakkını azaltmak için
            //    Console.WriteLine($"Kalan Tahmin Hakkınız: {tahminHakki}");

            //    // Tahmin hakkı bitti mi?
            //    if (tahminHakki == 0)
            //    {
            //        Console.WriteLine($"Tahmin hakkınız bitti! Doğru sayı: {tutulanSayi}");
            //    }
            //}
            #endregion

            #region İlk 20 Fibonacci Sayısını Yazdırınız
            //Kendinden önceki iki sayının toplamı şeklindedir.

            //int sayi1 = 0, sayi2 = 1, toplam;

            //for (int i = 1; i < 21; i++)
            //{
            //    toplam = sayi1 + sayi2;
            //    Console.WriteLine(toplam + "");
            //    sayi1 = sayi2;
            //    sayi2 = toplam;

            //}

            //Console.ReadLine();

            #endregion

            #region İlk 20 Asal Sayıyı Yazdırınız
            //int sayac = 1, altSayac = 0;

            //for (int i = 1; i < 1000; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            altSayac++;
            //        }
            //    }

            //    if (altSayac == 2)
            //    {
            //        Console.WriteLine(i);
            //        sayac++;
            //    }

            //    altSayac = 0;
            //    if (sayac == 20) break;

            //}
            #endregion


            #region MyRegion

            #endregion
            #endregion
        }
    }
}
