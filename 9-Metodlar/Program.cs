using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _9_Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Konu Anlatımı
            /*
             * Metod Nedir? ==> Belirli bir işlevi yerine getirmek için kullanılan kod bloğudur.
             *Metod tipleri ==> geriye değer dönen ya da dönmeyen metodlar
             *Eğer metodlar geriye değer dönmeyecek ise void olarak işaretlenmek zorundadır.
             *Eğer değer dönecekse tipi belirtmek zorundadır.
             *Bütün metodlar parametrik şekilde olabilir.
             *Yani bir metod tipini belirtmek şartı ile istediğiniz kadar parametre gönderebilirisiniz.
             *             * Faydalari : Kodun tekrarini engeller. Tekrar kullanimi saglar
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

            #region Metod İmzası
            /*
             * Aldgi parametreler farkli oldugu surece ayni isimde metod yazilabilir.
             * Buna metod overload yani aşırı yuklenmesi denir.
             * 
             * Metodun geri donus tipi imzaya dahil degildir.
             */
            #endregion

            #region İki Sayıyı Toplayacak Metod
            //public static void Topla(int sayi1,sayi2)
            //public static void long(int sayi1,sayi2)
            #endregion

            #region Metod Çağırma
            //Topla(3, 98);
            #endregion

            #region Sorular
            /* 1- Kendisine gelen mesaji ekrana yazan metod EkranaYaz()
             * 2- Ekrandan sayi okutup int donen sayioku metodu yaziniz.
             * 3- iki adet integer deger alip bir adet string operator alsin 
             *     Gelen operatore gore 4 islem sonucunu ekrana yazdirsin
             */

            //EkranaYaz metodu çağırma
            Console.WriteLine("Mesajınızı yazınız:");
            EkranaYaz(Console.ReadLine());

            //Ekrandan SayiOku metodu çağırma
            //int sayi = Sayioku("Bir sayı giriniz:");

            //IslemYap metodu çağırma
            IslemYap(32,8,"/");
            #endregion
        }

        public static void IslemYap(int number, int number2, string islem)
        {
            int sonuc = 0;
            switch (islem)
            {
                case "+":
                    sonuc = number + number2;
                    break;
                case "-":
                    sonuc = number - number2;
                    break;
                case "*":
                    sonuc = number * number2; 
                    break;
                case "/":
                    if (number2 != 0)
                    {
                        sonuc = number / number2;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı işlem yaptınız!");
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem!");
                    break;
            } 
            Console.WriteLine(sonuc);
        }

        public static int Sayioku(string mesaj)
        {
            int sayi;
            bool sonuc;
            do
            {
                sonuc = int.TryParse(Console.ReadLine(), out sayi);
            } while (!sonuc);
            return sayi;
        }

        public static void EkranaYaz(string mesaj) 
        {
            Console.WriteLine($"Gelen Mesaj: {mesaj}");
        }

        //public static void Topla(int sayi1, int sayi2) 
        //{
        //    Console.WriteLine($"Toplam:{sayi1 + sayi2}");
        //}

        //public static long Topla(long sayi1, int sayi2) 
        //{
        //    return sayi1 + sayi2; 
        //}


    }
}
