namespace _5_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DİZİLER");

            #region Diziler Konu Anlatımı
            /*
             * Birden fazla aynı tipten veriyi bir arada tutmamızı sağlayan
             * nesnelerdir. Dizilerin eleman sayısı sabittir. Sonradan değiştirilemezler.
             * Index her zaman 0'dan başlar
             * Çok karşılaşılan hata : Index was outside the bound of the array.
             * Bu hata da dizinin eleman sayısının dışında bir işlem yapılıyor demektir.
             * Tanımlama Kuralı : <veri tipi>[] diziAdi;
             *                    int[] sayilar;
             *                    DateTime[] tarihler;
             *                    bool[] test;
             */
            #endregion

            #region Dizi Tanımlama ve Değer Atama
            int[] notlar; //Burada dizi tanımlanmış olsada eleman sayısı belli değildir.
            int[] sayilar = new int[10]; // Bu 10 elemanlı bir dizidir. Default değerleri 0'dır
            int[] sayilar2 = { 0,1,2,3,4,5,6,7,8,9,10}; // 10 elemanlı bir dizidir. Burada ilk değer ataması yapılmıştır.

            //Tek tek değer atamak için dizi 'index' kullanılır.
            sayilar[3] = 20; // Dördüncü elemana 20 değeri atanmıştır.

            //Dizilerin ekrana bastırılması için bildiğimiz döngülerin hepsi geçerlidir.
            //Genelde for döngüsü kullanılır.
            //Ancak sıklıkla foreach de kullanılır.
            //Foreach döngü değildir. İterasyondur.
            //Arada ki fark 1-10 arasındaki sayıları foreach ile ekrana yazdıramayız.
            //Foreach için mutlaka bir veri seti gereklidir. Bu ister dizi ister liste olabilir.
            //for (int i = 200; i > 100; i--)
            //{

            //}

            #region VAR Keyword
            /*
             * var javascriptde ki 'var benzeridir'
             * runtime sırasında veri tipi belli olur
             * Veri tipi belli olduktan sonrasında artık başka bir veri tipi atanamaz.
             */

            var temp = DateTime.Now;
            #endregion

            //foreach (var item in sayilar2)
            //{

            //}
            #endregion
        }
    }
}
