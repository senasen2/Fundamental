using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _9_Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Konu Anlatimi
            /*
             * Metod Nedir : Belirli bir işlevi yerine yetirmek icin kullanilan bir kod blogudur
             * Metodlarin tipleri => geriye deger donen yada donmeyen metodlar 
             *                       Eger metodlar geriye deger donmeyecek ise void olarak isaretlenmek zorundadir.
             *                       Eger DEger Donecek ise tipi belirtmek zorundadir.
             * Butun metodlar parametrik şekilde olabilir.
             * Yani bir meyoda tipini belirtmek şarti ile istediginiz kadar parametre gonderebilirsiniz.
             * 
             * Faydalari : Kodun tekrarini engeller. Tekrar kullanimi saglar
             * Kodun okunakligini arttirir. Programi daha moduler hale getirir.
             * 
             * Tanimlama Sekli 
             * 
             * [Erişim belirteci] [Geri Donus Tipi] [MetodAdi](aldigi parametreler) 
             * {
             *    Kodlar buraya...
             * }
             * 
             * [Erişim belirteci] => metoda kimlerin ulasabilecegini belirler 
             *                       public , private ,internal protected seklinde degerler alabilir.
             *                       public => genel kullanima acik demek. Simdilik bunu kullanacagiz.
             * 
             * [Geri Donus Tipi] => Eger bir sey donmeyecekse void olarak isaretlenmelidir.
             *                      Donus tipi int,float,string,datetime v.b.. degerler donebilir.
             *                      Eger geri donus tipi tanimliyse metod sonunda mutlaka return ifadesi olmak zorundadir.
             *                      
             * (aldigi parametreler) => metoda gondermek istedigimiz verilerdir. Ayrac olarak , ile ayrilirlar
             *                          MEtoda gelecek olan parametrelerin mutlaka tiplerinin de yazilmasi zorunludur.
             *  Metodlarin tanimlandigi yerler genelde  class icerisindedir.                     
             */
            #endregion

            #region Metod imzasi.
            /*
             * Aldgi parametreler farkli oldugu surece ayni isimde metod yazilabilir.
             * Buna metod overload yani aşırı yuklenmesi denir.
             * 
             * Metodun geri donus tipi imzaya dahil degildir.
             * 
             * 
             */

            #endregion
            #region iki Sayiyi toplayacak metod 
            // public static void Topla(int sayi1,int sayi2)
            // public static long Topla(int sayi1,int sayi2)

            #endregion

            #region Metod Cagrimi
            //Topla(3, 5);
            //decimal toplam =Topla(3.5m, 5.3m);
            //Console.WriteLine($"Float Toplam:{toplam.ToString("0.00")}");
            #endregion

            #region Sorular
            /* 1- Kendisine gelen mesaji ekrana yazan metod EkranaYaz()
             * 2- Ekrandan sayi okutup int donen sayioku metodu yaziniz.
             * 3- iki adet integer deger alip bir adet string operator alsin 
             *     Gelen operatore gore 4 islem sonucunu ekrana yazdirsin
             * 
             * 
             * 
             */
            #endregion
            //int sayi = SayiOku("Bir sayi giriniz:");
            //double sayi1 = (double)SayiOku("Double bir sayi giriniz:");
            //double sayi2 = (double)SayiOku("Double bir sayi giriniz:");
            //Console.WriteLine( DortIslem(sayi1, sayi2,'/'));

            // Faktoryel alan metod yaziniz 
            //var faktoryel = Faktoryel(12);
            //Console.WriteLine(faktoryel);
            // Verilen sayini verilen ussunu alacak metod long UssunuAl(2,4)
            //long sonuc = Matematik.FaktoryelRecursive(4);
            //Console.WriteLine(sonuc);


        }
    }
}
