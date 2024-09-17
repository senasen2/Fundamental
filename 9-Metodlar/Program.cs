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
            Topla(3, 98);
            #endregion
        }

        public static void Topla(int sayi1, int sayi2) 
        {
            Console.WriteLine($"Toplam:{sayi1 + sayi2}");
        }

        public static long Topla(long sayi1, int sayi2) 
        {
            return sayi1 + sayi2; 
        }


    }
}
