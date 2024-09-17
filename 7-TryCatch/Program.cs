namespace _7_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Konu Anlatımı
            /*
             * Try Catch hata yakalamakta kullanılan bir yapıdır.
             * Hata ==> Hataları 3 ana başlıkta ele alabiliriz
             * 1-Syntax hataları ==> Genelde IDE yakalıyor ve daha derlemeden altını çiziyor
             * 2-Runtime sırasında çıkacak hatalar. Çalışma zamanı hataları
             *      Sıfıra bölme hatası, tip dönüşüm hataları ...
             * 3-Mantık Hataları ==> Programcılar tarafından yapılan hatalardır. Bulunması ve çözülmesi zor olan hatalardır. 
             * Debug yaparak çözümlenir
             * 
             */

            #endregion

            #region Örnek 1 - İki Sayıyı Bölme Durumu
            //try
            //{
            //    int sayi1, sayi2;
            //    Console.WriteLine("Birinci Sayıyı Giriniz:");
            //    sayi1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("İkinci Sayıyı Giriniz");
            //    sayi2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Bölüm:{sayi1/sayi2}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    throw;
            //}
            #endregion

            #region Kontrollü Sayı Çevrilmesi
            //int sayi1, sayi2;
            //float fsayi;
            //double dsayi;
            //DateTime dt;
            //bool sonuc, sonuc2;
            //Console.WriteLine("Birinci Sayıyı Giriniz:");
            //sonuc = int.TryParse(Console.ReadLine(), out sayi1);
            //Console.WriteLine("İkinci Sayıyı Giriniz");
            //sonuc2 = int.TryParse(Console.ReadLine(),out sayi2);


            //if (sonuc == true && sonuc2 == true)
            //{
            //    Console.WriteLine("Toplam:" + (sayi1 + sayi2));
            //}

            //sonuc = float.TryParse(Console.ReadLine(), out fsayi);
            //Console.WriteLine("Float:" + fsayi);
            //sonuc = double.TryParse(Console.ReadLine(), out dsayi);
            //Console.WriteLine("Decimal:" + dsayi);

            //sonuc = DateTime.TryParse("01.01.2000", out dt);
            //Console.WriteLine("Tarih:" + dt);
            #endregion
        }
    }
}
