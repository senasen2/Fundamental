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
             *     kosul doğru olduüu sürece
             *}
             */

            #region 0 girilene kadar ekrandan okutulan sayıları toplayıp yazdıralım.
            //BURADAN DEVAM
            //string sayi;
            //sayi = Console.ReadLine();
            //sayi.ToString;
            //while (sayi == 0)
            //{
            //    Console.WriteLine(sayi);
            //}
            #endregion
            #endregion
        }
    }
}
