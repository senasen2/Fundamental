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
            #region İlk 10 sayıları bastıralım
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            #endregion
            #endregion
        }
    }
}
