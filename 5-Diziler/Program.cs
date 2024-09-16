using System.Runtime.ConstrainedExecution;

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
            //int[] notlar; //Burada dizi tanımlanmış olsada eleman sayısı belli değildir.
            //int[] sayilar = new int[10]; // Bu 10 elemanlı bir dizidir. Default değerleri 0'dır
            //int[] sayilar2 = { 0,1,2,3,4,5,6,7,8,9,10}; // 10 elemanlı bir dizidir. Burada ilk değer ataması yapılmıştır.

            //Tek tek değer atamak için dizi 'index' kullanılır.
            //sayilar2[3] = 20; // Dördüncü elemana 20 değeri atanmıştır.

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

            //var temp = DateTime.Now;
            //temp = "ali" "veli"; //Burası hata verecektir
            #endregion

            //foreach ile kullanımı
            //foreach (var item in sayilar2)
            //{
            //    Console.WriteLine(item);
            //}

            //for ile kullanımı
            //for (int i = 0; i < sayilar2.Length; i++)
            //{
            //    Console.WriteLine(sayilar2[i]);
            //}
            #endregion

            #region 20 Kişilik Bir Sınıfın Notlarını Rastgele Atayalım
            //int [] notlar = new int[20];
            //Random rnd = new Random();

            //Foreach ile dönerken değer ataması yapılmaz
            //Sık yapılan hatalardandır.
            //foreach (var item in notlar)
            //{
            //    item = rnd.Next(20, 100);
            //}

            //for (int i = 0; i < notlar.Length; i++)
            //{
            //    notlar[i] = rnd.Next(20, 100);
            //}

            //foreach (var item in notlar)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region String e farklı bir bakış
            //string str = "Fenerbahçe";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}
            //foreach (char ch in str)
            //{
            //    Console.WriteLine(ch);
            //}
            #endregion

            #region Çok Boyutlu Diziler
            /*
             * İki boyutlu bir dizi için int[,] matris = new int[2,3];
             * Üç boyutlu "" "" int[,,] kup = new int[3,3,3]
             */
            //Random rnd = new Random();
            //int[,] matris = new int[3, 3];
            //Console.WriteLine($"Matrisin 1.boyutu {matris.GetLength(0)} \nMatrisin 2.boyutu {matris.GetLength(1)}");
            //for (int i = 0; i < matris.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matris.GetLength(1); j++)
            //    {
            //        matris[i, j] = rnd.Next(100);
            //    }
            //}

            //for (int i = 0; i < matris.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matris.GetLength(1); j++)
            //    {
            //        Console.WriteLine(matris[i,j]);
            //    }
            //}
            #endregion

            #region 20 Kişilik Bir Sınıfın İki Vize Bir Final Notunu TutatacaK Bir Diziyi Tanımalayınız.
            //Random  rnd = new Random();
            //int[,] notlar = new int[20,3];
            //int vize1 = 0, vize2 = 0, final = 0;
            //double not =    0;

            //for (int i = 0; i < notlar.GetLength(0); i++)
            //{
            //    for (int j = 0; j < notlar.GetLength(1); j++)
            //    {
            //        notlar[i,j] = rnd.Next(0,100);
            //    }

            //    vize1 = notlar[i, 0];
            //    vize2 = notlar[i, 1];
            //    final = notlar[i, 2];
            //    not = ((vize1+ vize2) * 0.3) + (final * 0.6);

            //    if (not < 50)
            //    {
            //        Console.WriteLine("{0}.öğrenci 1.vize: {1}, 2.vize: {2}, final: {3},toplam not ortalaması {4:F2} - öğrenci kaldı", i + 1, vize1, vize2, final, not);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0}.öğrenci 1.vize: {1}, 2.vize: {2}, final: {3},toplam not ortalaması {4:F2} - öğrenci geçti", i + 1, vize1, vize2, final, not);
            //    }
            //}

            //vizelerin toplamının %30 finalin %70 i alınacak.
            //50 ve üzeri geçti olacak.
            //Bu dizideki öğrencilerin geçme kalma durumunu ekrana yazdırınız
            //0 => 20,40,60 ortalaması :

            #endregion
        }
    }
}
